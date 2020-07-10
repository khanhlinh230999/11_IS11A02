using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;



namespace QuanLy_DauBep_MonAn
{
    public partial class frmBaoCaoDoanhThuDauBep : Form
    {
        public frmBaoCaoDoanhThuDauBep()
        {
            InitializeComponent();
        }
        private void LoadDataToGridView()
        {
            try
            {
                DAO3.OpenConnection();
                string sql = "select c.TenDauBep,b.TenMonAn,a.Ngaydung, a.SoLuong, b.DonGia, a.SoLuong * b.DonGia " +
  " as GiaTien from ChiTietThucDon a join MonAn b on a.MaMonAn = b.MaMonAn join DauBep c on a.MaDauBep = c.MaDauBep ";
                SqlDataAdapter adapt = new SqlDataAdapter(sql, DAO3.conn);
                DataTable table = new DataTable();
                adapt.Fill(table);
                dataGridViewDoanhthu.DataSource = table;


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
        private void frmBaoCaoDoanhThuDauBep_Load(object sender, EventArgs e)
        {
            DAO3.OpenConnection();
            LoadDataToGridView();
            string sql = "Select * from DauBep";
            DAO3.FillDataToCombo(sql, cmbDaubep, "MaDauBep", "TenDauBep");
            DAO3.CloseConnection();
            cmbDK.Items.Add("Tháng");
            cmbDK.Items.Add("Quý");
            cmbDK.Items.Add("Năm");
            cmbThang.Items.Add("1");
            cmbThang.Items.Add("2");
            cmbThang.Items.Add("3");
            cmbThang.Items.Add("4");
            cmbThang.Items.Add("5");
            cmbThang.Items.Add("6");
            cmbThang.Items.Add("7");
            cmbThang.Items.Add("8");
            cmbThang.Items.Add("9");
            cmbThang.Items.Add("10");
            cmbThang.Items.Add("11");
            cmbThang.Items.Add("12");
            cmbQuy.Items.Add("1");
            cmbQuy.Items.Add("2");
            cmbQuy.Items.Add("3");
            cmbQuy.Items.Add("4");
            cmbNam.Items.Add("2019");
            cmbNam.Items.Add("2020");

        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            cmbDaubep.SelectedIndex = -1;
            cmbDK.SelectedIndex = -1;
            cmbNam.SelectedIndex = -1;
            cmbQuy.SelectedIndex = -1;
            cmbThang.SelectedIndex = -1;
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            if (cmbDaubep.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải chọn Tên đầu bếp!");
            }
            if (cmbDK.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải chọn điều kiện!");
            }
            if (cmbDK.Text.Trim() == "Tháng")
            {
                if (cmbNam.Text.Trim() == "")
                {
                    MessageBox.Show("Nhập điều kiện năm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbThang.Text.Trim() == "")
                {
                    MessageBox.Show("Nhập điều kiện tháng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string sql;
                sql = "select c.TenDauBep,b.TenMonAn,a.Ngaydung, a.SoLuong, b.DonGia, a.SoLuong * b.DonGia " +
                      " as GiaTien from  ChiTietThucDon a join MonAn b on a.MaMonAn = b.MaMonAn join DauBep c on a.MaDauBep = c.MaDauBep" +
                      " where (YEAR(a.Ngaydung)=" + cmbNam.Text + "  ) AND ( MONTH(a.Ngaydung)  =" + cmbThang.Text +
                      "  ) AND TenDauBep LIKE N'%" + cmbDaubep.Text + "%'";

                DAO3.OpenConnection();
                DAO3.LoadDataToGridView(sql, dataGridViewDoanhthu);


            }
            if (cmbDK.Text.Trim() == "Năm")
            {

                if (cmbNam.Text.Trim() == "")
                {
                    MessageBox.Show("Nhập điều kiện năm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string sql;
                sql = "select c.TenDauBep,b.TenMonAn,a.Ngaydung, a.SoLuong, b.DonGia, a.SoLuong * b.DonGia " +
                        " as GiaTien from ChiTietThucDon a join MonAn b on a.MaMonAn = b.MaMonAn join DauBep c on a.MaDauBep = c.MaDauBep" +
                      " where  (YEAR(a.Ngaydung)=" + cmbNam.Text + "  ) AND TenDauBep LIKE N'%" + cmbDaubep.Text + "%'";

                DAO3.OpenConnection();
                DAO3.LoadDataToGridView(sql, dataGridViewDoanhthu);

            }
            if (cmbDK.Text.Trim() == "Quý")
            {

                if (cmbNam.Text.Trim() == "")
                {
                    MessageBox.Show("Nhập điều kiện năm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbQuy.Text.Trim() == "")
                {
                    MessageBox.Show("Nhập điều kiện tháng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string sql;
                sql = "select c.TenDauBep,b.TenMonAn,a.Ngaydung, a.SoLuong, b.DonGia, a.SoLuong * b.DonGia " +
                " as GiaTien from ChiTietThucDon a join MonAn b on a.MaMonAn = b.MaMonAn join DauBep c on a.MaDauBep = c.MaDauBep" +
                      " where (YEAR(a.Ngaydung)="
                 + cmbNam.Text + "  ) AND TenDauBep LIKE N'%" + cmbDaubep.Text + "%'";

                switch (cmbQuy.Text)
                {
                    case "1":
                        {
                            sql = sql + " AND MONTH(a.Ngaydung) <=3 and MONTH(a.Ngaydung) >=1 ";
                            DAO3.OpenConnection();
                            DAO3.LoadDataToGridView(sql, dataGridViewDoanhthu);
                            break;
                        }
                    case "2":
                        {
                            sql = sql + " AND MONTH(a.Ngaydung) <=6 and MONTH(a.Ngaydung) >=4 ";
                            DAO3.OpenConnection();
                            DAO3.LoadDataToGridView(sql, dataGridViewDoanhthu);
                            break;
                        }
                    case "3":
                        {
                            sql = sql + " AND MONTH(a.Ngaydung) <=9 and MONTH(a.Ngaydung) >=7 ";
                            DAO3.OpenConnection();
                            DAO3.LoadDataToGridView(sql, dataGridViewDoanhthu);
                            break;
                        }
                    case "4":
                        {
                            sql = sql + " AND MONTH(a.Ngaydung) <=12 and MONTH(a.Ngaydung) >=10 ";
                            DAO3.OpenConnection();
                            DAO3.LoadDataToGridView(sql, dataGridViewDoanhthu);
                            break;
                        }

                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            double dt;
            {

                string sql;
                if (cmbDK.Text.Trim() == "Tháng")
                {
                    if (cmbThang.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn cần phải nhập tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbThang.Focus();
                        return;
                    }
                    if (cmbNam.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn cần phải nhập Năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbNam.Focus();
                        return;
                    }
                    sql = "select sum(a.SoLuong * b.DonGia) fromChiTietThucDon a join MonAn b on a.MaMonAn = b.MaMonAn join DauBep c on a.MaDauBep = c.MaDauBep" +
                  " where  month(Ngaydung) = " + cmbThang.Text + " and year(Ngaydung)=" + cmbNam.Text + " AND TenDauBep LIKE N'%" + cmbDaubep.Text + "%'";

                    dt = Convert.ToDouble(DAO3.DocBang(sql).Rows[0][0].ToString());
                    txtTongtien.Text = dt.ToString();
                }
                if (cmbDK.Text.Trim() == "Năm")
                {
                    if (cmbNam.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn cần phải nhập Năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbNam.Focus();
                        return;
                    }
                    sql = "select sum(a.SoLuong * b.DonGia) from ChiTietThucDon a join MonAn b on a.MaMonAn = b.MaMonAn join DauBep c on a.MaDauBep = c.MaDauBep" +
                      " where  year(Ngaydung)=" + cmbNam.Text + " AND TenDauBep LIKE N'%" + cmbDaubep.Text + "%'";

                    dt = Convert.ToDouble(DAO3.DocBang(sql).Rows[0][0].ToString());
                    txtTongtien.Text = dt.ToString();
                }
                if (cmbDK.Text.Trim() == "Quý")
                {

                    if (cmbNam.Text.Trim() == "")
                    {
                        MessageBox.Show("Nhập điều kiện năm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (cmbQuy.Text.Trim() == "")
                    {
                        MessageBox.Show("Nhập điều kiện tháng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    sql = "select sum(a.SoLuong * b.DonGia) from ChiTietThucDon a join MonAn b on a.MaMonAn = b.MaMonAn join DauBep c on a.MaDauBep = c.MaDauBep" +
                      " where year(a.Ngaydung)="
                     + cmbNam.Text + "   AND TenDauBep LIKE N'%" + cmbDaubep.Text + "%'";

                    switch (cmbQuy.Text)
                    {
                        case "1":
                            {
                                sql = sql + " AND MONTH(a.Ngaydung) <=3 and MONTH(a.Ngaydung) >=1 ";
                                dt = Convert.ToDouble(DAO3.DocBang(sql).Rows[0][0].ToString());
                                txtTongtien.Text = dt.ToString();
                                break;
                            }
                        case "2":
                            {
                                sql = sql + " AND MONTH(a.Ngaydung) <=6 and MONTH(a.Ngaydung) >=4 ";
                                dt = Convert.ToDouble(DAO3.DocBang(sql).Rows[0][0].ToString());
                                txtTongtien.Text = dt.ToString();
                                break;
                            }
                        case "3":
                            {
                                sql = sql + " AND MONTH(a.Ngaydung) <=9 and MONTH(a.Ngaydung) >=7 ";
                                dt = Convert.ToDouble(DAO3.DocBang(sql).Rows[0][0].ToString());
                                txtTongtien.Text = dt.ToString();
                                break;
                            }
                        case "4":
                            {
                                sql = sql + " AND MONTH(a.Ngaydung) <=12 and MONTH(a.Ngaydung) >=10 ";
                                dt = Convert.ToDouble(DAO3.DocBang(sql).Rows[0][0].ToString());
                                txtTongtien.Text = dt.ToString();
                                break;
                            }

                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable danhsach, doanhthu;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Size = 12;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;//Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "NHÀ HÀNG LITTLE ITALY";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = " ĐỐNG ĐA - HÀ NỘI";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại:  097 383 3707";
            exRange.Range["A6:A6"].Font.Bold = true;
            exRange.Range["A6:A6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B6:B6"].Font.Bold = true;
            exRange.Range["B6:B6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:A6"].Value = "Họ tên đầu bếp: ";
            exRange.Range["B6:B6"].Value = cmbDaubep.Text;
            exRange.Range["A7:A7"].Font.Bold = true;
            exRange.Range["A7:A7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B7:B7"].Font.Bold = true;
            exRange.Range["B7:B7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A7:A7"].Value = "Tháng: ";
            exRange.Range["B7:B7"].Value = cmbThang.Text;
            exRange.Range["C7:C7"].Value = "Quý: ";
            exRange.Range["D7:D7"].Value = cmbQuy.Text;
            exRange.Range["E7:E7"].Value = "Năm: ";
            exRange.Range["F7:F7"].Value = cmbNam.Text;
            exRange.Range["B5:F5"].Font.Size = 16;
            exRange.Range["B5:F5"].Font.Bold = true;
            exRange.Range["B5:F5"].Font.ColorIndex = 3;//Màu đỏ
            exRange.Range["B5:F5"].MergeCells = true;
            exRange.Range["B5:F5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:F5"].Value = "BÁO CÁO TỔNG TIỀN CỦA ĐẦU BẾP";
            sql = "select b.TenMonAn, a.SoLuong, a.SoLuong * b.DonGia from ChiTietThucDon a" +
                " join MonAn b on a.MaMonAn = b.MaMonAn join DauBep c on a.MaDauBep = c.MaDauBep" +
                      " where  year(Ngaydung)=" + cmbNam.Text +
                    " AND TenDauBep LIKE N'%" + cmbDaubep.Text + "%'";
            if (cmbDK.Text.Trim() == "Tháng")
                sql = sql + "and month(Ngaydung) = " + cmbThang.Text;
            else if (cmbDK.Text.Trim() == "Quý")
            {
                switch (cmbQuy.Text)
                {
                    case "1":
                        sql = sql + " AND MONTH(a.Ngaydung) <=3 and MONTH(a.Ngaydung) >=1 ";
                        break;
                    case "2":
                        sql = sql + " AND MONTH(a.Ngaydung) <=6 and MONTH(a.Ngaydung) >=4 ";
                        break;
                    case "3":
                        sql = sql + " AND MONTH(a.Ngaydung) <=9 and MONTH(a.Ngaydung) >=7 ";
                        break;
                    case "4":
                        sql = sql + " AND MONTH(a.Ngaydung) <=12 and MONTH(a.Ngaydung) >=10 ";
                        break;
                }
            }

            MessageBox.Show(sql);
            danhsach = DAO3.DocBang(sql);
            exRange.Range["A9:F9"].Font.Bold = true;
            exRange.Range["A9:F9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B9:B9"].ColumnWidth = 12;
            exRange.Range["C9:C9"].ColumnWidth = 18;
            exRange.Range["D9:D9"].ColumnWidth = 12;
            exRange.Range["E9:E9"].ColumnWidth = 15;
            exRange.Range["F9:F9"].ColumnWidth = 12;
            exRange.Range["A9:A9"].Value = "STT";
            exRange.Range["B9:B9"].Value = "Tên món ăn";
            exRange.Range["C9:C9"].Value = "Số lượng";
            exRange.Range["D9:D9"].Value = "Thành tiền";

            for (hang = 0; hang < danhsach.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 10] = hang + 1;
                for (cot = 0; cot < danhsach.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 2][hang + 10] = danhsach.Rows[hang][cot].ToString();
                }
            }

            sql = "select sum(a.SoLuong * b.DonGia) from ChiTietThucDon a join MonAn b on a.MaMonAn = b.MaMonAn join DauBep c on a.MaDauBep = c.MaDauBep" +
                      " where  year(Ngaydung)=" + cmbNam.Text +
                    " AND TenDauBep LIKE N'%" + cmbDaubep.Text + "%'";
            if (cmbDK.Text.Trim() == "Tháng")
                sql = sql + "and month(Ngaydung) = " + cmbThang.Text;
            else if (cmbDK.Text.Trim() == "Quý")
            {
                switch (cmbQuy.Text)
                {
                    case "1":
                        sql = sql + " AND MONTH(a.Ngaydung) <=3 and MONTH(a.Ngaydung) >=1 ";
                        break;
                    case "2":
                        sql = sql + " AND MONTH(a.Ngaydung) <=6 and MONTH(a.Ngaydung) >=4 ";
                        break;
                    case "3":
                        sql = sql + " AND MONTH(a.Ngaydung) <=9 and MONTH(a.Ngaydung) >=7 ";
                        break;
                    case "4":
                        sql = sql + " AND MONTH(a.Ngaydung) <=12 and MONTH(a.Ngaydung) >=10 ";
                        break;
                }
            }

            MessageBox.Show(sql);
            doanhthu = DAO3.DocBang(sql);
            exRange = exSheet.Cells[1][hang + 12];
            exRange.Range["C1:C1"].Font.Bold = true;
            exRange.Range["C1:C1"].Value = "Tổng tiền :";
            exRange.Range["D1:D1"].Value = doanhthu.Rows[0][0].ToString();
            exRange = exSheet.Cells[1][hang + 13];
            exRange.Range["E1:E1"].Font.Bold = true;
            exRange = exSheet.Cells[1][hang + 14];
            exRange.Range["D1:G1"].MergeCells = true;
            exRange.Range["D1:G1"].Font.Bold = true;
            exRange.Range["D1:G1"].Font.Italic = true;
            exRange.Range["D1:G1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange = exSheet.Cells[1][hang + 16];
            exRange.Range["D1:E1"].MergeCells = true;
            exRange.Range["D1:F1"].Font.Italic = true;
            exRange.Range["E1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D1:E1"].Value = "Hà Nội, Ngày " + DateTime.Now.ToShortDateString();
            exSheet.Name = "Báo cáo";
            exApp.Visible = true;

        }

        private void btnBCTH_Click(object sender, EventArgs e)
        {
            if (cmbDK.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải chọn điều kiện!");
                cmbDK.Focus();
                return;
            }

            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable danhsach, doanhthu;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;//Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "NHÀ HÀNG LITTLE ITALY";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = " ĐỐNG ĐA - HÀ NỘI";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại:  097 383 3707";
            exRange.Range["A6:A6"].Font.Bold = true;
            exRange.Range["A6:A6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B6:B6"].Font.Bold = true;
            exRange.Range["B6:B6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A7:F7"].Font.Bold = true;
            exRange.Range["A7:F7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C7:C7"].Font.Bold = true;
            exRange.Range["C7:C7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A7:A7"].Value = "Tháng: ";
            exRange.Range["B7:B7"].Value = cmbThang.Text;
            exRange.Range["C7:C7"].Value = "Quý: ";
            exRange.Range["D7:D7"].Value = cmbQuy.Text;
            exRange.Range["E7:E7"].Value = "Năm: ";
            exRange.Range["F7:F7"].Value = cmbNam.Text;
            exRange.Range["B5:F5"].Font.Size = 16;
            exRange.Range["B5:F5"].Font.Bold = true;
            exRange.Range["B5:F5"].Font.ColorIndex = 3;//Màu đỏ
            exRange.Range["B5:F5"].MergeCells = true;
            exRange.Range["B5:F5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:F5"].Value = "BÁO CÁO TỔNG TIỀN CỦA CÁC ĐẦU BẾP";
            sql = "select c.TenDauBep, SUM( a.SoLuong * b.DonGia) from ChiTietThucDon a join MonAn b on a.MaMonAn = b.MaMonAn join DauBep c on a.MaDauBep = c.MaDauBep" +
                      " where  year(Ngaydung)=" + cmbNam.Text;
            if (cmbDK.Text.Trim() == "Tháng")
                sql = sql + "and month(Ngaydung) = " + cmbThang.Text + "group by c.TenDauBep";
            if (cmbDK.Text.Trim() == "Quý")
            {
                switch (cmbQuy.Text)
                {
                    case "1":
                        sql = sql + " AND MONTH(a.Ngaydung) <=3 and MONTH(a.Ngaydung) >=1 group by c.TenDauBep ";
                        break;
                    case "2":
                        sql = sql + " AND MONTH(a.Ngaydung) <=6 and MONTH(a.Ngaydung) >=4 group by c.TenDauBep";
                        break;
                    case "3":
                        sql = sql + " AND MONTH(a.Ngaydung) <=9 and MONTH(a.Ngaydung) >=7 group by c.TenDauBep";
                        break;
                    case "4":
                        sql = sql + " AND MONTH(a.Ngaydung) <=12 and MONTH(a.Ngaydung) >=10 group by c.TenDauBep";
                        break;
                }
            }

            if (cmbDK.Text.Trim() == "Năm")
                sql = sql + " group by c.TenDauBep";


            MessageBox.Show(sql);
            danhsach = DAO3.DocBang(sql);
            exRange.Range["A9:F9"].Font.Bold = true;
            exRange.Range["A9:F9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B9:B9"].ColumnWidth = 12;
            exRange.Range["C9:C9"].ColumnWidth = 18;
            exRange.Range["D9:D9"].ColumnWidth = 12;
            exRange.Range["E9:E9"].ColumnWidth = 15;
            exRange.Range["F9:F9"].ColumnWidth = 12;
            exRange.Range["A9:A9"].Value = "STT";
            exRange.Range["B9:B9"].Value = "Tên đầu bếp";
            exRange.Range["C9:C9"].Value = "Tổng tiền";


            for (hang = 0; hang < danhsach.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 10] = hang + 1;
                for (cot = 0; cot < danhsach.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 2][hang + 10] = danhsach.Rows[hang][cot].ToString();
                }
            }

            sql = "select  SUM( a.SoLuong * b.DonGia) from ChiTietThucDon a join MonAn b on a.MaMonAn = b.MaMonAn join DauBep c on a.MaDauBep = c.MaDauBep" +
                      " where  year(Ngaydung)=" + cmbNam.Text;
            if (cmbDK.Text.Trim() == "Tháng")
                sql = sql + "and month(Ngaydung) = " + cmbThang.Text;
            else if (cmbDK.Text.Trim() == "Quý")
            {
                switch (cmbQuy.Text)
                {
                    case "1":
                        sql = sql + " AND MONTH(a.Ngaydung) <=3 and MONTH(a.Ngaydung) >=1 ";
                        break;
                    case "2":
                        sql = sql + " AND MONTH(a.Ngaydung) <=6 and MONTH(a.Ngaydung) >=4 ";
                        break;
                    case "3":
                        sql = sql + " AND MONTH(a.Ngaydung) <=9 and MONTH(a.Ngaydung) >=7 ";
                        break;
                    case "4":
                        sql = sql + " AND MONTH(a.Ngaydung) <=12 and MONTH(a.Ngaydung) >=10 ";
                        break;
                }
            }

            MessageBox.Show(sql);
            doanhthu = DAO3.DocBang(sql);
            exRange = exSheet.Cells[1][hang + 12];
            exRange.Range["C1:C1"].Font.Bold = true;
            exRange.Range["C1:C1"].Value = "Tổng doanh thu :";
            exRange.Range["D1:D1"].Value = doanhthu.Rows[0][0].ToString();
            exRange = exSheet.Cells[1][hang + 13];
            exRange.Range["D1:D1"].Font.Bold = true;
            exRange = exSheet.Cells[1][hang + 14];
            exRange.Range["D1:G1"].MergeCells = true;
            exRange.Range["D1:G1"].Font.Bold = true;
            exRange.Range["D1:G1"].Font.Italic = true;
            exRange.Range["D1:G1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange = exSheet.Cells[1][hang + 16];
            exRange.Range["D1:E1"].MergeCells = true;
            exRange.Range["E1:F1"].Font.Italic = true;
            exRange.Range["E1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D1:E1"].Value = "Hà Nội, Ngày " + DateTime.Now.ToShortDateString();
            exSheet.Name = "Báo cáo";
            exApp.Visible = true;


        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
   
