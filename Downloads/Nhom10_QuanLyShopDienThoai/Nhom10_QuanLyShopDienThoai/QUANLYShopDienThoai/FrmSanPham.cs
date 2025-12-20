using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUANLYShopDienThoai
{
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            SetupInterface();

            txtGiaNhap.KeyPress += ChiNhapSo_KeyPress;
            txtGiaBan.KeyPress += ChiNhapSo_KeyPress;
            txtSoLuong.KeyPress += ChiNhapSo_KeyPress;
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM SAN_PHAM";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            dgvSanPham.DataSource = dt;
        }

        private void SetupInterface()
        {
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvSanPham.Columns.Contains("TenSP"))
                dgvSanPham.Columns["TenSP"].HeaderText = "Tên sản phẩm";

            if (dgvSanPham.Columns.Contains("GiaNhap"))
            {
                dgvSanPham.Columns["GiaNhap"].HeaderText = "Giá nhập";
                dgvSanPham.Columns["GiaNhap"].DefaultCellStyle.Format = "N0";
            }

            if (dgvSanPham.Columns.Contains("GiaBan"))
            {
                dgvSanPham.Columns["GiaBan"].HeaderText = "Giá bán";
                dgvSanPham.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
            }

            if (dgvSanPham.Columns.Contains("SoLuongTon"))
                dgvSanPham.Columns["SoLuongTon"].HeaderText = "Số lượng";

            txtMaSP.ReadOnly = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

            txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
            txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
            txtGiaNhap.Text = row.Cells["GiaNhap"].Value.ToString();
            txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
            txtSoLuong.Text = row.Cells["SoLuongTon"].Value.ToString();

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            txtTimKiem.Clear();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "" || txtGiaNhap.Text == "" || txtGiaBan.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("Thiếu dữ liệu bắt buộc");
                return;
            }

            string sql = @"INSERT INTO SAN_PHAM (TenSP, GiaNhap, GiaBan, SoLuongTon)
                           VALUES (@Ten, @GiaNhap, @GiaBan, @SL)";

            SqlParameter[] p =
            {
                new SqlParameter("@Ten", txtTenSP.Text),
                new SqlParameter("@GiaNhap", decimal.Parse(txtGiaNhap.Text)),
                new SqlParameter("@GiaBan", decimal.Parse(txtGiaBan.Text)),
                new SqlParameter("@SL", int.Parse(txtSoLuong.Text))
            };

            bool ketQua = DatabaseHelper.ExecuteNonQuery(sql, p);

            if (ketQua)
            {
                MessageBox.Show("Thêm sản phẩm thành công");
                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "") return;

            string sql = @"UPDATE SAN_PHAM
                           SET TenSP=@Ten, GiaNhap=@GiaNhap, GiaBan=@GiaBan, SoLuongTon=@SL
                           WHERE MaSP=@ID";

            SqlParameter[] p =
            {
                new SqlParameter("@Ten", txtTenSP.Text),
                new SqlParameter("@GiaNhap", decimal.Parse(txtGiaNhap.Text)),
                new SqlParameter("@GiaBan", decimal.Parse(txtGiaBan.Text)),
                new SqlParameter("@SL", int.Parse(txtSoLuong.Text)),
                new SqlParameter("@ID", txtMaSP.Text)
            };

            bool ketQua = DatabaseHelper.ExecuteNonQuery(sql, p);

            if (ketQua)
            {
                MessageBox.Show("Cập nhật sản phẩm thành công");
                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "") return;

            string sql = "DELETE FROM SAN_PHAM WHERE MaSP=@ID";
            SqlParameter[] p = { new SqlParameter("@ID", txtMaSP.Text) };

            bool ketQua = DatabaseHelper.ExecuteNonQuery(sql, p);

            if (ketQua)
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                btnLamMoi_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            string sql = $"SELECT * FROM SAN_PHAM WHERE TenSP LIKE N'%{tuKhoa}%'";
            dgvSanPham.DataSource = DatabaseHelper.GetDataTable(sql);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
