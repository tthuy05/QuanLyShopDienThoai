using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace QUANLYShopDienThoai
{
    public partial class FrmTinhLuongNhanVien : MaterialForm
    {
        // Chuỗi kết nối đến SQL Server của bạn
        string strConnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYDIENTHOAI;Integrated Security=True";

        public FrmTinhLuongNhanVien()
        {
            InitializeComponent();

            // Khởi tạo giao diện MaterialSkin
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Indigo600, Primary.Indigo700,
                Primary.Indigo200, Accent.Indigo200,
                TextShade.WHITE
            );
        }

        private void FrmTinhLuongNhanVien_Load(object sender, EventArgs e)
        {
            // Thiết lập mặc định cho ComboBox thời gian
            cboThang.SelectedIndex = DateTime.Now.Month - 1;
            cboNam.Text = DateTime.Now.Year.ToString();

            // Load danh sách nhân viên lên Grid ngay khi mở form
            LoadDanhSachNhanVien();
        }

        // --- 1. HÀM BỔ TRỢ: LOAD DỮ LIỆU ---
        private void LoadDanhSachNhanVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    string sql = "SELECT MaNV, TenNV, TaiKhoan, ChucVu, LuongCoBan FROM NHAN_VIEN";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLuong.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtTenNV.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtChucVu.Clear();
            txtLuongCoBan.Clear();
            txtTenNV.Focus();
        }


        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            int thang = cboThang.SelectedIndex + 1;
            int nam = int.Parse(cboNam.Text);

            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                SqlCommand cmd = new SqlCommand("SP_TINH_LUONG_NHAN_VIEN", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam", nam);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLuong.DataSource = dt; 
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên và Tài khoản!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();
                    string sql = @"INSERT INTO NHAN_VIEN (TenNV, TaiKhoan, MatKhau, ChucVu, LuongCoBan) 
                                 VALUES (@Ten, @TK, @MK, @CV, @LCB)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Ten", txtTenNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@TK", txtTaiKhoan.Text.Trim());
                    cmd.Parameters.AddWithValue("@MK", txtMatKhau.Text.Trim());
                    cmd.Parameters.AddWithValue("@CV", txtChucVu.Text.Trim());
                    // Nếu để trống lương thì mặc định 3.000.000
                    decimal luong = string.IsNullOrEmpty(txtLuongCoBan.Text) ? 3000000 : decimal.Parse(txtLuongCoBan.Text);
                    cmd.Parameters.AddWithValue("@LCB", luong);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên mới thành công!");

                    LoadDanhSachNhanVien();
                    ClearInputs();          
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLuong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa trên bảng!");
                return;
            }

            string maNV = dgvLuong.CurrentRow.Cells["MaNV"].Value.ToString();
            string tenNV = dgvLuong.CurrentRow.Cells["TenNV"].Value.ToString();

            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên [{tenNV}]?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(strConnect))
                    {
                        conn.Open();
                        string sql = "DELETE FROM NHAN_VIEN WHERE MaNV = @MaNV";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@MaNV", maNV);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa nhân viên thành công!");
                        LoadDanhSachNhanVien(); 
                    }
                }
                catch (SqlException ex)
                {
                    // Lỗi 547 là lỗi ràng buộc khóa ngoại (nhân viên đã có hóa đơn nên không xóa được)
                    if (ex.Number == 547)
                        MessageBox.Show("Không thể xóa nhân viên này vì họ đã có dữ liệu hóa đơn/bán hàng!");
                    else
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
        }
    }
}