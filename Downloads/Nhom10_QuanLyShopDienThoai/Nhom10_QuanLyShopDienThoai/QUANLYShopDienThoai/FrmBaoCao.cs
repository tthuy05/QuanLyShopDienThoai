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
            this.Text = "BÁO CÁO LỢI NHUẬN";
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Today;
        }

        // =================================================
        //          QUERY FULL DOANH THU + LỢI NHUẬN
        // =================================================
        private string GetQueryString(string tu, string den)
        {
            return $@"
                SELECT 
                    sp.TenSP,
                    sp.GiaNhap,
                    ct.DonGia AS GiaBan,
                    SUM(ct.SoLuong) AS SoLuong,
                    SUM(ct.SoLuong * ct.DonGia) AS DoanhThu,
                    SUM((ct.DonGia - sp.GiaNhap) * ct.SoLuong) AS LoiNhuan
                FROM HOA_DON hd
                JOIN CT_HOA_DON ct ON hd.MaHD = ct.MaHD
                JOIN SAN_PHAM sp ON ct.MaSP = sp.MaSP
                WHERE CAST(hd.NgayBan AS DATE) BETWEEN '{tu}' AND '{den}'
                GROUP BY sp.TenSP, sp.GiaNhap, ct.DonGia
                ORDER BY DoanhThu DESC
            ";
        }

        // =================================================
        //                       XEM
        // =================================================
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
                decimal tongLoiNhuan = 0;

                foreach (DataRow row in dt.Rows)
                {
                    tongDoanhThu += Convert.ToDecimal(row["DoanhThu"]);
                    tongLoiNhuan += Convert.ToDecimal(row["LoiNhuan"]);
                }

                lblTongDoanhThu.Text = $"TỔNG DOANH THU: {tongDoanhThu:#,##0} VNĐ";
                lblTongLoiNhuan.Text = $"TỔNG LỢI NHUẬN: {tongLoiNhuan:#,##0} VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // =================================================
        //                      IN BÁO CÁO
        // =================================================
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

                // Nạp vào dataset dsShop → dtDoanhThu
                dsShop ds = new dsShop();
                ds.Tables["dtDoanhThu"].Clear();
                ds.Tables["dtDoanhThu"].Merge(dt);

                // Gọi Crystal Report
                rptDoanhThu rpt = new rptDoanhThu();
                rpt.SetDataSource(ds);

                // Mở form in
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

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
