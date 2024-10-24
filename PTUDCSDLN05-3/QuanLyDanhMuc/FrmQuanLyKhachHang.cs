using System;
using System.Windows.Forms;

namespace PTUDCSDLN05_3.QuanLyDanhMuc
{
    public partial class FrmQuanLyKhachHang : Form
    {
        public FrmQuanLyKhachHang()
        {
            InitializeComponent();
            loadDgvCustomer();
        }

        private void loadDgvCustomer()
        {
            dgv_customer.DataSource = Database.Query("select * from KhachHang");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Database.Execute("INSERT KhachHang VALUES" + 
                "(N'" + txt_name.Text + "', N'" + txt_address.Text + "', '" + txt_phone.Text + "')");
            loadDgvCustomer();
        }

   

        private void btn_delete_Click(object sender, EventArgs e)
        {
           Database.Execute("DELETE FROM KhachHang WHERE MaKhachHang = " + dgv_customer.CurrentRow.Cells[0].Value.ToString());
            loadDgvCustomer();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Database.Execute("UPDATE KhachHang SET HoTen = '" + txt_name.Text + "', DiaChi = '" + txt_address.Text + "', DienThoai = '" + txt_phone.Text + "'" +
                " WHERE MaKhachHang = " + dgv_customer.CurrentRow.Cells[0].Value.ToString());
            loadDgvCustomer();
        }

        private void dgv_customer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_userid.Text = dgv_customer.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_name.Text = dgv_customer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_address.Text = dgv_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_phone.Text = dgv_customer.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
