using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void LoadData()
        {
            try
            {
                string sql = "SELECT * FROM SAN_PHAM";
                DataTable dt = DatabaseHelper.GetDataTable(sql);
                dgvSanPham.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
            }
        }

        private void SetupInterface()
        {
            // Định dạng tiền tệ cho cột Giá Bán
            if (dgvSanPham.Columns.Contains("GiaBan"))
                dgvSanPham.Columns["GiaBan"].DefaultCellStyle.Format = "N0";

            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvSanPham.Columns.Contains("TenSP")) dgvSanPham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            if (dgvSanPham.Columns.Contains("GiaBan")) dgvSanPham.Columns["GiaBan"].HeaderText = "Giá Bán";
            if (dgvSanPham.Columns.Contains("SoLuongTon")) dgvSanPham.Columns["SoLuongTon"].HeaderText = "Số Lượng";
            if (dgvSanPham.Columns.Contains("HinhAnh")) dgvSanPham.Columns["HinhAnh"].Visible = false;

            txtMaSP.ReadOnly = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                string gia = row.Cells["GiaBan"].Value.ToString();
                txtGiaBan.Text = gia.Replace(",", "").Replace(".", "").Replace(" ", "");

                txtSoLuong.Text = row.Cells["SoLuongTon"].Value.ToString();
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            txtTimKiem.Clear();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            LoadData();
            txtTenSP.Focus();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtGiaBan.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên và Giá sản phẩm!");
                return;
            }

            try
            {
                string sql = "INSERT INTO SAN_PHAM (TenSP, GiaBan, SoLuongTon) VALUES (@Ten, @Gia, @SL)";

                SqlParameter[] p = {
                    new SqlParameter("@Ten", txtTenSP.Text),
                    new SqlParameter("@Gia", decimal.Parse(txtGiaBan.Text)),
                    new SqlParameter("@SL", int.Parse(txtSoLuong.Text))
                };

                DatabaseHelper.ExecuteNonQuery(sql, p);
                MessageBox.Show("Thêm thành công!");
                btnLamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            try
            {
                string sql = "UPDATE SAN_PHAM SET TenSP=@Ten, GiaBan=@Gia, SoLuongTon=@SL WHERE MaSP=@ID";

                SqlParameter[] p = {
                    new SqlParameter("@Ten", txtTenSP.Text),
                    new SqlParameter("@Gia", decimal.Parse(txtGiaBan.Text)),
                    new SqlParameter("@SL", int.Parse(txtSoLuong.Text)),
                    new SqlParameter("@ID", txtMaSP.Text)
                };

                DatabaseHelper.ExecuteNonQuery(sql, p);
                MessageBox.Show("Cập nhật thành công!");
                btnLamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "") return;

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM SAN_PHAM WHERE MaSP=@ID";
                    SqlParameter[] p = { new SqlParameter("@ID", txtMaSP.Text) };
                    DatabaseHelper.ExecuteNonQuery(sql, p);
                    MessageBox.Show("Đã xóa!");
                    btnLamMoi_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            string sql = $"SELECT * FROM SAN_PHAM WHERE TenSP LIKE N'%{tuKhoa}%'";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            dgvSanPham.DataSource = dt;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}