using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using QUANLYShopDienThoai;
using MaterialSkin;                  
using MaterialSkin.Controls;

namespace QUANLYShopDienThoai
{
    
    public partial class FrmLogin : MaterialSkin.Controls.MaterialForm
    {
       
        private const string connectionString = @"Server=localhost\SQLEXPRESS01;Database=QUANLYDIENTHOAI;User Id=sa;Password=123456;TrustServerCertificate=True;";

        public FrmLogin()
        {
            InitializeComponent();
            
            var skin = MaterialSkin.MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;  
            skin.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE
            );
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

                            MessageBox.Show($"Đăng nhập thành công! Chào mừng {CurrentUser.TenNV} .", "Thông báo");

                           
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
            //MessageBox.Show($"TK: [{txtTaiKhoan.Text}] | MK: [{txtMatKhau.Text}]");
            //return; 
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