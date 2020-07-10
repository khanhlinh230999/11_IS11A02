namespace QuanLy_DauBep_MonAn
{
    partial class frmNguyenLieu
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridViewNguyenLieu = new System.Windows.Forms.DataGridView();
            this.txtDinhDuong = new System.Windows.Forms.TextBox();
            this.txtYeuCau = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMaNguyenLieu = new System.Windows.Forms.TextBox();
            this.txtTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.cboMaDonViTinh = new System.Windows.Forms.ComboBox();
            this.cboMaCongDung = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YeuCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DinhDuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(662, 18);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 85;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(235, 229);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 83;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(337, 229);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 84;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(130, 229);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 82;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(28, 229);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 81;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridViewNguyenLieu
            // 
            this.dataGridViewNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNguyenLieu,
            this.TenNguyenLieu,
            this.MaDonViTinh,
            this.MaCongDung,
            this.YeuCau,
            this.DonGia,
            this.DinhDuong});
            this.dataGridViewNguyenLieu.Location = new System.Drawing.Point(28, 283);
            this.dataGridViewNguyenLieu.Name = "dataGridViewNguyenLieu";
            this.dataGridViewNguyenLieu.Size = new System.Drawing.Size(745, 150);
            this.dataGridViewNguyenLieu.TabIndex = 80;
            this.dataGridViewNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNguyenLieu_CellClick);
            // 
            // txtDinhDuong
            // 
            this.txtDinhDuong.Location = new System.Drawing.Point(480, 169);
            this.txtDinhDuong.Multiline = true;
            this.txtDinhDuong.Name = "txtDinhDuong";
            this.txtDinhDuong.Size = new System.Drawing.Size(257, 89);
            this.txtDinhDuong.TabIndex = 79;
            // 
            // txtYeuCau
            // 
            this.txtYeuCau.Location = new System.Drawing.Point(480, 72);
            this.txtYeuCau.Multiline = true;
            this.txtYeuCau.Name = "txtYeuCau";
            this.txtYeuCau.Size = new System.Drawing.Size(257, 40);
            this.txtYeuCau.TabIndex = 78;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(480, 131);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(257, 20);
            this.txtDonGia.TabIndex = 77;
            // 
            // txtMaNguyenLieu
            // 
            this.txtMaNguyenLieu.Location = new System.Drawing.Point(149, 72);
            this.txtMaNguyenLieu.Name = "txtMaNguyenLieu";
            this.txtMaNguyenLieu.Size = new System.Drawing.Size(216, 20);
            this.txtMaNguyenLieu.TabIndex = 76;
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(149, 103);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(216, 20);
            this.txtTenNguyenLieu.TabIndex = 75;
            // 
            // cboMaDonViTinh
            // 
            this.cboMaDonViTinh.FormattingEnabled = true;
            this.cboMaDonViTinh.Location = new System.Drawing.Point(149, 138);
            this.cboMaDonViTinh.Name = "cboMaDonViTinh";
            this.cboMaDonViTinh.Size = new System.Drawing.Size(216, 21);
            this.cboMaDonViTinh.TabIndex = 74;
            // 
            // cboMaCongDung
            // 
            this.cboMaCongDung.FormattingEnabled = true;
            this.cboMaCongDung.Location = new System.Drawing.Point(149, 169);
            this.cboMaCongDung.Name = "cboMaCongDung";
            this.cboMaCongDung.Size = new System.Drawing.Size(216, 21);
            this.cboMaCongDung.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Yêu Cầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Dinh Dưỡng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Đơn Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Mã Công Dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Mã Đơn Vị Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Tên Nguyên Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Mã Nguyên Liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Nguyên Liệu";
            // 
            // MaNguyenLieu
            // 
            this.MaNguyenLieu.DataPropertyName = "MaNguyenLieu";
            this.MaNguyenLieu.HeaderText = "Mã Nguyên Liệu";
            this.MaNguyenLieu.Name = "MaNguyenLieu";
            // 
            // TenNguyenLieu
            // 
            this.TenNguyenLieu.DataPropertyName = "TenNguyenLieu";
            this.TenNguyenLieu.HeaderText = "Tên Nguyên Liệu";
            this.TenNguyenLieu.Name = "TenNguyenLieu";
            // 
            // MaDonViTinh
            // 
            this.MaDonViTinh.DataPropertyName = "MADonViTinh";
            this.MaDonViTinh.HeaderText = "Mã Đơn Vị Tính";
            this.MaDonViTinh.Name = "MaDonViTinh";
            // 
            // MaCongDung
            // 
            this.MaCongDung.DataPropertyName = "MaCongDung";
            this.MaCongDung.HeaderText = "Mã Công Dụng";
            this.MaCongDung.Name = "MaCongDung";
            // 
            // YeuCau
            // 
            this.YeuCau.DataPropertyName = "YeuCau";
            this.YeuCau.HeaderText = "Yêu Cầu";
            this.YeuCau.Name = "YeuCau";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // DinhDuong
            // 
            this.DinhDuong.DataPropertyName = "DinhDuong";
            this.DinhDuong.HeaderText = "Dinh Dưỡng";
            this.DinhDuong.Name = "DinhDuong";
            this.DinhDuong.Width = 200;
            // 
            // frmNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewNguyenLieu);
            this.Controls.Add(this.txtDinhDuong);
            this.Controls.Add(this.txtYeuCau);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtMaNguyenLieu);
            this.Controls.Add(this.txtTenNguyenLieu);
            this.Controls.Add(this.cboMaDonViTinh);
            this.Controls.Add(this.cboMaCongDung);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNguyenLieu";
            this.Text = "frmNguyenLieu";
            this.Load += new System.EventHandler(this.frmNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguyenLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewNguyenLieu;
        private System.Windows.Forms.TextBox txtDinhDuong;
        private System.Windows.Forms.TextBox txtYeuCau;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMaNguyenLieu;
        private System.Windows.Forms.TextBox txtTenNguyenLieu;
        private System.Windows.Forms.ComboBox cboMaDonViTinh;
        private System.Windows.Forms.ComboBox cboMaCongDung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn YeuCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DinhDuong;
    }
}