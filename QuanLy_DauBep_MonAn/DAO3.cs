using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLy_DauBep_MonAn
{
    class DAO3
    {

        public static SqlConnection conn;
        public static string connectionString =
        "Data Source=LOVEYOURSELF\\SQL2014;Initial Catalog=QuanLyMonAn_DauBep;Integrated Security=True";
        public static void OpenConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            if (conn.State == System.Data.ConnectionState.Closed)
                try
                {
                    conn.Open();
                    // MessageBox.Show("Mở kết nối thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
        public static void CloseConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            if (conn.State == System.Data.ConnectionState.Open)
                try
                {
                    conn.Close();
                    //MessageBox.Show("Đóng kết nối thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
        public static bool checkKeyExit(string sql)
        {
            bool kq = false;
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adap.Fill(table);
            if (table.Rows.Count > 0)
                kq = true;
            return kq;
        }


        public static void FillDataToCombo(string sql, ComboBox combo, string ValueField, string DisplayField)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO3.conn);
            DataTable mytable = new DataTable();
            adapter.Fill(mytable);
            combo.DataSource = mytable;
            combo.ValueMember = ValueField;
            combo.DisplayMember = DisplayField;
        }
        public static DataTable DocBang(string sql)
        {
            DAO3.OpenConnection();
            SqlDataAdapter adap = new SqlDataAdapter(sql, DAO3.conn);
            DataTable table = new DataTable();
            adap.Fill(table);
            return table;
        }
        public static void LoadDataToGridView(string sql, DataGridView data)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            data.DataSource = table;
        }
    }
}

   

