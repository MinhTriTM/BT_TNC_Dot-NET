import sys
import os
import asyncio
import io
import json
from http.server import HTTPServer, BaseHTTPRequestHandler
from urllib.parse import parse_qs, urlparse

# Kiểm tra thư viện FastAPI & Edge-TTS nếu có
FASTAPI_AVAILABLE = False
try:
    from fastapi import FastAPI, HTTPException, Response
    from fastapi.middleware.cors import CORSMiddleware
    from pydantic import BaseModel
    import uvicorn
    FASTAPI_AVAILABLE = True
except ImportError:
    FASTAPI_AVAILABLE = False

EDGE_TTS_AVAILABLE = False
try:
    import edge_tts
    EDGE_TTS_AVAILABLE = True
except ImportError:
    EDGE_TTS_AVAILABLE = False

# Danh sách giọng AI mặc định (dùng Microsoft Edge Neural Voices miễn phí & chất lượng cao)
DEFAULT_AI_VOICES = [
    {"id": "vi-VN-HoaiMyNeural", "name": "Tiếng Việt - Hoài My (Nữ - AI Neural)", "lang": "vi-VN", "gender": "Female"},
    {"id": "vi-VN-NamMinhNeural", "name": "Tiếng Việt - Nam Minh (Nam - AI Neural)", "lang": "vi-VN", "gender": "Male"},
    {"id": "en-US-AvaNeural", "name": "English (US) - Ava (Female - AI Neural)", "lang": "en-US", "gender": "Female"},
    {"id": "en-US-AndrewNeural", "name": "English (US) - Andrew (Male - AI Neural)", "lang": "en-US", "gender": "Male"},
    {"id": "en-US-EmmaNeural", "name": "English (US) - Emma (Female - AI Neural)", "lang": "en-US", "gender": "Female"},
    {"id": "en-GB-SoniaNeural", "name": "English (UK) - Sonia (Female - AI Neural)", "lang": "en-GB", "gender": "Female"},
    {"id": "ja-JP-NanamiNeural", "name": "Japanese - Nanami (Female - AI Neural)", "lang": "ja-JP", "gender": "Female"},
    {"id": "zh-CN-XiaoxiaoNeural", "name": "Chinese - Xiaoxiao (Female - AI Neural)", "lang": "zh-CN", "gender": "Female"},
]

async def generate_edge_tts_audio(text: str, voice: str, rate: int = 0, pitch: int = 0) -> bytes:
    """Tạo audio từ Edge-TTS AI Engine"""
    if not EDGE_TTS_AVAILABLE:
        raise Exception("Thư viện edge-tts chưa được cài đặt.")
    
    # Định dạng rate và pitch cho edge-tts (+0%, +10%, -10%...)
    rate_str = f"{'+' if rate >= 0 else ''}{rate}%"
    pitch_str = f"{'+' if pitch >= 0 else ''}{pitch}Hz"
    
    communicate = edge_tts.Communicate(text, voice, rate=rate_str, pitch=pitch_str)
    audio_data = bytearray()
    async for chunk in communicate.stream():
        if chunk["type"] == "audio":
            audio_data.extend(chunk["data"])
    return bytes(audio_data)

