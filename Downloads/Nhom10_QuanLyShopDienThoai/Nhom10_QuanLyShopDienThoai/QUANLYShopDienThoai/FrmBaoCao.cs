using System;
using System.Data;
using System.Windows.Forms;

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
            this.Text = "BÁO CÁO DOANH THU & LỢI NHUẬN";
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Today;
        }

        private string GetQueryString(string tu, string den)
        {
            return $@"
                SELECT 
                    sp.TenSP,
                    sp.GiaNhap,
                    ct.DonGia AS GiaBan,
                    SUM(ct.SoLuong) AS SoLuong,
                    SUM(ct.SoLuong * ct.DonGia) AS DoanhThu,
                    SUM(ct.SoLuong * ct.DonGia) * 0.01 AS HoaHong,
                    SUM((ct.DonGia - sp.GiaNhap) * ct.SoLuong) 
                        - SUM(ct.SoLuong * ct.DonGia) * 0.01 AS LoiNhuan
                FROM HOA_DON hd
                JOIN CT_HOA_DON ct ON hd.MaHD = ct.MaHD
                JOIN SAN_PHAM sp ON ct.MaSP = sp.MaSP
                WHERE CAST(hd.NgayBan AS DATE) BETWEEN '{tu}' AND '{den}'
                GROUP BY sp.TenSP, sp.GiaNhap, ct.DonGia
                ORDER BY DoanhThu DESC
            ";
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

                decimal tongDoanhThu = 0;
                decimal tongHoaHong = 0;
                decimal tongLoiNhuan = 0;

                foreach (DataRow row in dt.Rows)
                {
                    tongDoanhThu += Convert.ToDecimal(row["DoanhThu"]);
                    tongHoaHong += Convert.ToDecimal(row["HoaHong"]);
                    tongLoiNhuan += Convert.ToDecimal(row["LoiNhuan"]);
                }

                lblTongDoanhThu.Text = $"TỔNG DOANH THU: {tongDoanhThu:#,##0} VNĐ";
                lblTongLoiNhuan.Text = $"LỢI NHUẬN (SAU HOA HỒNG): {tongLoiNhuan:#,##0} VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                string tu = dtpTuNgay.Value.ToString("yyyy-MM-dd");
                string den = dtpDenNgay.Value.ToString("yyyy-MM-dd");

                string sql = GetQueryString(tu, den);
                DataTable dt = DatabaseHelper.GetDataTable(sql);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để in.");
                    return;
                }

                dsShop ds = new dsShop();
                ds.Tables["dtDoanhThu"].Clear();
                ds.Tables["dtDoanhThu"].Merge(dt);

                rptDoanhThu rpt = new rptDoanhThu();
                rpt.SetDataSource(ds);

                FrmInBaoCao frm = new FrmInBaoCao();
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in báo cáo: " + ex.Message);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
