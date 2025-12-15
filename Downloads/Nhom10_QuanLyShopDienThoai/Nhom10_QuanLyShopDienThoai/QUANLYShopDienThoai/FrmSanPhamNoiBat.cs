using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QUANLYShopDienThoai
{
    public partial class FrmSanPhamNoiBat : MaterialForm
    {
        public FrmSanPhamNoiBat()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Cyan400, TextShade.WHITE);
        }

        private void FrmSanPhamNoiBat_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;

            LoadChart();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void LoadChart()
        {
            chartSanPham.Series.Clear();
            chartSanPham.Titles.Clear();

            chartSanPham.Titles.Add("TOP 3 SẢN PHẨM BÁN CHẠY NHẤT");
            chartSanPham.Titles[0].Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);

            Series series = new Series("Số lượng bán");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.Color = System.Drawing.Color.DodgerBlue;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT TOP 3
                            sp.TenSP,
                            SUM(ct.SoLuong) AS TongSoLuong
                        FROM HOA_DON hd
                        JOIN CT_HOA_DON ct ON hd.MaHD = ct.MaHD
                        JOIN SAN_PHAM sp ON ct.MaSP = sp.MaSP
                        WHERE CAST(hd.NgayBan AS DATE) BETWEEN @TuNgay AND @DenNgay
                        GROUP BY sp.TenSP
                        ORDER BY TongSoLuong DESC";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TuNgay", dtpTuNgay.Value.Date);
                    cmd.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value.Date);

                    SqlDataReader rd = cmd.ExecuteReader();

                    bool coDuLieu = false;
                    while (rd.Read())
                    {
                        coDuLieu = true;
                        string tenSP = rd["TenSP"].ToString();
                        int soLuong = Convert.ToInt32(rd["TongSoLuong"]);

                        series.Points.AddXY(tenSP, soLuong);
                    }

                    if (!coDuLieu)
                    {
                        MessageBox.Show("Không có dữ liệu bán hàng trong khoảng thời gian này.");
                    }
                }

                chartSanPham.Series.Add(series);

                chartSanPham.ChartAreas[0].AxisX.Interval = 1;
                chartSanPham.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải biểu đồ: " + ex.Message);
            }
        }
    }
}