if FASTAPI_AVAILABLE:
    app = FastAPI(title="VoiceCraft AI TTS Engine", version="1.0.0")

    app.add_middleware(
        CORSMiddleware,
        allow_origins=["*"],
        allow_credentials=True,
        allow_methods=["*"],
        allow_headers=["*"],
    )

    class TTSRequest(BaseModel):
        text: str
        voice: str = "vi-VN-HoaiMyNeural"
        rate: int = 0
        pitch: int = 0

    @app.get("/")
    def read_root():
        return {
            "status": "online",
            "engine": "VoiceCraft AI TTS Backend",
            "edge_tts_installed": EDGE_TTS_AVAILABLE
        }

    @app.get("/voices")
    async def get_voices():
        if EDGE_TTS_AVAILABLE:
            try:
                voices = await edge_tts.VoicesManager.create()
                vi_voices = []
                other_voices = []
                for v in voices.voices:
                    item = {
                        "id": v["ShortName"],
                        "name": f"{v['Locale']} - {v['FriendlyName']}",
                        "lang": v["Locale"],
                        "gender": v["Gender"]
                    }
                    if v["Locale"] == "vi-VN":
                        vi_voices.append(item)
                    elif v["Locale"] in ["en-US", "en-GB", "ja-JP", "zh-CN", "fr-FR", "de-DE"]:
                        other_voices.append(item)
                
                # Ưu tiên giọng Tiếng Việt lên đầu danh sách
                result_voices = vi_voices + other_voices
                if result_voices:
                    return result_voices
            except Exception as e:
                print(f"Lỗi tải danh sách voices từ edge_tts: {e}")
        return DEFAULT_AI_VOICES

    @app.post("/synthesize")
    async def synthesize(req: TTSRequest):
        if not req.text.strip():
            raise HTTPException(status_code=400, detail="Văn bản không được để trống")
        
        try:
            audio_bytes = await generate_edge_tts_audio(
                text=req.text,
                voice=req.voice,
                rate=req.rate,
                pitch=req.pitch
            )
            return Response(content=audio_bytes, media_type="audio/mpeg")
        except Exception as e:
            raise HTTPException(status_code=500, detail=f"Lỗi tổng hợp giọng nói AI: {str(e)}")

    def run_server():
        port = 8000
        print(f"🚀 AI Backend Server đang khởi động tại http://127.0.0.1:{port}")
        uvicorn.run(app, host="127.0.0.1", port=port, log_level="info")

else:
    # Fallback Lightweight HTTP Server nếu máy chưa cài FastAPI / Uvicorn
    class FallbackHTTPRequestHandler(BaseHTTPRequestHandler):
        def do_GET(self):
            parsed_path = urlparse(self.path)
            if parsed_path.path == "/":
                self.send_response(200)
                self.send_header('Content-Type', 'application/json')
                self.end_headers()
                res = json.dumps({"status": "online", "mode": "fallback", "edge_tts": EDGE_TTS_AVAILABLE})
                self.wfile.write(res.encode('utf-8'))
            elif parsed_path.path == "/voices":
                self.send_response(200)
                self.send_header('Content-Type', 'application/json; charset=utf-8')
                self.end_headers()
                self.wfile.write(json.dumps(DEFAULT_AI_VOICES, ensure_ascii=False).encode('utf-8'))
            else:
                self.send_response(404)
                self.end_headers()

        def do_POST(self):
            parsed_path = urlparse(self.path)
            if parsed_path.path == "/synthesize":
                content_length = int(self.headers.get('Content-Length', 0))
                body = self.rfile.read(content_length)
                try:
                    data = json.loads(body.decode('utf-8'))
                    text = data.get("text", "")
                    voice = data.get("voice", "vi-VN-HoaiMyNeural")
                    rate = data.get("rate", 0)
                    pitch = data.get("pitch", 0)

                    loop = asyncio.new_event_loop()
                    asyncio.set_event_loop(loop)
                    audio_bytes = loop.run_until_complete(
                        generate_edge_tts_audio(text, voice, rate, pitch)
                    )
                    loop.close()

                    self.send_response(200)
                    self.send_header('Content-Type', 'audio/mpeg')
                    self.end_headers()
                    self.wfile.write(audio_bytes)
                except Exception as e:
                    self.send_response(500)
                    self.send_header('Content-Type', 'application/json; charset=utf-8')
                    self.end_headers()
                    err_res = json.dumps({"error": str(e)}, ensure_ascii=False)
                    self.wfile.write(err_res.encode('utf-8'))
            else:
                self.send_response(404)
                self.end_headers()

    def run_server():
        port = 8000
        server = HTTPServer(('127.0.0.1', port), FallbackHTTPRequestHandler)
        print(f"🚀 Fallback AI Backend Server đang khởi động tại http://127.0.0.1:{port}")
        server.serve_forever()

if __name__ == "__main__":
    run_server()
