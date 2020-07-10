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
    public partial class frmMonAn : Form
    {
        public frmMonAn()
        {
            InitializeComponent();
        }

        private void frmMonAn_Load(object sender, EventArgs e)
        {
            DAO3.OpenConnection();
            LoadDataToGridView();
            FillDataToCombo();
            DAO3.CloseConnection();
        }
        private void LoadDataToGridView()
        {
            string sql = "Select * from MonAn";
            SqlDataAdapter adap = new SqlDataAdapter(sql, DAO3.conn);
            DataTable table = new DataTable();
            adap.Fill(table);
            dataGridViewMonAn.DataSource = table;
            
        }
        public void FillDataToCombo()
        {
            string sql = "select MaLoai from Loai_Mon_An";
            DAO3.OpenConnection();
            DAO3.FillDataToCombo(sql, cboMaLoai, "MaLoai", "MaLoai");

            sql = "select MaCongDung from Cong_dung";
            DAO3.FillDataToCombo(sql, cboMaCongDung, "MaCongDung", "MaCongDung");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaMonAn.Text = "";
            txtTenMonAn.Text = "";
            txtDonGia.Text = "";
            txtYeuCau.Text = "";
            txtCachLam.Text = "";
            cboMaLoai.SelectedIndex = -1;
            cboMaCongDung.SelectedIndex = -1;
            txtMaMonAn.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaMonAn.Text == "")
            {
                MessageBox.Show("Bạn không được để trống mã món ăn");
                txtMaMonAn.Focus();
                return;
            }
            if (txtTenMonAn.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tên món ăn");
                txtTenMonAn.Focus();
                return;
            }
            if (cboMaLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã loại");
                return;
            }
            if (cboMaCongDung.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã công dụng");
                return;
            }
            string sql = "Select * from MonAn where MaMonAn ='"
                + txtMaMonAn.Text.Trim() + "'";
            DAO3.OpenConnection();
            if (DAO3.checkKeyExit(sql))
            {
                MessageBox.Show("Mã món ăn đã tồn tại!");
                DAO3.CloseConnection();
                txtMaMonAn.Focus();
                return;
            }
            else
            {
                sql = "Insert into MonAn values ('" + txtMaMonAn.Text.Trim() + "',N'"
                    + txtTenMonAn.Text.Trim() + "','" + cboMaLoai.SelectedValue.ToString() + "','"
                    + cboMaCongDung.SelectedValue.ToString() + "','" + txtDonGia.Text.Trim() + "',N'"
                    + txtYeuCau.Text.Trim() + "',N'" + txtCachLam.Text.Trim() + "')";
                MessageBox.Show(sql);
                SqlCommand cmd = new SqlCommand(sql, DAO3.conn);
                cmd.ExecuteNonQuery();
                LoadDataToGridView();
                FillDataToCombo();
                DAO3.CloseConnection();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update MonAn set TenMonAn= N'" + txtTenMonAn.Text.Trim() +
               "',MaLoai='" + cboMaLoai.SelectedValue.ToString() + "',MaCongDung='" + cboMaCongDung.SelectedValue.ToString() +
               "',DonGia='" + txtDonGia.Text.Trim() + "',YeuCau='" + txtYeuCau.Text.Trim() + "',CachLam='" + txtCachLam.Text.Trim() + "'" +
               " where MaMonAn= '" + txtMaMonAn.Text + "'";
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
            string sql = "Delete from MonAn where MaMonAn = '" + txtMaMonAn.Text + "'";
            SqlCommand cmd = new SqlCommand();
            DAO3.OpenConnection();
            cmd.CommandText = sql;
            cmd.Connection = DAO3.conn;
            cmd.ExecuteNonQuery();
            DAO3.CloseConnection();
            LoadDataToGridView();
        }

        private void dataGridViewMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaMonAn.Text = dataGridViewMonAn.CurrentRow.Cells["MaMonAn"].Value.ToString();
            txtTenMonAn.Text = dataGridViewMonAn.CurrentRow.Cells["TenMonAn"].Value.ToString();
            txtDonGia.Text = dataGridViewMonAn.CurrentRow.Cells["DonGia"].Value.ToString();
            txtYeuCau.Text = dataGridViewMonAn.CurrentRow.Cells["YeuCau"].Value.ToString();
            txtCachLam.Text = dataGridViewMonAn.CurrentRow.Cells["CachLam"].Value.ToString();
            txtMaMonAn.Enabled = false;
        }

        private void btnTimKiemDauBep_Click(object sender, EventArgs e)
        {
            frmTimKiemDauBep f1 = new frmTimKiemDauBep();
            f1.Show();
        }

        private void btnTimKiemMonAn_Click(object sender, EventArgs e)
        {
            string sql;
            DataTable tblMonAn;
            if ((cboMaLoai.Text == "") && (txtTenMonAn.Text == "") && (cboMaCongDung.Text == ""))

            {
                MessageBox.Show(" Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            sql = " SELECT * FROM MonAn WHERE 1 = 1";
            if (txtTenMonAn.Text != "")
                sql = sql + "AND TenMonAn Like N'%" + txtTenMonAn.Text + "%'";
            if (cboMaLoai.Text != "")
                sql = sql + "AND MaLoai Like N'%" + cboMaLoai.SelectedValue + "%'";
            if (cboMaCongDung.Text != "")
                sql = sql + "AND MaCongDung Like N'%" + cboMaCongDung.SelectedValue + "%'";
            tblMonAn = DAO3.DocBang(sql);
            if (tblMonAn.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
                MessageBox.Show("Có " + tblMonAn.Rows.Count + "bản ghi thỏa mãn điều kiện!!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dataGridViewMonAn.DataSource = tblMonAn;
            txtMaMonAn.Text = "";
            txtTenMonAn.Text = "";
            txtDonGia.Text = "";
            txtYeuCau.Text = "";
            txtCachLam.Text = "";
            cboMaCongDung.Text = "";
            cboMaLoai.Text = "";

        }
    }
}
