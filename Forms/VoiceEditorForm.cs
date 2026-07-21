using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TTS_Windows_App.Models;
using TTS_Windows_App.Services;

namespace TTS_Windows_App.Forms
{
    public partial class VoiceEditorForm : Form
    {
        public VieNeuVoiceItem VoiceItem { get; private set; }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public VoiceEditorForm(VieNeuVoiceItem existingItem = null)
        {
            InitializeComponent();
            ApplyFormRoundedCorners(14);
            VoiceItem = existingItem;
        }

        private void VoiceEditorForm_Load(object sender, EventArgs e)
        {
            if (VoiceItem != null)
            {
                lblTitle.Text = "✏️ Chỉnh Sửa Mục Giọng Đọc";
                txtName.Text = VoiceItem.Name;
                txtId.Text = VoiceItem.Id;

                SetComboValue(cboGender, VoiceItem.Gender);
                SetComboValue(cboAge, VoiceItem.Age);
                SetComboValue(cboPersona, VoiceItem.Persona);
                SetComboValue(cboRegion, VoiceItem.Region);
            }
            else
            {
                lblTitle.Text = "➕ Thêm Mục Giọng Đọc Mới";
                txtName.Text = "Giọng Đọc Custom Mới";
                txtId.Text = "custom_voice_" + DateTime.Now.Ticks % 1000;

                if (cboGender.SelectedIndex < 0 && cboGender.Items.Count > 0) cboGender.SelectedIndex = 0;
                if (cboAge.SelectedIndex < 0 && cboAge.Items.Count > 0) cboAge.SelectedIndex = 1;
                if (cboPersona.SelectedIndex < 0 && cboPersona.Items.Count > 0) cboPersona.SelectedIndex = 0;
                if (cboRegion.SelectedIndex < 0 && cboRegion.Items.Count > 0) cboRegion.SelectedIndex = 0;
            }
        }

        private void SetComboValue(ComboBox cbo, string value)
        {
            if (string.IsNullOrEmpty(value)) return;
            for (int i = 0; i < cbo.Items.Count; i++)
            {
                if (cbo.Items[i].ToString().Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    cbo.SelectedIndex = i;
                    return;
                }
            }
            cbo.Text = value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên hiển thị cho giọng đọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã ID cho giọng đọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return;
            }

            VoiceItem = new VieNeuVoiceItem
            {
                Name = txtName.Text.Trim(),
                Id = txtId.Text.Trim(),
                Gender = cboGender.SelectedItem != null ? cboGender.SelectedItem.ToString() : cboGender.Text,
                Age = cboAge.SelectedItem != null ? cboAge.SelectedItem.ToString() : cboAge.Text,
                Persona = cboPersona.SelectedItem != null ? cboPersona.SelectedItem.ToString() : cboPersona.Text,
                Region = cboRegion.SelectedItem != null ? cboRegion.SelectedItem.ToString() : cboRegion.Text
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ApplyFormRoundedCorners(int radius)
        {
            try
            {
                GraphicsPath path = new GraphicsPath();
                int r = radius;
                path.AddArc(0, 0, r, r, 180, 90);
                path.AddArc(Width - r, 0, r, r, 270, 90);
                path.AddArc(Width - r, Height - r, r, r, 0, 90);
                path.AddArc(0, Height - r, r, r, 90, 90);
                path.CloseFigure();
                this.Region = new Region(path);
            }
            catch { }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
