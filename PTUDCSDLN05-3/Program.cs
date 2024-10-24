using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PTUDCSDLN05_3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //tôi muốn chạy FrmQuanLyKhachHang
            Application.Run(new QuanLyDanhMuc.FrmQuanLyNhaSanXuat());
        }
    }
}
