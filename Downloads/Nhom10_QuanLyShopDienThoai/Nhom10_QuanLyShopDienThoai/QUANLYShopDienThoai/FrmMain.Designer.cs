using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace QUANLYShopDienThoai
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelLeft;
        private Panel panelRight;
        private TableLayoutPanel tableLayoutPanelButtons;

        private MaterialButton btnSanPham;
        private MaterialButton btnBanHang;
        private MaterialButton btnKhachHang;
        private MaterialButton btnTimKiemHD;
        private MaterialButton btnBaoCao;
        private MaterialButton btnDangXuat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSanPham = new MaterialSkin.Controls.MaterialButton();
            this.btnBanHang = new MaterialSkin.Controls.MaterialButton();
            this.btnKhachHang = new MaterialSkin.Controls.MaterialButton();
            this.btnTimKiemHD = new MaterialSkin.Controls.MaterialButton();
            this.btnBaoCao = new MaterialSkin.Controls.MaterialButton();
            this.btnDangXuat = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelMain.Controls.Add(this.panelLeft, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelRight, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(994, 553);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightGray;
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(3, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(391, 547);
            this.panelLeft.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.tableLayoutPanelButtons);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(400, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(591, 547);
            this.panelRight.TabIndex = 1;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 1;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Controls.Add(this.btnSanPham, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnBanHang, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.btnKhachHang, 0, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.btnTimKiemHD, 0, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.btnBaoCao, 0, 4);
            this.tableLayoutPanelButtons.Controls.Add(this.btnDangXuat, 0, 5);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 6;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(591, 547);
            this.tableLayoutPanelButtons.TabIndex = 0;
            // 
            // btnSanPham
            // 
            this.btnSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSanPham.Depth = 0;
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSanPham.HighEmphasis = true;
            this.btnSanPham.Icon = null;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(4, 6);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSanPham.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSanPham.Size = new System.Drawing.Size(583, 58);
            this.btnSanPham.TabIndex = 0;
            this.btnSanPham.Text = "Quản lý sản phẩm";
            this.btnSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSanPham.UseAccentColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBanHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBanHang.Depth = 0;
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBanHang.HighEmphasis = true;
            this.btnBanHang.Icon = null;
            this.btnBanHang.Location = new System.Drawing.Point(4, 76);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBanHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBanHang.Size = new System.Drawing.Size(583, 58);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBanHang.UseAccentColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKhachHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKhachHang.Depth = 0;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKhachHang.HighEmphasis = true;
            this.btnKhachHang.Icon = null;
            this.btnKhachHang.Location = new System.Drawing.Point(4, 146);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKhachHang.Size = new System.Drawing.Size(583, 58);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKhachHang.UseAccentColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnTimKiemHD
            // 
            this.btnTimKiemHD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiemHD.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiemHD.Depth = 0;
            this.btnTimKiemHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiemHD.HighEmphasis = true;
            this.btnTimKiemHD.Icon = null;
            this.btnTimKiemHD.Location = new System.Drawing.Point(4, 216);
            this.btnTimKiemHD.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiemHD.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiemHD.Name = "btnTimKiemHD";
            this.btnTimKiemHD.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiemHD.Size = new System.Drawing.Size(583, 58);
            this.btnTimKiemHD.TabIndex = 3;
            this.btnTimKiemHD.Text = "Tìm kiếm hóa đơn";
            this.btnTimKiemHD.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiemHD.UseAccentColor = false;
            this.btnTimKiemHD.Click += new System.EventHandler(this.btnTimKiemHD_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaoCao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaoCao.Depth = 0;
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBaoCao.HighEmphasis = true;
            this.btnBaoCao.Icon = null;
            this.btnBaoCao.Location = new System.Drawing.Point(4, 286);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaoCao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoCao.Size = new System.Drawing.Size(583, 58);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Báo cáo doanh thu";
            this.btnBaoCao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaoCao.UseAccentColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangXuat.AutoSize = false;
            this.btnDangXuat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDangXuat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDangXuat.Depth = 0;
            this.btnDangXuat.HighEmphasis = true;
            this.btnDangXuat.Icon = null;
            this.btnDangXuat.Location = new System.Drawing.Point(220, 356);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDangXuat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDangXuat.Size = new System.Drawing.Size(150, 40);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDangXuat.UseAccentColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ SHOP ĐIỆN THOẠI";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private PictureBox pictureBox1;
    }
}
