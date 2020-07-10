namespace chitiet_thucdon
{
    partial class frmBaoCao
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
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDauBep = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChiTiet.Location = new System.Drawing.Point(145, 79);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(527, 150);
            this.dgvChiTiet.TabIndex = 38;
            this.dgvChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Danh Sách Món Ăn Của Đầu Bếp ";
            // 
            // cbDauBep
            // 
            this.cbDauBep.FormattingEnabled = true;
            this.cbDauBep.Location = new System.Drawing.Point(18, 79);
            this.cbDauBep.Name = "cbDauBep";
            this.cbDauBep.Size = new System.Drawing.Size(121, 21);
            this.cbDauBep.TabIndex = 39;
            this.cbDauBep.SelectedValueChanged += new System.EventHandler(this.cbDauBep_SelectedValueChanged);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 246);
            this.Controls.Add(this.cbDauBep);
            this.Controls.Add(this.dgvChiTiet);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Món Ăn Của Đầu Bếp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDauBep;
    }
}

