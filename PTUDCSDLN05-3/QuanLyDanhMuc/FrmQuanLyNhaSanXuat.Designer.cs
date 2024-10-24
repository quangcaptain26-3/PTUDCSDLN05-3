namespace PTUDCSDLN05_3.QuanLyDanhMuc
{
    partial class FrmQuanLyNhaSanXuat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_manufacturer = new System.Windows.Forms.DataGridView();
            this.delete_manufacturer = new System.Windows.Forms.Button();
            this.update_manufacturer = new System.Windows.Forms.Button();
            this.add_manufacturer = new System.Windows.Forms.Button();
            this.txt_manufacturer_name = new System.Windows.Forms.TextBox();
            this.txt_manufacturer_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colMaNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manufacturer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_manufacturer
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_manufacturer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_manufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manufacturer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNhaSanXuat,
            this.colTenNhaSanXuat});
            this.dgv_manufacturer.Location = new System.Drawing.Point(146, 403);
            this.dgv_manufacturer.Name = "dgv_manufacturer";
            this.dgv_manufacturer.RowHeadersWidth = 51;
            this.dgv_manufacturer.RowTemplate.Height = 24;
            this.dgv_manufacturer.Size = new System.Drawing.Size(797, 324);
            this.dgv_manufacturer.TabIndex = 23;
            this.dgv_manufacturer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_manufacturer_RowEnter);
            // 
            // delete_manufacturer
            // 
            this.delete_manufacturer.Location = new System.Drawing.Point(514, 278);
            this.delete_manufacturer.Name = "delete_manufacturer";
            this.delete_manufacturer.Size = new System.Drawing.Size(100, 52);
            this.delete_manufacturer.TabIndex = 22;
            this.delete_manufacturer.Text = "Xoá";
            this.delete_manufacturer.UseVisualStyleBackColor = true;
            this.delete_manufacturer.Click += new System.EventHandler(this.delete_manufacturer_Click);
            // 
            // update_manufacturer
            // 
            this.update_manufacturer.Location = new System.Drawing.Point(320, 278);
            this.update_manufacturer.Name = "update_manufacturer";
            this.update_manufacturer.Size = new System.Drawing.Size(100, 52);
            this.update_manufacturer.TabIndex = 21;
            this.update_manufacturer.Text = "Sửa";
            this.update_manufacturer.UseVisualStyleBackColor = true;
            this.update_manufacturer.Click += new System.EventHandler(this.update_manufacturer_Click);
            // 
            // add_manufacturer
            // 
            this.add_manufacturer.Location = new System.Drawing.Point(135, 278);
            this.add_manufacturer.Name = "add_manufacturer";
            this.add_manufacturer.Size = new System.Drawing.Size(100, 52);
            this.add_manufacturer.TabIndex = 20;
            this.add_manufacturer.Text = "Thêm";
            this.add_manufacturer.UseVisualStyleBackColor = true;
            this.add_manufacturer.Click += new System.EventHandler(this.add_manufacturer_Click);
            // 
            // txt_manufacturer_name
            // 
            this.txt_manufacturer_name.Location = new System.Drawing.Point(332, 69);
            this.txt_manufacturer_name.Name = "txt_manufacturer_name";
            this.txt_manufacturer_name.Size = new System.Drawing.Size(162, 22);
            this.txt_manufacturer_name.TabIndex = 17;
            // 
            // txt_manufacturer_id
            // 
            this.txt_manufacturer_id.Location = new System.Drawing.Point(332, 16);
            this.txt_manufacturer_id.Name = "txt_manufacturer_id";
            this.txt_manufacturer_id.Size = new System.Drawing.Size(162, 22);
            this.txt_manufacturer_id.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã nhà cung cấp:";
            // 
            // colMaNhaSanXuat
            // 
            this.colMaNhaSanXuat.DataPropertyName = "MaNhaSanXuat";
            this.colMaNhaSanXuat.HeaderText = "Mã nhà sản xuất";
            this.colMaNhaSanXuat.MinimumWidth = 6;
            this.colMaNhaSanXuat.Name = "colMaNhaSanXuat";
            this.colMaNhaSanXuat.ReadOnly = true;
            this.colMaNhaSanXuat.Width = 125;
            // 
            // colTenNhaSanXuat
            // 
            this.colTenNhaSanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNhaSanXuat.DataPropertyName = "TenNhaSanXuat";
            this.colTenNhaSanXuat.HeaderText = "Tên nhà sản xuất";
            this.colTenNhaSanXuat.MinimumWidth = 6;
            this.colTenNhaSanXuat.Name = "colTenNhaSanXuat";
            this.colTenNhaSanXuat.ReadOnly = true;
            // 
            // FrmQuanLyNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 742);
            this.Controls.Add(this.dgv_manufacturer);
            this.Controls.Add(this.delete_manufacturer);
            this.Controls.Add(this.update_manufacturer);
            this.Controls.Add(this.add_manufacturer);
            this.Controls.Add(this.txt_manufacturer_name);
            this.Controls.Add(this.txt_manufacturer_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuanLyNhaSanXuat";
            this.Text = "FrmQuanLyNhaSanXuat";
            this.Load += new System.EventHandler(this.FrmQuanLyNhaSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manufacturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhaSanXuat;
        private System.Windows.Forms.Button delete_manufacturer;
        private System.Windows.Forms.Button update_manufacturer;
        private System.Windows.Forms.Button add_manufacturer;
        private System.Windows.Forms.TextBox txt_manufacturer_name;
        private System.Windows.Forms.TextBox txt_manufacturer_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}