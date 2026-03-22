using System;
using System.Windows.Forms;
using QuanLyCuaHangTapHoa.Forms;

namespace QuanLyCuaHangTapHoa
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chạy trực tiếp form LoaiSanPham
            Application.Run(new frmPhieuNhap());
        }
    }
}