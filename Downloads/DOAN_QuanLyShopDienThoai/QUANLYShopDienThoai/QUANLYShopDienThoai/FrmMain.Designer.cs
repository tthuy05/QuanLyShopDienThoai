namespace QUANLYShopDienThoai
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.btnBaoCao = new MaterialSkin.Controls.MaterialButton();
            this.btnBanHang = new MaterialSkin.Controls.MaterialButton();
            this.btnQLSanPham = new MaterialSkin.Controls.MaterialButton();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.groupBoxChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.BackColor = System.Drawing.Color.White;
            this.groupBoxChucNang.Controls.Add(this.btnBaoCao);
            this.groupBoxChucNang.Controls.Add(this.btnBanHang);
            this.groupBoxChucNang.Controls.Add(this.btnQLSanPham);
            this.groupBoxChucNang.Controls.Add(this.btnLogout);
            this.groupBoxChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxChucNang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChucNang.Location = new System.Drawing.Point(3, 80);
            this.groupBoxChucNang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxChucNang.Size = new System.Drawing.Size(501, 518);
            this.groupBoxChucNang.TabIndex = 1;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Menu";
            this.groupBoxChucNang.Enter += new System.EventHandler(this.groupBoxChucNang_Enter);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AutoSize = false;
            this.btnBaoCao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaoCao.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaoCao.Depth = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.HighEmphasis = true;
            this.btnBaoCao.Icon = null;
            this.btnBaoCao.Location = new System.Drawing.Point(97, 297);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnBaoCao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoCao.Size = new System.Drawing.Size(300, 60);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Báo Cáo Doanh Thu";
            this.btnBaoCao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaoCao.UseAccentColor = false;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.AutoSize = false;
            this.btnBanHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBanHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBanHang.Depth = 0;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.HighEmphasis = true;
            this.btnBanHang.Icon = null;
            this.btnBanHang.Location = new System.Drawing.Point(97, 186);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnBanHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBanHang.Size = new System.Drawing.Size(300, 60);
            this.btnBanHang.TabIndex = 2;
            this.btnBanHang.Text = "Tạo Hóa Đơn Bán Hàng";
            this.btnBanHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBanHang.UseAccentColor = false;
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnQLSanPham
            // 
            this.btnQLSanPham.AutoSize = false;
            this.btnQLSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQLSanPham.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQLSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnQLSanPham.Depth = 0;
            this.btnQLSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSanPham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSanPham.HighEmphasis = true;
            this.btnQLSanPham.Icon = null;
            this.btnQLSanPham.Location = new System.Drawing.Point(97, 85);
            this.btnQLSanPham.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnQLSanPham.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQLSanPham.Name = "btnQLSanPham";
            this.btnQLSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnQLSanPham.Size = new System.Drawing.Size(300, 60);
            this.btnQLSanPham.TabIndex = 1;
            this.btnQLSanPham.Text = "Quản Lý Sản Phẩm";
            this.btnQLSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnQLSanPham.UseAccentColor = false;
            this.btnQLSanPham.UseVisualStyleBackColor = false;
            this.btnQLSanPham.Click += new System.EventHandler(this.btnQLSanPham_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = false;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Icon = null;
            this.btnLogout.Location = new System.Drawing.Point(97, 406);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(300, 60);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 602);
            this.Controls.Add(this.groupBoxChucNang);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 3, 4);
            this.Text = "Xin Chào ! Vui Lòng Chọn Chức Năng";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBoxChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private MaterialSkin.Controls.MaterialButton btnBaoCao;
        private MaterialSkin.Controls.MaterialButton btnBanHang;
        private MaterialSkin.Controls.MaterialButton btnQLSanPham;
        private MaterialSkin.Controls.MaterialButton btnLogout;
    }
}