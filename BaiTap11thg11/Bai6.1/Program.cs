using System;
using System.Windows.Forms;
using QuanLyBanHangMini.GUI;

namespace QuanLyBanHangMini
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
