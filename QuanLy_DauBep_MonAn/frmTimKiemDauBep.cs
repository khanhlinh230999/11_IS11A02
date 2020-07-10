using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLy_DauBep_MonAn
{
    public partial class frmTimKiemDauBep : Form
    {
        public frmTimKiemDauBep()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboDanhMuc.Text == "Tên Đầu Bếp")
            {
                dataGridViewTimKiemDB.DataSource = DAO3.DocBang("SELECT * FROM DauBep WHERE TenDauBep LIKE N'%" + txtNhapTuKhoa.Text.Trim() + "%'");
            }
            if (cboDanhMuc.Text == "Nơi Học")
            {
                dataGridViewTimKiemDB.DataSource = DAO3.DocBang("SELECT * FROM DauBep WHERE TenNoiHoc LIKE N'%" + txtNhapTuKhoa.Text.Trim() + "%'");
            }
            if (cboDanhMuc.Text == "Món Ăn")
            {
                dataGridViewTimKiemDB.DataSource = DAO3.DocBang("SELECT MaDauBep,MaMonAn FROM DauBep_MonAn WHERE MaMonAn LIKE N'%" + txtNhapTuKhoa.Text.Trim() + "%'");
            }
        }

        private void frmTimKiemDauBep_Load(object sender, EventArgs e)
        {
            cboDanhMuc.Text = "Tên Đầu Bếp";
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
