namespace QUANLYShopDienThoai
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel panelListMenu;
        private System.Windows.Forms.Panel panelDesktop;

        private MaterialSkin.Controls.MaterialButton btnSanPham;
        private MaterialSkin.Controls.MaterialButton btnBanHang;
        private MaterialSkin.Controls.MaterialButton btnKhachHang;
        private MaterialSkin.Controls.MaterialButton btnTimKiemHD;
        private MaterialSkin.Controls.MaterialButton btnBaoCao;
        private MaterialSkin.Controls.MaterialButton btnSPNoiBat;
        private MaterialSkin.Controls.MaterialButton btnTinhLuong;
        private MaterialSkin.Controls.MaterialButton btnDangXuat;

        private System.Windows.Forms.PictureBox pictureBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));

            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelListMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDangXuat = new MaterialSkin.Controls.MaterialButton();

            this.btnTinhLuong = new MaterialSkin.Controls.MaterialButton();
            this.btnBaoCao = new MaterialSkin.Controls.MaterialButton();
            this.btnSPNoiBat = new MaterialSkin.Controls.MaterialButton();
            this.btnTimKiemHD = new MaterialSkin.Controls.MaterialButton();
            this.btnKhachHang = new MaterialSkin.Controls.MaterialButton();
            this.btnBanHang = new MaterialSkin.Controls.MaterialButton();
            this.btnSanPham = new MaterialSkin.Controls.MaterialButton();

            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();

            this.panelMenu.SuspendLayout();
            this.panelListMenu.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // 
            // panelMenu (Cột trái)
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.panelListMenu);
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Size = new System.Drawing.Size(330, 680);

            // 
            // btnDangXuat 
            // 
            this.btnDangXuat.AutoSize = false;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.Height = 60;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseAccentColor = true;
            this.btnDangXuat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);

            // 
            // panelListMenu 
            // 
            this.panelListMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelListMenu.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);

            this.panelListMenu.Controls.Add(this.btnSanPham);
            this.panelListMenu.Controls.Add(this.btnBanHang);
            this.panelListMenu.Controls.Add(this.btnKhachHang);
            this.panelListMenu.Controls.Add(this.btnTimKiemHD);
            this.panelListMenu.Controls.Add(this.btnBaoCao);
            this.panelListMenu.Controls.Add(this.btnSPNoiBat); 
            this.panelListMenu.Controls.Add(this.btnTinhLuong);

            System.Drawing.Size buttonSize = new System.Drawing.Size(330, 60);
            System.Windows.Forms.Padding buttonMargin = new System.Windows.Forms.Padding(0, 0, 0, 15);

            // btnSanPham
            this.btnSanPham.AutoSize = false;
            this.btnSanPham.Size = buttonSize;
            this.btnSanPham.Margin = buttonMargin;
            this.btnSanPham.Text = "Quản lý sản phẩm";
            this.btnSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);

            // btnBanHang
            this.btnBanHang.AutoSize = false;
            this.btnBanHang.Size = buttonSize;
            this.btnBanHang.Margin = buttonMargin;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);

            // btnKhachHang
            this.btnKhachHang.AutoSize = false;
            this.btnKhachHang.Size = buttonSize;
            this.btnKhachHang.Margin = buttonMargin;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);

            // btnTimKiemHD
            this.btnTimKiemHD.AutoSize = false;
            this.btnTimKiemHD.Size = buttonSize;
            this.btnTimKiemHD.Margin = buttonMargin;
            this.btnTimKiemHD.Text = "Tìm kiếm hóa đơn";
            this.btnTimKiemHD.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiemHD.Click += new System.EventHandler(this.btnTimKiemHD_Click);

            // btnBaoCao
            this.btnBaoCao.AutoSize = false;
            this.btnBaoCao.Size = buttonSize;
            this.btnBaoCao.Margin = buttonMargin;
            this.btnBaoCao.Text = "Báo cáo doanh thu";
            this.btnBaoCao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);

            // 
            // btnSPNoiBat (CẤU HÌNH CHI TIẾT NÚT MỚI)
            // 
            this.btnSPNoiBat.AutoSize = false;
            this.btnSPNoiBat.Size = buttonSize;
            this.btnSPNoiBat.Margin = buttonMargin;
            this.btnSPNoiBat.Text = "Sản phẩm nổi bật"; // Tên hiển thị trên nút
            this.btnSPNoiBat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSPNoiBat.Click += new System.EventHandler(this.btnSPNoiBat_Click); // Sự kiện click

            // btnTinhLuong
            this.btnTinhLuong.AutoSize = false;
            this.btnTinhLuong.Size = buttonSize;
            this.btnTinhLuong.Margin = buttonMargin;
            this.btnTinhLuong.Text = "Tính lương nhân viên";
            this.btnTinhLuong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);

            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Controls.Add(this.pictureBox1);

            // pictureBox1 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(1333, 763);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ SHOP ĐIỆN THOẠI";

            this.panelMenu.ResumeLayout(false);
            this.panelListMenu.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}