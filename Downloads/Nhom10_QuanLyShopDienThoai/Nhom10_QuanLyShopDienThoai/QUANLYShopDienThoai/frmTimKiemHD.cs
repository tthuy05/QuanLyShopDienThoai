using System;
using System.Data;
using System.Windows.Forms;

namespace QUANLYShopDienThoai
{
    public partial class frmTimKiemHD : Form
    {
        public frmTimKiemHD()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.Trim();

            if (maHD == "")
                return;

            string sqlHD = $@"
                SELECT hd.MaHD, hd.NgayBan, hd.TongTien,
                       kh.TenKH, nv.TenNV
                FROM HOA_DON hd
                JOIN KHACH_HANG kh ON hd.MaKH = kh.MaKH
                JOIN NHAN_VIEN nv ON hd.MaNV = nv.MaNV
                WHERE hd.MaHD = {maHD}
            ";

            DataTable dtHD = DatabaseHelper.GetDataTable(sqlHD);
            if (dtHD.Rows.Count == 0)
                return;

            DataRow r = dtHD.Rows[0];
            txtNgay.Text = Convert.ToDateTime(r["NgayBan"]).ToString("dd/MM/yyyy");
            txtKhachHang.Text = r["TenKH"].ToString();
            txtNhanVien.Text = r["TenNV"].ToString();
            txtTongTien.Text = string.Format("{0:#,##0} VNĐ", r["TongTien"]);

            string sqlCT = $@"
                SELECT sp.TenSP,
                       ct.SoLuong,
                       ct.DonGia,
                       (ct.SoLuong * ct.DonGia) AS ThanhTien
                FROM CT_HOA_DON ct
                JOIN SAN_PHAM sp ON ct.MaSP = sp.MaSP
                WHERE ct.MaHD = {maHD}
            ";

            DataTable dtCT = DatabaseHelper.GetDataTable(sqlCT);
            dgvCTHD.DataSource = dtCT;

            dgvCTHD.Columns["DonGia"].DefaultCellStyle.Format = "#,##0";
            dgvCTHD.Columns["ThanhTien"].DefaultCellStyle.Format = "#,##0";
        }
    }
}
