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
    public partial class chitiet : Form
    {
        public chitiet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_dgv();
            loadCobox();
        }
        private void loadCobox()
        {
            string sql = "select SoThucDon from ThucDon";
            txtSoThucDon.DataSource = DAO3.DocBang(sql);
            txtSoThucDon.DisplayMember = "SoThucDon";
            txtSoThucDon.ValueMember = "SoThucDon";
        }
        private void reset()
        {
            txtMaMonAn.Text = "";
            cbNgayDung.Text = "";
            txtMaLoai.Text = "";
            txtMaDauBep.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
        }
        private void load_dgv()
        {
            //mở kết nối
            try
            {
                DAO3.OpenConnection();
                string sql = "select * from ChiTietThucDon";
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
        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoThucDon.Text = dgvChiTiet.CurrentRow.Cells[0].Value.ToString();
            txtMaMonAn.Text = dgvChiTiet.CurrentRow.Cells[1].Value.ToString();
            cbNgayDung.Text = dgvChiTiet.CurrentRow.Cells[4].Value.ToString();
            txtMaLoai.Text = dgvChiTiet.CurrentRow.Cells[2].Value.ToString();
            txtMaDauBep.Text = dgvChiTiet.CurrentRow.Cells[3].Value.ToString();
            txtSoLuong.Text = dgvChiTiet.CurrentRow.Cells[5].Value.ToString();
            txtThanhTien.Text = dgvChiTiet.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            reset();
            txtSoThucDon.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSoThucDon.Text == "" || txtMaMonAn.Text == "" || cbNgayDung.Text == "" || txtMaLoai.Text == "" || txtMaDauBep.Text == "" || txtSoLuong.Text == "" || txtThanhTien.Text == "")
            {
                MessageBox.Show("Chưa đủ thông tin");
                return;
            }
            if (DAO3.checkKeyExit("select *from ChiTietThucDon where SoThucDon=N'" + txtSoThucDon.SelectedValue + "'") == true)
            {
                MessageBox.Show("Dữ liệu đã tồn tại");
                return;
            }
            string sql = "INSERT INTO ThucDon VALUES (N'" + txtSoThucDon.SelectedValue + "',N'" + txtMaMonAn.Text + "'," + cbNgayDung.SelectedValue + "," + txtMaLoai.Text + "," + txtMaDauBep.Text + "," + txtSoLuong.Text + "," + txtMaDauBep.Text + "," + txtThanhTien.Text + ")";
            DAO3.OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, DAO3.conn);
            cmd.ExecuteNonQuery();
            DAO3.CloseConnection();
            load_dgv();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoThucDon.SelectedValue == "" || txtMaMonAn.Text == "" || cbNgayDung.Text == "" || txtMaLoai.Text == "" || txtMaDauBep.Text == "" || txtSoLuong.Text == "" || txtThanhTien.Text == "")
            {
                MessageBox.Show("Chưa đủ thông tin");
                return;
            }
            string sql = "UPDATE ThucDon SET SoThucDon=N'" + txtSoThucDon.SelectedValue + "',MaMonAn=N'" + txtMaMonAn.Text + "',NgayDung=" + cbNgayDung.SelectedValue + ",MaLoai=" + txtMaLoai.Text + ",MaDauBep=" + txtMaDauBep.Text + ",SoLuong=" + txtSoLuong.Text + ",ThanhTien=" + txtThanhTien.Text + "";
            DAO3.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO3.conn;
            cmd.ExecuteNonQuery();
            DAO3.CloseConnection();
            load_dgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtSoThucDon.Text == "")
            {
                MessageBox.Show("Chưa chọn dòng cần xóa");
                return;
            }
            String sql = "DELETE FROM ChiTietThucDon WHERE SoThucDon =N' " + txtSoThucDon.SelectedValue + "'";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBaoCao frm = new frmBaoCao();
            frm.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            frmChiTietMonAn frm = new frmChiTietMonAn();
            frm.maMonAn = txtMaMonAn.Text;
            frm.ShowDialog();
        }
    }
}




