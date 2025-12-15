using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QUANLYShopDienThoai
{
    public partial class FrmMain : MaterialForm
    {
        private string role; // admin hoặc nhanvien

        public FrmMain(string role)
        {
            InitializeComponent();
            this.role = role;
            ApplyRole();
        }

        private void ApplyRole()
        {
            if (role.ToLower() == "nhanvien")
            {
                btnSanPham.Enabled = false;
                btnBaoCao.Enabled = false;
                btnKhachHang.Enabled = false;
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FrmSanPham frm = new FrmSanPham();
            frm.ShowDialog();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            frm.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void btnTimKiemHD_Click(object sender, EventArgs e)
        {
            frmTimKiemHD frm = new frmTimKiemHD();
            frm.ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FrmBaoCao frm = new FrmBaoCao();
            frm.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
