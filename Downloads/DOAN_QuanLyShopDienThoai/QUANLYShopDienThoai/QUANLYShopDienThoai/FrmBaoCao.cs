using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient; 
using CrystalDecisions.CrystalReports.Engine; 

namespace QUANLYShopDienThoai
{
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            this.Text = "BÁO CÁO DOANH THU";
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Today;
        }

        private string GetQueryString(string tu, string den)
        {
            return $@"SELECT 
                        HD.MaHD, 
                        HD.NgayBan, 
                        ISNULL(NV.TenNV, N'Chưa có') AS TenNV, 
                        ISNULL(KH.TenKH, N'Khách lẻ') AS TenKH, 
                        HD.TongTien
                    FROM HOA_DON HD
                    LEFT JOIN NHAN_VIEN NV ON HD.MaNV = NV.MaNV
                    LEFT JOIN KHACH_HANG KH ON HD.MaKH = KH.MaKH
                    WHERE CAST(HD.NgayBan AS DATE) BETWEEN '{tu}' AND '{den}'";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string tu = dtpTuNgay.Value.ToString("yyyy-MM-dd");
                string den = dtpDenNgay.Value.ToString("yyyy-MM-dd");
                string sql = GetQueryString(tu, den);

                DataTable dt = DatabaseHelper.GetDataTable(sql);
                dgvDoanhThu.DataSource = dt;

                decimal tong = 0;
                foreach (DataRow row in dt.Rows) tong += Convert.ToDecimal(row["TongTien"]);
                lblTongDoanhThu.Text = $"TỔNG: {tong:#,##0} VNĐ";
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                string tu = dtpTuNgay.Value.ToString("yyyy-MM-dd");
                string den = dtpDenNgay.Value.ToString("yyyy-MM-dd");
                string sql = GetQueryString(tu, den);

                string connStr = @"Data Source=TTHUY005\SQLEXPRESS;Initial Catalog=QUANLYDIENTHOAI;Integrated Security=True;TrustServerCertificate=True";
                SqlDataAdapter da = new SqlDataAdapter(sql, new SqlConnection(connStr));
                DataTable dt = new DataTable();
                da.Fill(dt);

                dt.TableName = "dtDoanhThu";

                if (dt.Rows.Count > 0)
                {
                    rptDoanhThu rpt = new rptDoanhThu();
                    rpt.SetDataSource(dt);

                    FrmInBaoCao f = new FrmInBaoCao();
                    f.crystalReportViewer1.ReportSource = rpt;
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để in!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in: " + ex.Message);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}