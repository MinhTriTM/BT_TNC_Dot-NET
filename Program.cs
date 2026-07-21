using System;
using System.Windows.Forms;

namespace BT_TNC_Dot_NET
{
    internal static class Program
    {
        /// <summary>
        /// Điểm bắt đầu chính (Main Entry Point) cho ứng dụng Windows Forms
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
