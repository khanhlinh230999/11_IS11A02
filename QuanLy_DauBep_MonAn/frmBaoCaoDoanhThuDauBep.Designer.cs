namespace QuanLy_DauBep_MonAn
{
    partial class frmBaoCaoDoanhThuDauBep
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
            this.btnBCTH = new System.Windows.Forms.Button();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDK = new System.Windows.Forms.ComboBox();
            this.cmbDaubep = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.cmbQuy = new System.Windows.Forms.ComboBox();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaydung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauBep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDoanhthu = new System.Windows.Forms.DataGridView();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBCTH
            // 
            this.btnBCTH.Location = new System.Drawing.Point(684, 113);
            this.btnBCTH.Name = "btnBCTH";
            this.btnBCTH.Size = new System.Drawing.Size(79, 41);
            this.btnBCTH.TabIndex = 28;
            this.btnBCTH.Text = "Báo cáo  tổng hợp";
            this.btnBCTH.UseVisualStyleBackColor = true;
            this.btnBCTH.Click += new System.EventHandler(this.btnBCTH_Click);
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(185, 424);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(341, 20);
            this.txtTongtien.TabIndex = 26;
            // 
            // btnLamlai
            // 
            this.btnLamlai.Location = new System.Drawing.Point(684, 79);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(79, 28);
            this.btnLamlai.TabIndex = 25;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Điều kiện";
            // 
            // cmbDK
            // 
            this.cmbDK.FormattingEnabled = true;
            this.cmbDK.Location = new System.Drawing.Point(494, 35);
            this.cmbDK.Name = "cmbDK";
            this.cmbDK.Size = new System.Drawing.Size(121, 26);
            this.cmbDK.TabIndex = 12;
            // 
            // cmbDaubep
            // 
            this.cmbDaubep.FormattingEnabled = true;
            this.cmbDaubep.Location = new System.Drawing.Point(108, 32);
            this.cmbDaubep.Name = "cmbDaubep";
            this.cmbDaubep.Size = new System.Drawing.Size(255, 26);
            this.cmbDaubep.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbDK);
            this.groupBox1.Controls.Add(this.cmbDaubep);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbThang);
            this.groupBox1.Controls.Add(this.cmbQuy);
            this.groupBox1.Controls.Add(this.cmbNam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 109);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiện chi tiết";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên đầu bếp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm";
            // 
            // cmbThang
            // 
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(108, 70);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(97, 26);
            this.cmbThang.TabIndex = 4;
            // 
            // cmbQuy
            // 
            this.cmbQuy.FormattingEnabled = true;
            this.cmbQuy.Location = new System.Drawing.Point(278, 70);
            this.cmbQuy.Name = "cmbQuy";
            this.cmbQuy.Size = new System.Drawing.Size(85, 26);
            this.cmbQuy.TabIndex = 5;
            // 
            // cmbNam
            // 
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(494, 70);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(121, 26);
            this.cmbNam.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tổng tiền thu được";
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(684, 41);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(79, 28);
            this.btnBaocao.TabIndex = 22;
            this.btnBaocao.Text = "Báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(532, 424);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(69, 22);
            this.btnXem.TabIndex = 27;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(702, 413);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(57, 41);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(633, 415);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(63, 40);
            this.btnIn.TabIndex = 20;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "GiaTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Tên món ăn";
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.Width = 150;
            // 
            // Ngaydung
            // 
            this.Ngaydung.DataPropertyName = "NgayDung";
            this.Ngaydung.HeaderText = "Ngày dùng";
            this.Ngaydung.Name = "Ngaydung";
            // 
            // TenDauBep
            // 
            this.TenDauBep.DataPropertyName = "TenDauBep";
            this.TenDauBep.HeaderText = "Tên đầu bếp";
            this.TenDauBep.Name = "TenDauBep";
            this.TenDauBep.Width = 150;
            // 
            // dataGridViewDoanhthu
            // 
            this.dataGridViewDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoanhthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDauBep,
            this.Ngaydung,
            this.TenMonAn,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.dataGridViewDoanhthu.Location = new System.Drawing.Point(41, 173);
            this.dataGridViewDoanhthu.Name = "dataGridViewDoanhthu";
            this.dataGridViewDoanhthu.Size = new System.Drawing.Size(718, 230);
            this.dataGridViewDoanhthu.TabIndex = 19;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Báo Cáo Doanh Thu Đầu Bếp";
            // 
            // frmBaoCaoDoanhThuDauBep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBCTH);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.dataGridViewDoanhthu);
            this.Name = "frmBaoCaoDoanhThuDauBep";
            this.Text = "Báo Cáo Doanh Thu Đầu Bếp";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThuDauBep_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBCTH;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDK;
        private System.Windows.Forms.ComboBox cmbDaubep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.ComboBox cmbQuy;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaydung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauBep;
        private System.Windows.Forms.DataGridView dataGridViewDoanhthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label label1;
    }
}