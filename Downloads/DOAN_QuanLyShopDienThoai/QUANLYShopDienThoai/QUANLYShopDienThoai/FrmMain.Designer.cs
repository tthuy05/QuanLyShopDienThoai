namespace QUANLYShopDienThoai
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnBaoCao = new MaterialSkin.Controls.MaterialButton();
            this.btnBanHang = new MaterialSkin.Controls.MaterialButton();
            this.btnQLSanPham = new MaterialSkin.Controls.MaterialButton();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelSubtitle = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxHero = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.panelTitles = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHero)).BeginInit();
            this.panelRight.SuspendLayout();
            this.tableLayoutPanelMenu.SuspendLayout();
            this.panelTitles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AutoSize = false;
            this.btnBaoCao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaoCao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaoCao.Depth = 0;
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBaoCao.HighEmphasis = true;
            this.btnBaoCao.Icon = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Icon")));
            this.btnBaoCao.Location = new System.Drawing.Point(238, 0);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(10, 0, 0, 20);
            this.btnBaoCao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoCao.Size = new System.Drawing.Size(219, 156);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "BÁO CÁO\r\nDOANH THU";
            this.btnBaoCao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaoCao.UseAccentColor = false;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.AutoSize = false;
            this.btnBanHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBanHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBanHang.Depth = 0;
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBanHang.HighEmphasis = true;
            this.btnBanHang.Icon = ((System.Drawing.Image)(resources.GetObject("btnBanHang.Icon")));
            this.btnBanHang.Location = new System.Drawing.Point(238, 176);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBanHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBanHang.Size = new System.Drawing.Size(219, 177);
            this.btnBanHang.TabIndex = 3;
            this.btnBanHang.Text = "TẠO HÓA ĐƠN\r\nBÁN HÀNG";
            this.btnBanHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBanHang.UseAccentColor = false;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnQLSanPham
            // 
            this.btnQLSanPham.AutoSize = false;
            this.btnQLSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQLSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnQLSanPham.Depth = 0;
            this.btnQLSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQLSanPham.HighEmphasis = true;
            this.btnQLSanPham.Icon = ((System.Drawing.Image)(resources.GetObject("btnQLSanPham.Icon")));
            this.btnQLSanPham.Location = new System.Drawing.Point(0, 0);
            this.btnQLSanPham.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.btnQLSanPham.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQLSanPham.Name = "btnQLSanPham";
            this.btnQLSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnQLSanPham.Size = new System.Drawing.Size(218, 156);
            this.btnQLSanPham.TabIndex = 1;
            this.btnQLSanPham.Text = "QUẢN LÝ\r\nSẢN PHẨM";
            this.btnQLSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnQLSanPham.UseAccentColor = false;
            this.btnQLSanPham.UseVisualStyleBackColor = true;
            this.btnQLSanPham.Click += new System.EventHandler(this.btnQLSanPham_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = false;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Icon = ((System.Drawing.Image)(resources.GetObject("btnLogout.Icon")));
            this.btnLogout.Location = new System.Drawing.Point(0, 176);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(218, 177);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "ĐĂNG XUẤT";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnLogout.UseAccentColor = true;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // materialLabelTitle
            // 
            this.materialLabelTitle.Depth = 0;
            this.materialLabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabelTitle.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabelTitle.HighEmphasis = true;
            this.materialLabelTitle.Location = new System.Drawing.Point(0, 0);
            this.materialLabelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelTitle.Name = "materialLabelTitle";
            this.materialLabelTitle.Size = new System.Drawing.Size(457, 50);
            this.materialLabelTitle.TabIndex = 5;
            this.materialLabelTitle.Text = "QUẢN LÝ CỬA HÀNG";
            this.materialLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabelSubtitle
            // 
            this.materialLabelSubtitle.Depth = 0;
            this.materialLabelSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabelSubtitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelSubtitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelSubtitle.Location = new System.Drawing.Point(0, 50);
            this.materialLabelSubtitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSubtitle.Name = "materialLabelSubtitle";
            this.materialLabelSubtitle.Size = new System.Drawing.Size(457, 30);
            this.materialLabelSubtitle.TabIndex = 6;
            this.materialLabelSubtitle.Text = "Chào mừng , chúc bạn một ngày tốt lành!";
            this.materialLabelSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabelSubtitle.Click += new System.EventHandler(this.materialLabelSubtitle_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelMain.Controls.Add(this.pictureBoxHero, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelRight, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(894, 533);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // pictureBoxHero
            // 
            this.pictureBoxHero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxHero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHero.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHero.Image")));
            this.pictureBoxHero.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHero.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxHero.Name = "pictureBoxHero";
            this.pictureBoxHero.Size = new System.Drawing.Size(357, 533);
            this.pictureBoxHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHero.TabIndex = 0;
            this.pictureBoxHero.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.tableLayoutPanelMenu);
            this.panelRight.Controls.Add(this.panelTitles);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(357, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(40);
            this.panelRight.Size = new System.Drawing.Size(537, 533);
            this.panelRight.TabIndex = 1;
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.ColumnCount = 2;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMenu.Controls.Add(this.btnQLSanPham, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.btnBaoCao, 1, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.btnLogout, 0, 1);
            this.tableLayoutPanelMenu.Controls.Add(this.btnBanHang, 1, 1);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(40, 140);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 2;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(457, 353);
            this.tableLayoutPanelMenu.TabIndex = 7;
            // 
            // panelTitles
            // 
            this.panelTitles.Controls.Add(this.materialLabelSubtitle);
            this.panelTitles.Controls.Add(this.materialLabelTitle);
            this.panelTitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitles.Location = new System.Drawing.Point(40, 40);
            this.panelTitles.Name = "panelTitles";
            this.panelTitles.Size = new System.Drawing.Size(457, 100);
            this.panelTitles.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHero)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.tableLayoutPanelMenu.ResumeLayout(false);
            this.panelTitles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnBaoCao;
        private MaterialSkin.Controls.MaterialButton btnBanHang;
        private MaterialSkin.Controls.MaterialButton btnQLSanPham;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialLabel materialLabelTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabelSubtitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pictureBoxHero;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private System.Windows.Forms.Panel panelTitles;
    }
}