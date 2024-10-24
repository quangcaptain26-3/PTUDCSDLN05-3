using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDCSDLN05_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mns_hethong_Click(object sender, EventArgs e)
        {
            //hiển thị các danh mục khi click vào menu hệ thống
            mns_hethong.ShowDropDown();

        }
    }
}
