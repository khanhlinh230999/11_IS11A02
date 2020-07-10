namespace QuanLy_DauBep_MonAn
{
    partial class frmBCThucDon
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
            this.btnDong = new System.Windows.Forms.Button();
            this.dataGridViewThucDon = new System.Windows.Forms.DataGridView();
            this.SoThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauBep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThueVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThongTinThucDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(550, 58);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(109, 34);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dataGridViewThucDon
            // 
            this.dataGridViewThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoThucDon,
            this.TenKhachHang,
            this.NgayDung,
            this.TenMonAn,
            this.MaLoai,
            this.TenDauBep,
            this.SoLuong,
            this.ThanhTien,
            this.ThueVAT,
            this.GiamGia,
            this.TongTien});
            this.dataGridViewThucDon.Location = new System.Drawing.Point(12, 134);
            this.dataGridViewThucDon.Name = "dataGridViewThucDon";
            this.dataGridViewThucDon.RowTemplate.Height = 24;
            this.dataGridViewThucDon.Size = new System.Drawing.Size(776, 186);
            this.dataGridViewThucDon.TabIndex = 6;
            // 
            // SoThucDon
            // 
            this.SoThucDon.DataPropertyName = "SoThucDon";
            this.SoThucDon.HeaderText = "Số thực đơn";
            this.SoThucDon.Name = "SoThucDon";
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Khách hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            // 
            // NgayDung
            // 
            this.NgayDung.DataPropertyName = "NgayDung";
            this.NgayDung.HeaderText = "Ngày dùng";
            this.NgayDung.Name = "NgayDung";
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Món Ăn";
            this.TenMonAn.Name = "TenMonAn";
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "TenLoai";
            this.MaLoai.HeaderText = "Loại món ăn";
            this.MaLoai.Name = "MaLoai";
            // 
            // TenDauBep
            // 
            this.TenDauBep.DataPropertyName = "TenDauBep";
            this.TenDauBep.HeaderText = "Đầu bếp";
            this.TenDauBep.Name = "TenDauBep";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // ThueVAT
            // 
            this.ThueVAT.DataPropertyName = "ThueVAT";
            this.ThueVAT.HeaderText = "Thuế VAT";
            this.ThueVAT.Name = "ThueVAT";
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "GiamGia";
            this.GiamGia.HeaderText = "Giảm giá";
            this.GiamGia.Name = "GiamGia";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(329, 58);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(106, 34);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThongTinThucDon
            // 
            this.btnThongTinThucDon.Location = new System.Drawing.Point(97, 58);
            this.btnThongTinThucDon.Name = "btnThongTinThucDon";
            this.btnThongTinThucDon.Size = new System.Drawing.Size(119, 34);
            this.btnThongTinThucDon.TabIndex = 4;
            this.btnThongTinThucDon.Text = "Thông tin thực đơn";
            this.btnThongTinThucDon.UseVisualStyleBackColor = true;
            this.btnThongTinThucDon.Click += new System.EventHandler(this.btnThongTinThucDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "BÁO CÁO THÔNG TIN THỰC ĐƠN";
            // 
            // frmBCThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dataGridViewThucDon);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThongTinThucDon);
            this.Name = "frmBCThucDon";
            this.Text = "Báo Cáo Thực Đơn";
            this.Load += new System.EventHandler(this.frmBCThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThucDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dataGridViewThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauBep;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThueVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThongTinThucDon;
        private System.Windows.Forms.Label label1;
    }
}