using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using QUANLYShopDienThoai;

namespace QUANLYShopDienThoai
{
    
    public partial class FrmLogin : Form
    {
       
        private const string connectionString = @"Server=localhost\SQLEXPRESS01;Database=QUANLYDIENTHOAI;User Id=sa;Password=123456;TrustServerCertificate=True;";

        public FrmLogin()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '*';
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
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                   
                    command.Parameters.AddWithValue("@user", taiKhoan);
                    command.Parameters.AddWithValue("@pass", matKhau);

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

                            MessageBox.Show($"Đăng nhập thành công! Chào mừng {CurrentUser.TenNV} ({CurrentUser.Role}).", "Thông báo");

                           
                            FrmMain mainForm = new FrmMain();
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
                        MessageBox.Show($"Lỗi kết nối hoặc truy vấn CSDL. Vui lòng kiểm tra lại SQL Server Instance:\n{ex.Message}", "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}