using Qly_daubep_monan_nhahang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_DauBep_MonAn
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void đầuBếpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mónĂnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMonAn f1 = new frmMonAn();
            f1.Show();
        }

        private void nguyênLiệuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmNguyenLieu f1 = new frmNguyenLieu();
            f1.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f1 = new frmKhachHang();
            f1.Show();
        }

        private void báoCáoMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCMonAn f1 = new frmBCMonAn();
            f1.Show();
        }

        private void báoCáoThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCThucDon f1 = new frmBCThucDon();
            f1.Show();
        }

        private void chiTiếtThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thựcĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void báoCáoDoanhThuĐầuBếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhThuDauBep f1 = new frmBaoCaoDoanhThuDauBep();
            f1.Show();
        }

        private void đầuBếpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDauBep f1 = new frmDauBep();
            f1.Show();
        }

        private void thựcĐơnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            qly frm = new qly();
            frm.ShowDialog();
        }
    }
}
