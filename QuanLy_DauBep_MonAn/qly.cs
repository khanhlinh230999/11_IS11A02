using chitiet_thucdon;
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

namespace Qly_daubep_monan_nhahang
{
    public partial class qly : Form
    {
        public qly()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            load_dgv();
            Reset();
            loadCobox();
        }
        private void loadCobox()
        {
            string sql = "Select makhachhang,tenkhachhang from khachhang";
            txtMaKhachHang.DataSource = DAO3.DocBang(sql);
            txtMaKhachHang.DisplayMember = "tenkhachhang";
            txtMaKhachHang.ValueMember = "makhachhang";
        }
        private void Reset()
        {
            txtSoThucDon.Text = "";
            txtThueVAT.Text = "";
            txtGiamGia.Text = "";
            txtTongTien.Text = "";
            txtSoThucDon.ReadOnly = true;
        }
        private void load_dgv()
        {
            //mở kết nối
            try
            {
                DAO3.OpenConnection();
                string sql = @"select [Số thực đơn] = SoThucDon,[Tên khách hàng] = TenKhachHang,[Ngày Dùng] = Ngaydung,[Thuế VAT] = ThueVAT,[Giảm giá] = GiamGia,[Tổng iền] = TongTien
                from ThucDon td inner
                join KhachHang kh on td.MaKhachHang = kh.MaKhachHang";
                SqlDataAdapter adap = new SqlDataAdapter(sql, DAO3.conn);
                DataTable ThucDon = new DataTable();
                adap.Fill(ThucDon);
                dgvThucDon.DataSource = ThucDon;
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
        private void dgvThucDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoThucDon.Text = dgvThucDon.CurrentRow.Cells[0].Value.ToString();
            txtMaKhachHang.Text = dgvThucDon.CurrentRow.Cells[1].Value.ToString();
            dteNgayDung.Text = dgvThucDon.CurrentRow.Cells[2].Value.ToString();
            txtThueVAT.Text = dgvThucDon.CurrentRow.Cells[3].Value.ToString();
            txtGiamGia.Text = dgvThucDon.CurrentRow.Cells[4].Value.ToString();
            txtTongTien.Text = dgvThucDon.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Reset();
            txtSoThucDon.ReadOnly = false;
            txtSoThucDon.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSoThucDon.Text == "" || txtMaKhachHang.SelectedValue == "" || dteNgayDung.Text == "" || txtThueVAT.Text == "" || txtGiamGia.Text == "" || txtTongTien.Text == "")
            {
                MessageBox.Show("Chưa đủ thông tin");
                return;
            }
            if (DAO3.checkKeyExit("select *from ThucDon where SoThucDon=N'" + txtSoThucDon.Text + "'") == true)
            {
                MessageBox.Show("Dữ liệu đã tồn tại");
                return;
            }
            string sql = "INSERT INTO ThucDon VALUES (N'" + txtSoThucDon.Text + "',N'" + txtMaKhachHang.SelectedValue + "','" + dteNgayDung.Value + "'," + txtThueVAT.Text + "," + txtGiamGia.Text + "," + txtTongTien.Text + ")";
            DAO3.OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, DAO3.conn);
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
            String sql = "DELETE FROM ThucDon WHERE SoThucDon =RTRIM(LTRIM(N' " + txtSoThucDon.Text.Trim() + "'))";
            DAO3.OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, DAO3.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công !","Thông báo");
            DAO3.CloseConnection();
            load_dgv();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoThucDon.Text == "" || txtMaKhachHang.SelectedValue == "" || dteNgayDung.Text == "" || txtThueVAT.Text == "" || txtGiamGia.Text == "" || txtTongTien.Text == "")
            {
                MessageBox.Show("Chưa đủ thông tin");
                return;
            }
            string sql = "UPDATE ThucDon SET MaKhachHang=N'" + txtMaKhachHang.SelectedValue + "',NgayDung='" + dteNgayDung.Value + "',ThueVAT=" + txtThueVAT.Text + ",GiamGia=" + txtGiamGia.Text + ",TongTien=" + txtTongTien.Text + " where SoThucDon=N'" + txtSoThucDon.Text + "'";
            DAO3.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO3.conn;
            cmd.ExecuteNonQuery();
            DAO3.CloseConnection();
            load_dgv();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            chitiet frm = new chitiet();
            frm.ShowDialog();
        }
    }
}



