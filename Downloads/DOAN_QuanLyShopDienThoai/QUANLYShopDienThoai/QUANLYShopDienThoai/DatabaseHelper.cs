using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QUANLYShopDienThoai
{
    public class DatabaseHelper
    {

        public static string strConnect = @"Data Source=DESKTOP-UOFSMED\SQLEXPRESS;Initial Catalog=QUANLYDIENTHOAI;Integrated Security=True;TrustServerCertificate=True";
        // Hàm lấy dữ liệu (SELECT)
        public static DataTable GetDataTable(string query)
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    return null;
                }
            }
        }

        // Hàm thực hiện lệnh (INSERT, UPDATE, DELETE) có tham số
        public static void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thực thi: " + ex.Message);
                }
            }
        }
    }
}
