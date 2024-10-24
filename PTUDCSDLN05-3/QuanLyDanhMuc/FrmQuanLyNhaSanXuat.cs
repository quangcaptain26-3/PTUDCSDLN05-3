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
    public partial class FrmQuanLyNhaSanXuat : Form
    {
        public FrmQuanLyNhaSanXuat()
        {
            InitializeComponent();
            loadDgvManufacturer();
        }

        private void loadDgvManufacturer()
        {
            dgv_manufacturer.DataSource = Database.Query("select * from NhaSanXuat");
        }

        private void add_manufacturer_Click(object sender, EventArgs e)
        {
            //lần này thì phải thêm cả txt_manufacturer_id và txt_manufacturer_name
            Database.Execute("INSERT NhaSanXuat VALUES" +
                                              "(" + txt_manufacturer_id.Text + ", N'" + txt_manufacturer_name.Text);
            loadDgvManufacturer();
        }

        private void update_manufacturer_Click(object sender, EventArgs e)
        {
            Database.Execute("UPDATE NhaSanXuat SET TenNhaSanXuat = '" + txt_manufacturer_name.Text + "'" +
                               " WHERE MaNhaSanXuat = " + dgv_manufacturer.CurrentRow.Cells[0].Value.ToString());
        }

        private void delete_manufacturer_Click(object sender, EventArgs e)
        {
            Database.Execute("DELETE FROM NhaSanXuat WHERE MaNhaSanXuat = " + dgv_manufacturer.CurrentRow.Cells[0].Value.ToString());
            loadDgvManufacturer();
        }

        private void dgv_manufacturer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_manufacturer_id.Text = dgv_manufacturer.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_manufacturer_name.Text = dgv_manufacturer.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void FrmQuanLyNhaSanXuat_Load(object sender, EventArgs e)
        {

        }
    }
}
