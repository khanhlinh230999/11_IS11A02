namespace QuanLy_DauBep_MonAn
{
    partial class frmMonAn
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
            this.btnTimKiemDauBep = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridViewMonAn = new System.Windows.Forms.DataGridView();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YeuCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCachLam = new System.Windows.Forms.TextBox();
            this.txtYeuCau = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.cboMaLoai = new System.Windows.Forms.ComboBox();
            this.cboMaCongDung = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiemMonAn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiemDauBep
            // 
            this.btnTimKiemDauBep.Location = new System.Drawing.Point(506, 18);
            this.btnTimKiemDauBep.Name = "btnTimKiemDauBep";
            this.btnTimKiemDauBep.Size = new System.Drawing.Size(128, 23);
            this.btnTimKiemDauBep.TabIndex = 64;
            this.btnTimKiemDauBep.Text = "Tìm kiếm đầu bếp";
            this.btnTimKiemDauBep.UseVisualStyleBackColor = true;
            this.btnTimKiemDauBep.Click += new System.EventHandler(this.btnTimKiemDauBep_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(662, 18);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 63;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(235, 229);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 61;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(337, 229);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 62;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(130, 229);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 60;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(28, 229);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 59;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridViewMonAn
            // 
            this.dataGridViewMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonAn,
            this.TenMonAn,
            this.MaLoai,
            this.MaCongDung,
            this.DonGia,
            this.YeuCau,
            this.CachLam});
            this.dataGridViewMonAn.Location = new System.Drawing.Point(28, 283);
            this.dataGridViewMonAn.Name = "dataGridViewMonAn";
            this.dataGridViewMonAn.Size = new System.Drawing.Size(745, 150);
            this.dataGridViewMonAn.TabIndex = 58;
            this.dataGridViewMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMonAn_CellClick);
            // 
            // MaMonAn
            // 
            this.MaMonAn.DataPropertyName = "MaMonAn";
            this.MaMonAn.HeaderText = "Mã Món Ăn";
            this.MaMonAn.Name = "MaMonAn";
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Tên Món Ăn";
            this.TenMonAn.Name = "TenMonAn";
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.Name = "MaLoai";
            // 
            // MaCongDung
            // 
            this.MaCongDung.DataPropertyName = "MaCongDung";
            this.MaCongDung.HeaderText = "Mã Công Dụng";
            this.MaCongDung.Name = "MaCongDung";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // YeuCau
            // 
            this.YeuCau.DataPropertyName = "YeuCau";
            this.YeuCau.HeaderText = "Yêu Cầu";
            this.YeuCau.Name = "YeuCau";
            // 
            // CachLam
            // 
            this.CachLam.DataPropertyName = "CachLam";
            this.CachLam.HeaderText = "Cách Làm";
            this.CachLam.Name = "CachLam";
            this.CachLam.Width = 200;
            // 
            // txtCachLam
            // 
            this.txtCachLam.Location = new System.Drawing.Point(480, 169);
            this.txtCachLam.Multiline = true;
            this.txtCachLam.Name = "txtCachLam";
            this.txtCachLam.Size = new System.Drawing.Size(257, 89);
            this.txtCachLam.TabIndex = 57;
            // 
            // txtYeuCau
            // 
            this.txtYeuCau.Location = new System.Drawing.Point(480, 111);
            this.txtYeuCau.Multiline = true;
            this.txtYeuCau.Name = "txtYeuCau";
            this.txtYeuCau.Size = new System.Drawing.Size(257, 40);
            this.txtYeuCau.TabIndex = 56;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(480, 72);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(257, 20);
            this.txtDonGia.TabIndex = 55;
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Location = new System.Drawing.Point(149, 72);
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.Size = new System.Drawing.Size(216, 20);
            this.txtMaMonAn.TabIndex = 54;
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(149, 103);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(216, 20);
            this.txtTenMonAn.TabIndex = 53;
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.Location = new System.Drawing.Point(149, 138);
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(216, 21);
            this.cboMaLoai.TabIndex = 52;
            // 
            // cboMaCongDung
            // 
            this.cboMaCongDung.FormattingEnabled = true;
            this.cboMaCongDung.Location = new System.Drawing.Point(149, 169);
            this.cboMaCongDung.Name = "cboMaCongDung";
            this.cboMaCongDung.Size = new System.Drawing.Size(216, 21);
            this.cboMaCongDung.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Yêu Cầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Cách Làm ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Đơn Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Mã Công Dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Mã Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tên Món Ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Mã Món Ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "Món Ăn";
            // 
            // btnTimKiemMonAn
            // 
            this.btnTimKiemMonAn.Location = new System.Drawing.Point(354, 18);
            this.btnTimKiemMonAn.Name = "btnTimKiemMonAn";
            this.btnTimKiemMonAn.Size = new System.Drawing.Size(124, 23);
            this.btnTimKiemMonAn.TabIndex = 65;
            this.btnTimKiemMonAn.Text = "Tìm kiếm món ăn";
            this.btnTimKiemMonAn.UseVisualStyleBackColor = true;
            this.btnTimKiemMonAn.Click += new System.EventHandler(this.btnTimKiemMonAn_Click);
            // 
            // frmMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btnTimKiemMonAn);
            this.Controls.Add(this.btnTimKiemDauBep);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewMonAn);
            this.Controls.Add(this.txtCachLam);
            this.Controls.Add(this.txtYeuCau);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtMaMonAn);
            this.Controls.Add(this.txtTenMonAn);
            this.Controls.Add(this.cboMaLoai);
            this.Controls.Add(this.cboMaCongDung);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMonAn";
            this.Text = "Quản lý món ăn";
            this.Load += new System.EventHandler(this.frmMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiemDauBep;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn YeuCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachLam;
        private System.Windows.Forms.TextBox txtCachLam;
        private System.Windows.Forms.TextBox txtYeuCau;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.ComboBox cboMaLoai;
        private System.Windows.Forms.ComboBox cboMaCongDung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiemMonAn;
    }
}