using System;
using System.Data;
using System.Drawing;
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
            this.Text = "BÁO CÁO DOANH THU";

            //  mặc định từ đầu tháng đến hôm nay
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Today;

            LoadDoanhThu();
        }

        private void LoadDoanhThu()
        {
            try
            {
                string tu = dtpTuNgay.Value.ToString("yyyy-MM-dd");
                string den = dtpDenNgay.Value.ToString("yyyy-MM-dd");

                string sql = $@"
                    SELECT
                        HD.MaHD,
                        HD.NgayBan,
                        ISNULL(NV.TenNV, N'Chưa có') AS TenNV,
                        ISNULL(KH.TenKH, N'-- Khách lẻ --') AS TenKH,
                        HD.TongTien
                    FROM HOA_DON HD
                    LEFT JOIN NHAN_VIEN NV ON HD.MaNV = NV.MaNV
                    LEFT JOIN KHACH_HANG KH ON HD.MaKH = KH.MaKH
                    WHERE CAST(HD.NgayBan AS DATE) BETWEEN '{tu}' AND '{den}'
                    ORDER BY HD.NgayBan DESC";

                DataTable dtTable = DatabaseHelper.GetDataTable(sql);
                dgvDoanhThu.DataSource = dtTable;

                dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDoanhThu.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10F, FontStyle.Bold);
                dgvDoanhThu.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                dgvDoanhThu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvDoanhThu.EnableHeadersVisualStyles = false;

                if (dtTable.Columns.Contains("TongTien"))
                    dgvDoanhThu.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                decimal tong = 0;
                foreach (DataRow row in dtTable.Rows)
                    tong += Convert.ToDecimal(row["TongTien"]);

                lblTongDoanhThu.Text = $"TỔNG DOANH THU: {tong:#,##0} đ";
                lblTongDoanhThu.Font = new Font("Tahoma", 18F, FontStyle.Bold);
                lblTongDoanhThu.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }

        
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }

        
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "ĐĂNG XUẤT",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "FrmLogin")
                        Application.OpenForms[i].Close();
                }

                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
            }
        }
    }
}