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
    public partial class frmNguyenLieu : Form
    {
        public frmNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            DAO3.OpenConnection();
            LoadDataToGridView();
            FillDataToCombo();
            DAO3.CloseConnection();
        }
        private void LoadDataToGridView()
        {
            string sql = "Select * from NguyenLieu";
            SqlDataAdapter adap = new SqlDataAdapter(sql, DAO3.conn);
            DataTable table = new DataTable();
            adap.Fill(table);
            dataGridViewNguyenLieu.DataSource = table;
        }
        public void FillDataToCombo()
        {
            string sql = "select MaDonViTinh,TenDonViTinh from Don_Vi_Tinh";
            DAO3.OpenConnection();
            DAO3.FillDataToCombo(sql, cboMaDonViTinh, "MaDonViTinh", "TenDonViTinh");

            sql = "select MaCongDung from Cong_dung";
            DAO3.FillDataToCombo(sql, cboMaCongDung, "MaCongDung", "MaCongDung");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNguyenLieu.Text = "";
            txtTenNguyenLieu.Text = "";
            txtYeuCau.Text = "";
            txtDonGia.Text = "";
            txtDinhDuong.Text = "";
            cboMaDonViTinh.SelectedIndex = -1;
            cboMaCongDung.SelectedIndex = -1;
            txtMaNguyenLieu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNguyenLieu.Text == "")
            {
                MessageBox.Show("Bạn không được để trống mã nguyên liệu");
                txtMaNguyenLieu.Focus();
                return;
            }
            if (txtTenNguyenLieu.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tên nguyên liệu");
                txtTenNguyenLieu.Focus();
                return;
            }
            if (cboMaDonViTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã đơn vị tính");
                return;
            }
            if (cboMaCongDung.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã công dụng");
                return;
            }
            string sql = "Select * from NguyenLieu where MaNguyenLieu ='"
                + txtMaNguyenLieu.Text.Trim() + "'";
            DAO3.OpenConnection();
            if (DAO3.checkKeyExit(sql))
            {
                MessageBox.Show("Mã nguyên liệu đã tồn tại!");
                DAO3.CloseConnection();
                txtMaNguyenLieu.Focus();
                return;
            }
            else
            {
                sql = "Insert into NguyenLieu values ('" + txtMaNguyenLieu.Text.Trim() + "',N'"
                    + txtTenNguyenLieu.Text.Trim() + "','" + cboMaDonViTinh.SelectedValue.ToString() + "','"
                    + cboMaCongDung.SelectedValue.ToString() + "','" + txtYeuCau.Text.Trim() + "',N'"
                    + txtDonGia.Text.Trim() + "',N'" + txtDinhDuong.Text.Trim() + "')";
                MessageBox.Show(sql);
                SqlCommand cmd = new SqlCommand(sql, DAO3.conn);
                cmd.ExecuteNonQuery();
                LoadDataToGridView();
                FillDataToCombo();
                DAO3.CloseConnection();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update NguyenLieu set TenNguyenLieu= N'" + txtTenNguyenLieu.Text.Trim() +
              "',MaDonViTinh='" + cboMaDonViTinh.SelectedValue.ToString() + "',MaCongDung='" + cboMaCongDung.SelectedValue.ToString() +
              "',YeuCau='" + txtYeuCau.Text.Trim() + "',DonGia='" + txtDonGia.Text.Trim() + "',DinhDuong='" + txtDinhDuong.Text.Trim() + "'" +
              " where MaNguyenLieu= '" + txtMaNguyenLieu.Text + "'";
            DAO3.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO3.conn;
            cmd.ExecuteNonQuery();
            DAO3.CloseConnection();
            LoadDataToGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from NguyenLieu where MaNguyenLieu = '" + txtMaNguyenLieu.Text + "'";
            SqlCommand cmd = new SqlCommand();
            DAO3.OpenConnection();
            cmd.CommandText = sql;
            cmd.Connection = DAO3.conn;
            cmd.ExecuteNonQuery();
            DAO3.CloseConnection();
            LoadDataToGridView();
        }

        private void dataGridViewNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNguyenLieu.Text = dataGridViewNguyenLieu.CurrentRow.Cells["MaNguyenLieu"].Value.ToString();
            txtTenNguyenLieu.Text = dataGridViewNguyenLieu.CurrentRow.Cells["TenNguyenLieu"].Value.ToString();     
            txtYeuCau.Text = dataGridViewNguyenLieu.CurrentRow.Cells["YeuCau"].Value.ToString();
            txtDonGia.Text = dataGridViewNguyenLieu.CurrentRow.Cells["DonGia"].Value.ToString();
            txtDinhDuong.Text = dataGridViewNguyenLieu.CurrentRow.Cells["DinhDuong"].Value.ToString();
            txtMaNguyenLieu.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
