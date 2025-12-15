using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace QUANLYShopDienThoai
{
    public partial class FrmLogin : MaterialForm
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYDIENTHOAI;Integrated Security=True;TrustServerCertificate=True";

        public FrmLogin()
        {
            InitializeComponent();

            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.LIGHT;
            skin.ColorScheme = new ColorScheme(
                Primary.Indigo500,
                Primary.Indigo700,
                Primary.Indigo100,
                Accent.Pink200,
                TextShade.WHITE
            );
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Nếu cần khởi tạo gì khi form load thì viết ở đây
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tài khoản và Mật khẩu.", "Cảnh báo");
                return;
            }

            string query = @"SELECT MaNV, TenNV, ChucVu FROM NHAN_VIEN WHERE TaiKhoan = @user AND MatKhau = @pass";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = taiKhoan;
                command.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = matKhau;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        CurrentUser.MaNV = reader.GetInt32(0);
                        CurrentUser.TenNV = reader.GetString(1);
                        CurrentUser.Role = reader.GetString(2);
                        CurrentUser.IsLoggedIn = true;

                        MessageBox.Show($"Đăng nhập thành công! Chào mừng {CurrentUser.TenNV}.", "Thông báo");

                        FrmMain mainForm = new FrmMain(CurrentUser.Role);
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối hoặc truy vấn CSDL:\n{ex.Message}", "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
