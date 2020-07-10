namespace QuanLy_DauBep_MonAn
{
    partial class frmTimKiemDauBep
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataGridViewTimKiemDB = new System.Windows.Forms.DataGridView();
            this.MaDauBep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauBep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNoiHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapTuKhoa = new System.Windows.Forms.TextBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemDB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(403, 127);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(79, 29);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(403, 73);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(79, 30);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGridViewTimKiemDB
            // 
            this.dataGridViewTimKiemDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiemDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauBep,
            this.TenDauBep,
            this.MaTrinhDo,
            this.MaNoiHoc,
            this.DiaChi,
            this.GioiTinh,
            this.SDT});
            this.dataGridViewTimKiemDB.Location = new System.Drawing.Point(29, 208);
            this.dataGridViewTimKiemDB.Name = "dataGridViewTimKiemDB";
            this.dataGridViewTimKiemDB.Size = new System.Drawing.Size(543, 183);
            this.dataGridViewTimKiemDB.TabIndex = 27;
            // 
            // MaDauBep
            // 
            this.MaDauBep.DataPropertyName = "MaDauBep";
            this.MaDauBep.HeaderText = "Mã Đầu Bếp";
            this.MaDauBep.Name = "MaDauBep";
            // 
            // TenDauBep
            // 
            this.TenDauBep.DataPropertyName = "TenDauBep";
            this.TenDauBep.HeaderText = "Tên Đầu Bếp";
            this.TenDauBep.Name = "TenDauBep";
            // 
            // MaTrinhDo
            // 
            this.MaTrinhDo.DataPropertyName = "MaTrinhDo";
            this.MaTrinhDo.HeaderText = "Mã Trình Độ";
            this.MaTrinhDo.Name = "MaTrinhDo";
            // 
            // MaNoiHoc
            // 
            this.MaNoiHoc.DataPropertyName = "MaNoiHoc";
            this.MaNoiHoc.HeaderText = "Mã Nơi Học";
            this.MaNoiHoc.Name = "MaNoiHoc";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nhập từ khóa";
            // 
            // txtNhapTuKhoa
            // 
            this.txtNhapTuKhoa.Location = new System.Drawing.Point(201, 124);
            this.txtNhapTuKhoa.Name = "txtNhapTuKhoa";
            this.txtNhapTuKhoa.Size = new System.Drawing.Size(151, 20);
            this.txtNhapTuKhoa.TabIndex = 25;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Items.AddRange(new object[] {
            "Tên Đầu Bếp",
            "Nơi Học",
            "Món Ăn"});
            this.cboDanhMuc.Location = new System.Drawing.Point(201, 82);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(151, 21);
            this.cboDanhMuc.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh Mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tìm Kiếm Đầu Bếp";
            // 
            // frmTimKiemDauBep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dataGridViewTimKiemDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDanhMuc);
            this.Controls.Add(this.txtNhapTuKhoa);
            this.Controls.Add(this.label1);
            this.Name = "frmTimKiemDauBep";
            this.Text = "Tìm Kiếm Đầu Bếp";
            this.Load += new System.EventHandler(this.frmTimKiemDauBep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewTimKiemDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauBep;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauBep;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNoiHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapTuKhoa;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}