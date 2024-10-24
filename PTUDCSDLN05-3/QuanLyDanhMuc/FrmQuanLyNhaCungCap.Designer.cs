namespace PTUDCSDLN05_3.QuanLyDanhMuc
{
    partial class FrmQuanLyNhaCungCap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_supplier_id = new System.Windows.Forms.TextBox();
            this.txt_supplier_name = new System.Windows.Forms.TextBox();
            this.txt_supplier_address = new System.Windows.Forms.TextBox();
            this.txt_supplier_phone = new System.Windows.Forms.TextBox();
            this.add_supplier = new System.Windows.Forms.Button();
            this.update_supplier = new System.Windows.Forms.Button();
            this.delete_supplier = new System.Windows.Forms.Button();
            this.dgv_supplier = new System.Windows.Forms.DataGridView();
            this.colMaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoaiNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điện thoại:";
            // 
            // txt_supplier_id
            // 
            this.txt_supplier_id.Location = new System.Drawing.Point(239, 48);
            this.txt_supplier_id.Name = "txt_supplier_id";
            this.txt_supplier_id.ReadOnly = true;
            this.txt_supplier_id.Size = new System.Drawing.Size(162, 22);
            this.txt_supplier_id.TabIndex = 4;
            // 
            // txt_supplier_name
            // 
            this.txt_supplier_name.Location = new System.Drawing.Point(239, 101);
            this.txt_supplier_name.Name = "txt_supplier_name";
            this.txt_supplier_name.Size = new System.Drawing.Size(162, 22);
            this.txt_supplier_name.TabIndex = 5;
            // 
            // txt_supplier_address
            // 
            this.txt_supplier_address.Location = new System.Drawing.Point(239, 146);
            this.txt_supplier_address.Name = "txt_supplier_address";
            this.txt_supplier_address.Size = new System.Drawing.Size(162, 22);
            this.txt_supplier_address.TabIndex = 6;
            // 
            // txt_supplier_phone
            // 
            this.txt_supplier_phone.Location = new System.Drawing.Point(239, 191);
            this.txt_supplier_phone.Name = "txt_supplier_phone";
            this.txt_supplier_phone.Size = new System.Drawing.Size(162, 22);
            this.txt_supplier_phone.TabIndex = 7;
            // 
            // add_supplier
            // 
            this.add_supplier.Location = new System.Drawing.Point(42, 310);
            this.add_supplier.Name = "add_supplier";
            this.add_supplier.Size = new System.Drawing.Size(100, 52);
            this.add_supplier.TabIndex = 8;
            this.add_supplier.Text = "Thêm";
            this.add_supplier.UseVisualStyleBackColor = true;
            this.add_supplier.Click += new System.EventHandler(this.add_supplier_Click);
            // 
            // update_supplier
            // 
            this.update_supplier.Location = new System.Drawing.Point(227, 310);
            this.update_supplier.Name = "update_supplier";
            this.update_supplier.Size = new System.Drawing.Size(100, 52);
            this.update_supplier.TabIndex = 9;
            this.update_supplier.Text = "Sửa";
            this.update_supplier.UseVisualStyleBackColor = true;
            this.update_supplier.Click += new System.EventHandler(this.update_supplier_Click);
            // 
            // delete_supplier
            // 
            this.delete_supplier.Location = new System.Drawing.Point(421, 310);
            this.delete_supplier.Name = "delete_supplier";
            this.delete_supplier.Size = new System.Drawing.Size(100, 52);
            this.delete_supplier.TabIndex = 10;
            this.delete_supplier.Text = "Xoá";
            this.delete_supplier.UseVisualStyleBackColor = true;
            this.delete_supplier.Click += new System.EventHandler(this.delete_supplier_Click);
            // 
            // dgv_supplier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_supplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNhaCungCap,
            this.colTenNhaCungCap,
            this.colDiaChiNhaCungCap,
            this.colDienThoaiNhaCungCap});
            this.dgv_supplier.Location = new System.Drawing.Point(53, 435);
            this.dgv_supplier.Name = "dgv_supplier";
            this.dgv_supplier.RowHeadersWidth = 51;
            this.dgv_supplier.RowTemplate.Height = 24;
            this.dgv_supplier.Size = new System.Drawing.Size(797, 324);
            this.dgv_supplier.TabIndex = 11;
            this.dgv_supplier.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_supplier_RowEnter);
            // 
            // colMaNhaCungCap
            // 
            this.colMaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            this.colMaNhaCungCap.HeaderText = "Mã nhà cung cấp";
            this.colMaNhaCungCap.MinimumWidth = 6;
            this.colMaNhaCungCap.Name = "colMaNhaCungCap";
            this.colMaNhaCungCap.ReadOnly = true;
            this.colMaNhaCungCap.Width = 125;
            // 
            // colTenNhaCungCap
            // 
            this.colTenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            this.colTenNhaCungCap.HeaderText = "Tên nhà cung cấp";
            this.colTenNhaCungCap.MinimumWidth = 6;
            this.colTenNhaCungCap.Name = "colTenNhaCungCap";
            this.colTenNhaCungCap.ReadOnly = true;
            this.colTenNhaCungCap.Width = 125;
            // 
            // colDiaChiNhaCungCap
            // 
            this.colDiaChiNhaCungCap.DataPropertyName = "DiaChi";
            this.colDiaChiNhaCungCap.HeaderText = "Địa chỉ";
            this.colDiaChiNhaCungCap.MinimumWidth = 6;
            this.colDiaChiNhaCungCap.Name = "colDiaChiNhaCungCap";
            this.colDiaChiNhaCungCap.ReadOnly = true;
            this.colDiaChiNhaCungCap.Width = 125;
            // 
            // colDienThoaiNhaCungCap
            // 
            this.colDienThoaiNhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDienThoaiNhaCungCap.DataPropertyName = "DienThoai";
            this.colDienThoaiNhaCungCap.HeaderText = "Điện thoại";
            this.colDienThoaiNhaCungCap.MinimumWidth = 6;
            this.colDienThoaiNhaCungCap.Name = "colDienThoaiNhaCungCap";
            this.colDienThoaiNhaCungCap.ReadOnly = true;
            // 
            // FrmQuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 802);
            this.Controls.Add(this.dgv_supplier);
            this.Controls.Add(this.delete_supplier);
            this.Controls.Add(this.update_supplier);
            this.Controls.Add(this.add_supplier);
            this.Controls.Add(this.txt_supplier_phone);
            this.Controls.Add(this.txt_supplier_address);
            this.Controls.Add(this.txt_supplier_name);
            this.Controls.Add(this.txt_supplier_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuanLyNhaCungCap";
            this.Text = "FrmQuanLyNhaCungCap";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_supplier_id;
        private System.Windows.Forms.TextBox txt_supplier_name;
        private System.Windows.Forms.TextBox txt_supplier_address;
        private System.Windows.Forms.TextBox txt_supplier_phone;
        private System.Windows.Forms.Button add_supplier;
        private System.Windows.Forms.Button update_supplier;
        private System.Windows.Forms.Button delete_supplier;
        private System.Windows.Forms.DataGridView dgv_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoaiNhaCungCap;
    }
}