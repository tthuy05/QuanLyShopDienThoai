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
        string strConnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYDIENTHOAI;Integrated Security=True";

        public FrmTinhLuongNhanVien()
        {
            InitializeComponent();

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
            cboThang.SelectedIndex = DateTime.Now.Month - 1;
            cboNam.Text = DateTime.Now.Year.ToString();
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
    }
}
