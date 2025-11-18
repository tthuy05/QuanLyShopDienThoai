using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYShopDienThoai
{
    public partial class FrmMain : MaterialSkin.Controls.MaterialForm
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
            var skin = MaterialSkin.MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;   
            skin.ColorScheme = new ColorScheme(
                Primary.Indigo600, Primary.Indigo700, Primary.Indigo100,
                Accent.LightBlue200, TextShade.WHITE);
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Role == "NhanVien")
            {
                btnQLSanPham.Visible = false;
                btnBaoCao.Visible = false;
            }
        }
        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            FrmSanPham frm = new FrmSanPham();
            frm.ShowDialog();
        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            FrmBanHang frm = new FrmBanHang();
            frm.ShowDialog();
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FrmBaoCao frm = new FrmBaoCao();
            frm.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.IsLoggedIn = false;
            FrmLogin loginForm = new FrmLogin();
            loginForm.Show();
            this.Close();
        }
    }
}
