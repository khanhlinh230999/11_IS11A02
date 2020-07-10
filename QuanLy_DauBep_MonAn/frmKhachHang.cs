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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DAO3.OpenConnection();
            LoadDataToGriview();
            DAO3.CloseConnection();
        }
        private void LoadDataToGriview()
        {
            // mở kết nối
            try
            {
                DAO3.OpenConnection();
                string sql = "select * from KhachHang";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO3.conn);
                DataTable KhachHang = new DataTable();
                myAdapter.Fill(KhachHang);
                GridViewKhachHang.DataSource = KhachHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally //dù có kết nối đk hay ko thì cũng ngăt kết nối
            {
                DAO3.CloseConnection();
            }
        }

        private void GridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhachHang.Text = GridViewKhachHang.CurrentRow.Cells["MaKhachHang"].Value.ToString();//Lấy dòng hiện tại
            txtTenKhachHang.Text = GridViewKhachHang.CurrentRow.Cells["TenKhachHang"].Value.ToString();
            txtDiaChi.Text = GridViewKhachHang.CurrentRow.Cells["Diachi"].Value.ToString();
            txtSDT.Text = GridViewKhachHang.CurrentRow.Cells["SDT"].Value.ToString();
            txtMaSoThue.Text = GridViewKhachHang.CurrentRow.Cells["MaSoThue"].Value.ToString();

            txtMaKhachHang.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaKhachHang.Enabled = true;
            txtTenKhachHang.Enabled = true;
            txtSDT.Enabled = true;
            txtMaSoThue.Enabled = true;
            txtDiaChi.Enabled = true;

            //xóa dữ liệu trong texbox
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtSDT.Text = "";
            txtMaSoThue.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Sql = "update KhachHang set TenKhachHang = N'" + txtTenKhachHang.Text.Trim()
               + "' ,DiaChi = '" + txtDiaChi.Text.Trim() + "' ,SDT = '"
               + txtSDT.Text.Trim() + "' ,MaSoThue = '" + txtMaSoThue.Text.Trim() +
              "' where MaKhachHang = '" + txtMaKhachHang.Text + "'";
            DAO3.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Sql;
            cmd.Connection = DAO3.conn;
            cmd.ExecuteNonQuery();
            DAO3.CloseConnection();
            LoadDataToGriview();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
                return;
            }
            if (txtTenKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                txtTenKhachHang.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            string sqlcheckkey = "select * from KhachHang where MaKhachHang = '"
                + txtMaKhachHang.Text.Trim() + "'";
            DAO3.OpenConnection();
            if (DAO3.checkKeyExit(sqlcheckkey))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
                DAO3.CloseConnection();
                txtMaKhachHang.Focus();
                return;
            }
            else
            {

                string sql;
                sql = "SELECT MaKhachHang FROM KhachHang WHERE MaKhachHang = N'" + txtMaKhachHang.Text + "'";

                sql = "INSERT INTO KhachHang(MaKhachHang,TenKhachHang,DiaChi,SDT,MaSothue) " +
                   "VALUES(N'" + txtMaKhachHang.Text + "',N'" + txtTenKhachHang.Text + "',N'" + txtDiaChi.Text +
                   "',N'" + txtSDT.Text + "',N'" + txtMaSoThue.Text + "')";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO3.conn;
                cmd.ExecuteNonQuery();
                DAO3.CloseConnection();
                LoadDataToGriview();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from KhachHang where MaKhachHang ='" + txtMaKhachHang.Text + "'";
            SqlCommand cmd = new SqlCommand();
            DAO3.OpenConnection();
            cmd.CommandText = sql;
            cmd.Connection = DAO3.conn;
            cmd.ExecuteNonQuery();
            DAO3.CloseConnection();
            LoadDataToGriview();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
