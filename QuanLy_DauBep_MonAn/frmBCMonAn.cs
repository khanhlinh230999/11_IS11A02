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
using COMExcel = Microsoft.Office.Interop.Excel;


namespace QuanLy_DauBep_MonAn
{
    public partial class frmBCMonAn : Form
    {
        public frmBCMonAn()
        {
            InitializeComponent();
        }

        private void frmBCMonAn_Load(object sender, EventArgs e)
        {
            DAO3.OpenConnection();

            DAO3.CloseConnection();
        }

        private void btnThongTinMonAn_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select a.MaMonAn, a.TenMonAn,b.TenLoai, c.TenCongDung, a.DonGia, a.YeuCau, a.CachLam " +
                "from MonAn AS a, Loai_Mon_An AS b, Cong_Dung AS c where a.MaLoai = b.MaLoai AND a.MaCongDung = c.MaCongDung";

            DataTable tblMA;
            tblMA = DAO3.DocBang(sql);
            dataGridView1.DataSource = tblMA;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select a.MaMonAn, a.TenMonAn,b.TenLoai, c.TenCongDung, a.DonGia, a.YeuCau, a.CachLam " +
                 "from MonAn AS a, Loai_Mon_An AS b, Cong_Dung AS c where a.MaLoai = b.MaLoai AND a.MaCongDung = c.MaCongDung";

            DataTable tblMA;
            tblMA = DAO3.DocBang(sql);
            dataGridView1.DataSource = tblMA;

            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;

            int hang = 0, cot = 0;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
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
            exRange.Range["B6:H6"].Font.Size = 20;
            exRange.Range["A6:H6"].Font.Name = "Times new roman";
            exRange.Range["A6:H7"].Font.Bold = true;
            exRange.Range["A6:H7"].Font.ColorIndex = 3;
            exRange.Range["C6:F6"].MergeCells = true;
            exRange.Range["B6:H7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            exRange.Range["C6:F6"].Value = " THÔNG TIN CÁC MÓN ĂN ";
            exRange.Range["A8:H8"].Font.Bold = true;
            exRange.Range["A8:H8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            exRange.Range["A8:A8"].ColumnWidth = 8;
            exRange.Range["B8:B8"].ColumnWidth = 24;
            exRange.Range["C8:C8"].ColumnWidth = 30;
            exRange.Range["D8:D8"].ColumnWidth = 25;
            exRange.Range["E8:E8"].ColumnWidth = 20;
            exRange.Range["F8:F8"].ColumnWidth = 26;
            exRange.Range["G8:G8"].ColumnWidth = 30;
            exRange.Range["H8:H8"].ColumnWidth = 30;
            exRange.Range["A8:A8"].Value = "STT";
            exRange.Range["B8:B8"].Value = "Mã món ăn";
            exRange.Range["C8:C8"].Value = "Tên món ăn";
            exRange.Range["D8:D8"].Value = "Loại món ăn";
            exRange.Range["E8:E8"].Value = "Công Dụng";
            exRange.Range["F8:F8"].Value = "Đơn giá ";
            exRange.Range["G8:G8"].Value = "Yêu cầu ";
            exRange.Range["H8:H8"].Value = "Cách làm ";

            exRange = exSheet.Cells[1][hang + 8];
            exRange.Range["A1:H" + (tblMA.Rows.Count + 1) + ""].Borders.Color = Color.Black;
            exRange.Range["A2:H" + (tblMA.Rows.Count + 1) + ""].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange = exSheet.Cells[1, 1];

            for (hang = 0; hang <= tblMA.Rows.Count - 1; hang++)
            {
                exSheet.Cells[1][hang + 9] = hang + 1;
                for (cot = 0; cot < tblMA.Columns.Count; cot++)
                    exSheet.Cells[cot + 2][hang + 9] = tblMA.Rows[hang][cot].ToString();
            }
            exApp.Visible = true;
            exRange.Range["F1:G1"].MergeCells = true;
            exRange.Range["D1:G1"].Font.Italic = true;
            exRange.Range["F1:G1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["F1:G1"].Value = "Hà Nội, Ngày " + DateTime.Now.ToShortDateString();
        }
    }
}
