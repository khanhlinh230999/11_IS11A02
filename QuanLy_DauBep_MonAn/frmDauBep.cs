using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLy_DauBep_MonAn
{
    public partial class frmDauBep : Form
    {
        public frmDauBep()
        {
            InitializeComponent();
        }
        private void LoadDataToGridView()
        {
            try
            {
                DAO3.OpenConnection();
                string sql = "select * from DauBep";

                SqlDataAdapter adapt = new SqlDataAdapter(sql, DAO3.conn);
                DataTable tblDaubep = new DataTable();
                adapt.Fill(tblDaubep);
                dataGridViewDaubep.DataSource = tblDaubep;


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
        private void frmDauBep_Load(object sender, EventArgs e)
        {
            DAO3.OpenConnection();
            LoadDataToGridView();
            string sql = "Select * from TrinhDo";
            DAO3.FillDataToCombo(sql, cmbTrinhdo, "MaTrinhDo", "TenTrinhDo");
            sql = "Select * from NoiHoc";
            DAO3.FillDataToCombo(sql, cmbNoihoc, "MaNoiHoc", "TenNoiHoc");
            DAO3.CloseConnection();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMadaubep.Enabled = true;
            txtDiachi.Text = "";
            txtGioitinh.Text = "";
            txtMadaubep.Text = "";
            txtSodienthoai.Text = "";
            txtTendaubep.Text = "";
            cmbTrinhdo.SelectedIndex = -1;
            cmbNoihoc.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMadaubep.Text == "")
            {
                MessageBox.Show("Bạn không được để trống mã đầu bếp");
                txtMadaubep.Focus();
                return;
            }
            if (txtTendaubep.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tên đầu bếp");
                txtTendaubep.Focus();
                return;
            }
            if (cmbTrinhdo.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn trình độ");
                return;
            }
            if (cmbNoihoc.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn nơi học");
                return;
            }

            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn không được để trống đại chỉ");
                txtDiachi.Focus();
                return;
            }
            if (txtSodienthoai.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số điện thoại");
                txtSodienthoai.Focus();
                return;
            }
            if (txtGioitinh.Text == "")
            {
                MessageBox.Show("Bạn không được để trống giới tính");
                txtGioitinh.Focus();
                return;
            }
            //mã hàng k trùng
            string sql = "select * from DauBep where MaDauBep = '" +
                txtMadaubep.Text.Trim() + "'";
            DAO3.OpenConnection();
            if (DAO3.checkKeyExit(sql))
            {
                MessageBox.Show("Mã đầu bếp tồn tại");
                txtMadaubep.Focus();
                DAO3.CloseConnection();
                return;
            }
            else
            {
                sql = "insert into DauBep(MaDauBep,TenDauBep,DiaChi,GioiTinh, " +
                     "SDT,MaTrinhDo,MaNoiHoc)" +
                     "values ('" + txtMadaubep.Text.Trim() + "',N'"
                     + txtTendaubep.Text.Trim() + "', N'" + txtDiachi.Text.Trim() + "',N'"
                     + txtGioitinh.Text.Trim() + "'," + txtSodienthoai.Text.Trim() + ",'"
                     + cmbTrinhdo.SelectedValue.ToString() + "','" + cmbNoihoc.SelectedValue.ToString() +
                     "')";
                MessageBox.Show(sql);
                SqlCommand cmd = new SqlCommand(sql, DAO3.conn);
                cmd.ExecuteNonQuery();
                LoadDataToGridView();
                sql = "Select * from TrinhDo";
                DAO3.FillDataToCombo(sql, cmbTrinhdo, "MaTrinhDo", "TenTrinhDo");
                sql = "Select * from NoiHoc";
                DAO3.FillDataToCombo(sql, cmbNoihoc, "MaNoiHoc", "TenNoiHoc");
                DAO3.CloseConnection();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMadaubep.Enabled = false;
            string sql = "Update DauBep set TenDauBep = N'" +
                txtTendaubep.Text.Trim() + "', MaTrinhDo = '" +
                cmbTrinhdo.SelectedValue.ToString() + "', MaNoiHoc = '" +
                cmbNoihoc.SelectedValue.ToString() + "', DiaChi = N'" +
                txtDiachi.Text.Trim() + "', GioiTinh = N'" +
                txtGioitinh.Text.Trim() + "', SDT = " +
                txtSodienthoai.Text.Trim() +
                "where MaDauBep ='" + txtMadaubep.Text + "'";
            MessageBox.Show(sql);
            DAO3.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO3.conn;
            cmd.ExecuteNonQuery();
            LoadDataToGridView();
            DAO3.CloseConnection();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from DauBep where MaDauBep = '" +
                txtMadaubep.Text + "'";
            DAO3.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO3.conn;
            cmd.ExecuteNonQuery();
            DAO3.CloseConnection();
            LoadDataToGridView();
        }

        private void dataGridViewDaubep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "Select * from NoiHoc where MaNoiHoc = '" +
           dataGridViewDaubep.CurrentRow.Cells["MaNoiHoc"].Value.ToString() + "'";
            DAO3.FillDataToCombo(sql, cmbNoihoc, "MaNoiHoc", "TenNoiHoc");

            txtMadaubep.Text = dataGridViewDaubep.CurrentRow.Cells["MaDauBep"].Value.ToString();
            txtTendaubep.Text = dataGridViewDaubep.CurrentRow.Cells["TenDauBep"].Value.ToString();
            txtDiachi.Text = dataGridViewDaubep.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtGioitinh.Text = dataGridViewDaubep.CurrentRow.Cells["GioiTinh"].Value.ToString();
            txtDiachi.Text = dataGridViewDaubep.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtSodienthoai.Text = dataGridViewDaubep.CurrentRow.Cells["SDT"].Value.ToString();

            sql = "Select * from TrinhDo where MaTrinhDo = '" + dataGridViewDaubep.CurrentRow.Cells["MaTrinhDo"].Value.ToString() + "'";
            DAO3.FillDataToCombo(sql, cmbTrinhdo, "MaTrinhDo", "TenTrinhDo");
            txtMadaubep.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
