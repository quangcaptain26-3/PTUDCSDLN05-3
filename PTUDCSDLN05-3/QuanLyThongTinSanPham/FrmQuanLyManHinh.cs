using System;
using System.Windows.Forms;

namespace PTUDCSDLN05_3.QuanLyThongTinSanPham
{
    public partial class FrmQuanLyManHinh : Form
    {
        public FrmQuanLyManHinh()
        {
            InitializeComponent();
            loadCbbScreenManufacturer();
            loadDgvScreen();
        }
        
        private void loadDgvScreen()
        {
            dgv_screen_load.DataSource = Database.Query("SELECT SanPham.MaSanPham, TenSanPham, Gia, SoLuong, TenNhaSanXuat, KichThuoc, DoPhanGiai, DoSang FROM SanPham INNER JOIN NhaSanXuat ON SanPham.MaNhaSanXuat = NhaSanXuat.MaNhaSanXuat INNER JOIN Screen ON SanPham.MaSanPham = Screen.MaSanPham ");

        }

        private void loadCbbScreenManufacturer()
        {
            cbb_screen_manufacturer.DisplayMember = "TenNhaSanXuat";
            cbb_screen_manufacturer.ValueMember = "MaNhaSanXuat";
            cbb_screen_manufacturer.DataSource = Database.Query("SELECT * FROM NhaSanXuat");
        }

        private void btn_screen_add_Click(object sender, EventArgs e)
        {
            string sql = "INSERT SanPham VALUES (" +
                "'SC', N'" + txt_screen_name.Text + "', " +
                nud_screen_price.Value.ToString() + ", 0,'" +
                cbb_screen_manufacturer.SelectedValue.ToString() + "')";
           Database.Execute(sql);
           string maSanPham = Database.Query("SELECT MAX(MaSanPham) FROM SanPham").Rows[0][0].ToString();
            sql = "INSERT Screen VALUES ("
                + maSanPham + ", 'SC'" + ", " + nud_screen_size.Value.ToString() + ",N'" + 
                txt_screen_resolution.Text + "'," + nud_screen_light.Value.ToString() + ")";
            Database.Execute(sql);
            loadDgvScreen();

        }
    }
}
