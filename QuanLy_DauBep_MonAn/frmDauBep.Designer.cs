namespace QuanLy_DauBep_MonAn
{
    partial class frmDauBep
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
            this.components = new System.ComponentModel.Container();
            this.TenDauBep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.MaNoihoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.cmbNoihoc = new System.Windows.Forms.ComboBox();
            this.cmbTrinhdo = new System.Windows.Forms.ComboBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.txtTendaubep = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtMadaubep = new System.Windows.Forms.TextBox();
            this.dataGridViewDaubep = new System.Windows.Forms.DataGridView();
            this.MaDauBep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaubep)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TenDauBep
            // 
            this.TenDauBep.DataPropertyName = "TenDauBep";
            this.TenDauBep.HeaderText = "Tên đầu bếp";
            this.TenDauBep.Name = "TenDauBep";
            this.TenDauBep.Width = 130;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(496, 470);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // MaNoihoc
            // 
            this.MaNoihoc.DataPropertyName = "MaNoiHoc";
            this.MaNoihoc.HeaderText = "Nơi học";
            this.MaNoihoc.Name = "MaNoihoc";
            this.MaNoihoc.Width = 70;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 70;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 75;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // MaTrinhDo
            // 
            this.MaTrinhDo.DataPropertyName = "MaTrinhDo";
            this.MaTrinhDo.HeaderText = "Trình Độ";
            this.MaTrinhDo.Name = "MaTrinhDo";
            this.MaTrinhDo.Width = 75;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(353, 470);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(106, 111);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(209, 20);
            this.txtDiachi.TabIndex = 9;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(202, 470);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(43, 470);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Location = new System.Drawing.Point(421, 50);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(223, 20);
            this.txtGioitinh.TabIndex = 13;
            // 
            // cmbNoihoc
            // 
            this.cmbNoihoc.FormattingEnabled = true;
            this.cmbNoihoc.Location = new System.Drawing.Point(422, 77);
            this.cmbNoihoc.Name = "cmbNoihoc";
            this.cmbNoihoc.Size = new System.Drawing.Size(223, 21);
            this.cmbNoihoc.TabIndex = 12;
            // 
            // cmbTrinhdo
            // 
            this.cmbTrinhdo.FormattingEnabled = true;
            this.cmbTrinhdo.Location = new System.Drawing.Point(106, 77);
            this.cmbTrinhdo.Name = "cmbTrinhdo";
            this.cmbTrinhdo.Size = new System.Drawing.Size(209, 21);
            this.cmbTrinhdo.TabIndex = 11;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(423, 111);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(222, 20);
            this.txtSodienthoai.TabIndex = 10;
            // 
            // txtTendaubep
            // 
            this.txtTendaubep.Location = new System.Drawing.Point(106, 50);
            this.txtTendaubep.Name = "txtTendaubep";
            this.txtTendaubep.Size = new System.Drawing.Size(209, 20);
            this.txtTendaubep.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtMadaubep
            // 
            this.txtMadaubep.Location = new System.Drawing.Point(106, 19);
            this.txtMadaubep.Name = "txtMadaubep";
            this.txtMadaubep.Size = new System.Drawing.Size(209, 20);
            this.txtMadaubep.TabIndex = 7;
            // 
            // dataGridViewDaubep
            // 
            this.dataGridViewDaubep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaubep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauBep,
            this.TenDauBep,
            this.MaTrinhDo,
            this.MaNoihoc,
            this.DiaChi,
            this.GioiTinh,
            this.SDT});
            this.dataGridViewDaubep.Location = new System.Drawing.Point(6, 30);
            this.dataGridViewDaubep.Name = "dataGridViewDaubep";
            this.dataGridViewDaubep.Size = new System.Drawing.Size(651, 216);
            this.dataGridViewDaubep.TabIndex = 0;
            this.dataGridViewDaubep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaubep_CellClick);
            // 
            // MaDauBep
            // 
            this.MaDauBep.DataPropertyName = "MaDauBep";
            this.MaDauBep.HeaderText = "Mã đầu bếp";
            this.MaDauBep.Name = "MaDauBep";
            this.MaDauBep.Width = 90;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(625, 470);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 13;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDaubep);
            this.groupBox2.Location = new System.Drawing.Point(37, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 252);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Đầu bếp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nơi học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trình độ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đầu bếp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGioitinh);
            this.groupBox1.Controls.Add(this.cmbNoihoc);
            this.groupBox1.Controls.Add(this.cmbTrinhdo);
            this.groupBox1.Controls.Add(this.txtSodienthoai);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtTendaubep);
            this.groupBox1.Controls.Add(this.txtMadaubep);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 160);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Đầu bếp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đầu bếp";
            // 
            // frmDauBep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 511);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDauBep";
            this.Text = "Quản Lý Đầu Bếp";
            this.Load += new System.EventHandler(this.frmDauBep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaubep)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauBep;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNoihoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTrinhDo;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.ComboBox cmbNoihoc;
        private System.Windows.Forms.ComboBox cmbTrinhdo;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.TextBox txtTendaubep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtMadaubep;
        private System.Windows.Forms.DataGridView dataGridViewDaubep;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauBep;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}