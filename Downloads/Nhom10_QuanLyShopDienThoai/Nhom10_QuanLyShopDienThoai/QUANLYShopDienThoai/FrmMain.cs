using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace QUANLYShopDienThoai
{
    public partial class FrmMain : MaterialForm
    {
        private string role;
        private Form currentChildForm;

        public FrmMain(string role)
        {
            InitializeComponent();
            this.role = role;
            ApplyRole();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Indigo600, Primary.Indigo700,
                Primary.Indigo200, Accent.Indigo200,
                TextShade.WHITE
            );
        }

        private void ApplyRole()
        {
            if (!string.IsNullOrEmpty(role) && role.ToLower() == "nhanvien")
            {
                btnSanPham.Enabled = false;
                btnBaoCao.Enabled = false;
                btnKhachHang.Enabled = false;
                btnTinhLuong.Enabled = false;


            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();

            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSanPham());
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBanHang());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        private void btnTimKiemHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimKiemHD());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBaoCao());
        }

        private void btnSPNoiBat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSanPhamNoiBat());
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTinhLuongNhanVien());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}