namespace QuanLy_DauBep_MonAn
{
    partial class frmBCMonAn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YeuCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThongTinMonAn = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonAn,
            this.TenMonAn,
            this.TenLoai,
            this.TenCongDung,
            this.DonGia,
            this.YeuCau,
            this.CachLam});
            this.dataGridView1.Location = new System.Drawing.Point(6, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 240);
            this.dataGridView1.TabIndex = 6;
            // 
            // MaMonAn
            // 
            this.MaMonAn.DataPropertyName = "MaMonAn";
            this.MaMonAn.HeaderText = "Mã món ăn";
            this.MaMonAn.Name = "MaMonAn";
            this.MaMonAn.Width = 130;
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Tên món ăn";
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.Width = 200;
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Tên loại";
            this.TenLoai.Name = "TenLoai";
            // 
            // TenCongDung
            // 
            this.TenCongDung.DataPropertyName = "TenCongDung";
            this.TenCongDung.HeaderText = "Công dụng";
            this.TenCongDung.Name = "TenCongDung";
            this.TenCongDung.Width = 140;
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
            this.YeuCau.HeaderText = "Yêu cầu";
            this.YeuCau.Name = "YeuCau";
            // 
            // CachLam
            // 
            this.CachLam.DataPropertyName = "CachLam";
            this.CachLam.HeaderText = "Cách làm";
            this.CachLam.Name = "CachLam";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(320, 70);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(108, 35);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThongTinMonAn
            // 
            this.btnThongTinMonAn.Location = new System.Drawing.Point(126, 70);
            this.btnThongTinMonAn.Name = "btnThongTinMonAn";
            this.btnThongTinMonAn.Size = new System.Drawing.Size(120, 34);
            this.btnThongTinMonAn.TabIndex = 4;
            this.btnThongTinMonAn.Text = "Thông Tin Món Ăn";
            this.btnThongTinMonAn.UseVisualStyleBackColor = true;
            this.btnThongTinMonAn.Click += new System.EventHandler(this.btnThongTinMonAn_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(497, 72);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(106, 34);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Báo Cáo Thông Tin Món Ăn";
            // 
            // frmBCMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThongTinMonAn);
            this.Controls.Add(this.btnDong);
            this.Name = "frmBCMonAn";
            this.Text = "Báo Cáo Món Ăn";
            this.Load += new System.EventHandler(this.frmBCMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn YeuCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachLam;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThongTinMonAn;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label1;
    }
}