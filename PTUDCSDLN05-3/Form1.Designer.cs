namespace PTUDCSDLN05_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu_banhang = new System.Windows.Forms.MenuStrip();
            this.mns_hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_quanlynguoidung = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_signin = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_signout = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_danhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_nsx = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_ncc = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_user_management = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_product_detail = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_laptop = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_ram = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_storage = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_screen = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_sell_product = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_nhaphang = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_banhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_total = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_total_nhaphang = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_total_banhang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_banhang.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_banhang
            // 
            this.menu_banhang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_banhang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mns_hethong,
            this.mns_danhmuc,
            this.mns_product_detail,
            this.mns_sell_product,
            this.mns_total});
            this.menu_banhang.Location = new System.Drawing.Point(0, 0);
            this.menu_banhang.Name = "menu_banhang";
            this.menu_banhang.Size = new System.Drawing.Size(1076, 28);
            this.menu_banhang.TabIndex = 0;
            this.menu_banhang.Text = "menuStrip1";
            // 
            // mns_hethong
            // 
            this.mns_hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_quanlynguoidung,
            this.mni_signin,
            this.mni_signout});
            this.mns_hethong.Name = "mns_hethong";
            this.mns_hethong.Size = new System.Drawing.Size(144, 24);
            this.mns_hethong.Text = "Quản Lý Hệ Thống";
            this.mns_hethong.Click += new System.EventHandler(this.mns_hethong_Click);
            // 
            // mni_quanlynguoidung
            // 
            this.mni_quanlynguoidung.Name = "mni_quanlynguoidung";
            this.mni_quanlynguoidung.Size = new System.Drawing.Size(230, 26);
            this.mni_quanlynguoidung.Text = "Quản Lý Người Dùng";
            // 
            // mni_signin
            // 
            this.mni_signin.Name = "mni_signin";
            this.mni_signin.Size = new System.Drawing.Size(230, 26);
            this.mni_signin.Text = "Đăng Nhập";
            // 
            // mni_signout
            // 
            this.mni_signout.Name = "mni_signout";
            this.mni_signout.Size = new System.Drawing.Size(230, 26);
            this.mni_signout.Text = "Đăng xuất";
            // 
            // mns_danhmuc
            // 
            this.mns_danhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_nsx,
            this.mni_ncc,
            this.mni_user_management});
            this.mns_danhmuc.Name = "mns_danhmuc";
            this.mns_danhmuc.Size = new System.Drawing.Size(146, 24);
            this.mns_danhmuc.Text = "Quản Lý Danh Mục";
            // 
            // mni_nsx
            // 
            this.mni_nsx.Name = "mni_nsx";
            this.mni_nsx.Size = new System.Drawing.Size(234, 26);
            this.mni_nsx.Text = "Quản lý nhà sản xuất";
            // 
            // mni_ncc
            // 
            this.mni_ncc.Name = "mni_ncc";
            this.mni_ncc.Size = new System.Drawing.Size(234, 26);
            this.mni_ncc.Text = "Quản lý nhà cung cấp";
            // 
            // mni_user_management
            // 
            this.mni_user_management.Name = "mni_user_management";
            this.mni_user_management.Size = new System.Drawing.Size(234, 26);
            this.mni_user_management.Text = "Quản lý khách hàng";
            // 
            // mns_product_detail
            // 
            this.mns_product_detail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_laptop,
            this.mni_ram,
            this.mni_storage,
            this.mni_screen});
            this.mns_product_detail.Name = "mns_product_detail";
            this.mns_product_detail.Size = new System.Drawing.Size(214, 24);
            this.mns_product_detail.Text = "Quản Lý Thông Tin Sản Phẩm";
            // 
            // mni_laptop
            // 
            this.mni_laptop.Name = "mni_laptop";
            this.mni_laptop.Size = new System.Drawing.Size(224, 26);
            this.mni_laptop.Text = "Quản lý Laptop";
            // 
            // mni_ram
            // 
            this.mni_ram.Name = "mni_ram";
            this.mni_ram.Size = new System.Drawing.Size(224, 26);
            this.mni_ram.Text = "Quản lý RAM";
            // 
            // mni_storage
            // 
            this.mni_storage.Name = "mni_storage";
            this.mni_storage.Size = new System.Drawing.Size(224, 26);
            this.mni_storage.Text = "Quản lý ổ cứng";
            // 
            // mni_screen
            // 
            this.mni_screen.Name = "mni_screen";
            this.mni_screen.Size = new System.Drawing.Size(224, 26);
            this.mni_screen.Text = "Quản lý màn hình";
            // 
            // mns_sell_product
            // 
            this.mns_sell_product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_nhaphang,
            this.mni_banhang});
            this.mns_sell_product.Name = "mns_sell_product";
            this.mns_sell_product.Size = new System.Drawing.Size(195, 24);
            this.mns_sell_product.Text = "Quản lý nhập và bán hàng";
            // 
            // mni_nhaphang
            // 
            this.mni_nhaphang.Name = "mni_nhaphang";
            this.mni_nhaphang.Size = new System.Drawing.Size(224, 26);
            this.mni_nhaphang.Text = "Quản lý nhập hàng";
            // 
            // mni_banhang
            // 
            this.mni_banhang.Name = "mni_banhang";
            this.mni_banhang.Size = new System.Drawing.Size(224, 26);
            this.mni_banhang.Text = "Quản lý bán hàng";
            // 
            // mns_total
            // 
            this.mns_total.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_total_nhaphang,
            this.mni_total_banhang});
            this.mns_total.Name = "mns_total";
            this.mns_total.Size = new System.Drawing.Size(142, 24);
            this.mns_total.Text = "Thống kê báo cáo";
            // 
            // mni_total_nhaphang
            // 
            this.mni_total_nhaphang.Name = "mni_total_nhaphang";
            this.mni_total_nhaphang.Size = new System.Drawing.Size(224, 26);
            this.mni_total_nhaphang.Text = "Báo cáo nhập hàng";
            // 
            // mni_total_banhang
            // 
            this.mni_total_banhang.Name = "mni_total_banhang";
            this.mni_total_banhang.Size = new System.Drawing.Size(224, 26);
            this.mni_total_banhang.Text = "Báo cáo bán hàng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.menu_banhang);
            this.MainMenuStrip = this.menu_banhang;
            this.Name = "Form1";
            this.Text = "Quản lý cửa hàng bàn máy tính";
            this.menu_banhang.ResumeLayout(false);
            this.menu_banhang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_banhang;
        private System.Windows.Forms.ToolStripMenuItem mns_hethong;
        private System.Windows.Forms.ToolStripMenuItem mns_danhmuc;
        private System.Windows.Forms.ToolStripMenuItem mns_product_detail;
        private System.Windows.Forms.ToolStripMenuItem mni_quanlynguoidung;
        private System.Windows.Forms.ToolStripMenuItem mni_signin;
        private System.Windows.Forms.ToolStripMenuItem mni_signout;
        private System.Windows.Forms.ToolStripMenuItem mni_nsx;
        private System.Windows.Forms.ToolStripMenuItem mni_ncc;
        private System.Windows.Forms.ToolStripMenuItem mni_user_management;
        private System.Windows.Forms.ToolStripMenuItem mni_laptop;
        private System.Windows.Forms.ToolStripMenuItem mni_ram;
        private System.Windows.Forms.ToolStripMenuItem mni_storage;
        private System.Windows.Forms.ToolStripMenuItem mni_screen;
        private System.Windows.Forms.ToolStripMenuItem mns_sell_product;
        private System.Windows.Forms.ToolStripMenuItem mni_nhaphang;
        private System.Windows.Forms.ToolStripMenuItem mni_banhang;
        private System.Windows.Forms.ToolStripMenuItem mns_total;
        private System.Windows.Forms.ToolStripMenuItem mni_total_nhaphang;
        private System.Windows.Forms.ToolStripMenuItem mni_total_banhang;
    }
}

