using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDCSDLN05_3.QuanLyDanhMuc
{
    public partial class FrmQuanLyNhaCungCap : Form
    {
        public FrmQuanLyNhaCungCap()
        {
            InitializeComponent();
            loadDgvSupplier();
        }

        private void loadDgvSupplier()
        {
            dgv_supplier.DataSource = Database.Query("select * from NhaCungCap");
        }

        private void add_supplier_Click(object sender, EventArgs e)
        {
            Database.Execute("INSERT NhaCungCap VALUES" +
                               "(N'" + txt_supplier_name.Text + "', N'" + txt_supplier_address.Text + "', '" + txt_supplier_phone.Text + "')");
            loadDgvSupplier();

        }

        private void update_supplier_Click(object sender, EventArgs e)
        {
            Database.Execute("UPDATE NhaCungCap SET TenNhaCungCap = '" + txt_supplier_name.Text + "', DiaChi = '" + txt_supplier_address.Text + "', DienThoai = '" + txt_supplier_phone.Text + "'" +
                                            " WHERE MaNhaCungCap = " + dgv_supplier.CurrentRow.Cells[0].Value.ToString());
            loadDgvSupplier();
        }

        private void delete_supplier_Click(object sender, EventArgs e)
        {
            Database.Execute("DELETE FROM NhaCungCap WHERE MaNhaCungCap = " + dgv_supplier.CurrentRow.Cells[0].Value.ToString());
            loadDgvSupplier();
        }

        private void dgv_supplier_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_supplier_id.Text = dgv_supplier.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_supplier_name.Text = dgv_supplier.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_supplier_address.Text = dgv_supplier.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_supplier_phone.Text = dgv_supplier.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
