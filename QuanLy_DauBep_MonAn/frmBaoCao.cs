using Qly_daubep_monan_nhahang;
using QuanLy_DauBep_MonAn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chitiet_thucdon
{
    public partial class frmBaoCao : Form
    {
        private string maDauBep = "";
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCombo();
            load_dgv();
        }

        private void load_dgv()
        {
            //mở kết nối
            try
            {
                DAO3.OpenConnection();

                string sql = @"SELECT ct.MaMonAn [Mã Món Ăn],TenMonAn [Tên Món Ăn],ct.MaDauBep [Mã Đầu Bếp],TenDauBep [Tên Đầu Bếp]
                FROM MonAn m 
                INNER JOIN ChiTietThucDon ct ON m.MaMonAn = ct.MaMonAn
                INNER JOIN DauBep d ON d.MaDauBep =ct.MaDauBep
                ORDER BY tenDaubep";
                SqlDataAdapter adap = new SqlDataAdapter(sql, DAO3.conn);
                DataTable ChiTietThucDon = new DataTable();
                adap.Fill(ChiTietThucDon);
                dgvChiTiet.DataSource = ChiTietThucDon;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO3.CloseConnection();
            }
        }
        private void load_dgv1()
        {
            maDauBep = cbDauBep.SelectedValue.ToString();
            if (maDauBep == "System.Data.DataRowView")
                return;

            //mở kết nối
            try
            {
                DAO3.OpenConnection();
                string sql = @"SELECT ct.MaMonAn [Mã Món Ăn],TenMonAn [Tên Món Ăn],ct.MaDauBep [Mã Đầu Bếp],TenDauBep [Tên Đầu Bếp]
                FROM MonAn m 
                INNER JOIN ChiTietThucDon ct ON m.MaMonAn = ct.MaMonAn
                INNER JOIN DauBep d ON d.MaDauBep =ct.MaDauBep
                WHERE ct.MaDauBep like'%" + maDauBep
                + "%' ORDER BY tenDaubep";
                SqlDataAdapter adap = new SqlDataAdapter(sql, DAO3.conn);
                DataTable ChiTietThucDon = new DataTable();
                adap.Fill(ChiTietThucDon);
                label1.Text = "Danh Sách Món Ăn Của Đầu Bếp " + ChiTietThucDon.Rows[0]["Tên Đầu Bếp"] + "";
                dgvChiTiet.DataSource = ChiTietThucDon;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO3.CloseConnection();
            }
        }
        private void LoadCombo()
        {
            string sql = "SELECT MaDauBep,TenDauBep FROM DauBep";
            DataTable data = DAO3.DocBang(sql);
            cbDauBep.DataSource = data;
            cbDauBep.DisplayMember = "TenDauBep";
            cbDauBep.ValueMember = "MaDauBep";

            // maDauBep = cbDauBep.SelectedValue.ToString();

        }
        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbDauBep_SelectedValueChanged(object sender, EventArgs e)
        { 
            load_dgv1();
        }
    }
}




