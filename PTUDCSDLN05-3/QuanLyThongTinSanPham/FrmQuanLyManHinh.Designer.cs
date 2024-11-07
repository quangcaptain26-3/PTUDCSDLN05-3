namespace PTUDCSDLN05_3.QuanLyThongTinSanPham
{
    partial class FrmQuanLyManHinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_screen_name = new System.Windows.Forms.TextBox();
            this.nud_screen_price = new System.Windows.Forms.NumericUpDown();
            this.nud_screen_size = new System.Windows.Forms.NumericUpDown();
            this.nud_screen_light = new System.Windows.Forms.NumericUpDown();
            this.txt_screen_resolution = new System.Windows.Forms.TextBox();
            this.cbb_screen_manufacturer = new System.Windows.Forms.ComboBox();
            this.btn_screen_add = new System.Windows.Forms.Button();
            this.dgv_screen_load = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nud_screen_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_screen_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_screen_light)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_screen_load)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kích thước";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Độ phân giải";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(590, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Độ sáng";
            // 
            // txt_screen_name
            // 
            this.txt_screen_name.Location = new System.Drawing.Point(189, 73);
            this.txt_screen_name.Name = "txt_screen_name";
            this.txt_screen_name.Size = new System.Drawing.Size(377, 22);
            this.txt_screen_name.TabIndex = 7;
            // 
            // nud_screen_price
            // 
            this.nud_screen_price.Location = new System.Drawing.Point(189, 142);
            this.nud_screen_price.Name = "nud_screen_price";
            this.nud_screen_price.Size = new System.Drawing.Size(129, 22);
            this.nud_screen_price.TabIndex = 8;
            // 
            // nud_screen_size
            // 
            this.nud_screen_size.DecimalPlaces = 1;
            this.nud_screen_size.Location = new System.Drawing.Point(155, 264);
            this.nud_screen_size.Name = "nud_screen_size";
            this.nud_screen_size.Size = new System.Drawing.Size(129, 22);
            this.nud_screen_size.TabIndex = 9;
            // 
            // nud_screen_light
            // 
            this.nud_screen_light.Location = new System.Drawing.Point(677, 264);
            this.nud_screen_light.Name = "nud_screen_light";
            this.nud_screen_light.Size = new System.Drawing.Size(129, 22);
            this.nud_screen_light.TabIndex = 11;
            // 
            // txt_screen_resolution
            // 
            this.txt_screen_resolution.Location = new System.Drawing.Point(412, 263);
            this.txt_screen_resolution.Name = "txt_screen_resolution";
            this.txt_screen_resolution.Size = new System.Drawing.Size(154, 22);
            this.txt_screen_resolution.TabIndex = 12;
            // 
            // cbb_screen_manufacturer
            // 
            this.cbb_screen_manufacturer.FormattingEnabled = true;
            this.cbb_screen_manufacturer.Location = new System.Drawing.Point(189, 195);
            this.cbb_screen_manufacturer.Name = "cbb_screen_manufacturer";
            this.cbb_screen_manufacturer.Size = new System.Drawing.Size(340, 24);
            this.cbb_screen_manufacturer.TabIndex = 13;
            // 
            // btn_screen_add
            // 
            this.btn_screen_add.Location = new System.Drawing.Point(62, 320);
            this.btn_screen_add.Name = "btn_screen_add";
            this.btn_screen_add.Size = new System.Drawing.Size(127, 52);
            this.btn_screen_add.TabIndex = 15;
            this.btn_screen_add.Text = "Thêm";
            this.btn_screen_add.UseVisualStyleBackColor = true;
            this.btn_screen_add.Click += new System.EventHandler(this.btn_screen_add_Click);
            // 
            // dgv_screen_load
            // 
            this.dgv_screen_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_screen_load.Location = new System.Drawing.Point(62, 400);
            this.dgv_screen_load.Name = "dgv_screen_load";
            this.dgv_screen_load.RowHeadersWidth = 51;
            this.dgv_screen_load.RowTemplate.Height = 24;
            this.dgv_screen_load.Size = new System.Drawing.Size(922, 311);
            this.dgv_screen_load.TabIndex = 16;
            // 
            // FrmQuanLyManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 811);
            this.Controls.Add(this.dgv_screen_load);
            this.Controls.Add(this.btn_screen_add);
            this.Controls.Add(this.cbb_screen_manufacturer);
            this.Controls.Add(this.txt_screen_resolution);
            this.Controls.Add(this.nud_screen_light);
            this.Controls.Add(this.nud_screen_size);
            this.Controls.Add(this.nud_screen_price);
            this.Controls.Add(this.txt_screen_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuanLyManHinh";
            this.Text = "FrmQuanLyManHinh";
            ((System.ComponentModel.ISupportInitialize)(this.nud_screen_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_screen_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_screen_light)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_screen_load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_screen_name;
        private System.Windows.Forms.NumericUpDown nud_screen_price;
        private System.Windows.Forms.NumericUpDown nud_screen_size;
        private System.Windows.Forms.NumericUpDown nud_screen_light;
        private System.Windows.Forms.TextBox txt_screen_resolution;
        private System.Windows.Forms.ComboBox cbb_screen_manufacturer;
        private System.Windows.Forms.Button btn_screen_add;
        private System.Windows.Forms.DataGridView dgv_screen_load;
    }
}