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
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.btnQLSanPham = new MaterialSkin.Controls.MaterialButton();
            this.btnBanHang = new MaterialSkin.Controls.MaterialButton();
            this.btnBaoCao = new MaterialSkin.Controls.MaterialButton();
            this.groupBoxChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Controls.Add(this.btnBaoCao);
            this.groupBoxChucNang.Controls.Add(this.btnBanHang);
            this.groupBoxChucNang.Controls.Add(this.btnQLSanPham);
            this.groupBoxChucNang.Controls.Add(this.btnLogout);
            this.groupBoxChucNang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChucNang.Location = new System.Drawing.Point(1, 66);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Size = new System.Drawing.Size(779, 248);
            this.groupBoxChucNang.TabIndex = 1;
            this.groupBoxChucNang.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Icon = null;
            this.btnLogout.Location = new System.Drawing.Point(286, 170);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(103, 36);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnQLSanPham
            // 
            this.btnQLSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQLSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnQLSanPham.Depth = 0;
            this.btnQLSanPham.HighEmphasis = true;
            this.btnQLSanPham.Icon = null;
            this.btnQLSanPham.Location = new System.Drawing.Point(29, 54);
            this.btnQLSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQLSanPham.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQLSanPham.Name = "btnQLSanPham";
            this.btnQLSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnQLSanPham.Size = new System.Drawing.Size(161, 36);
            this.btnQLSanPham.TabIndex = 1;
            this.btnQLSanPham.Text = "Quản Lý Sản Phẩm";
            this.btnQLSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnQLSanPham.UseAccentColor = false;
            this.btnQLSanPham.UseVisualStyleBackColor = true;
            this.btnQLSanPham.Click += new System.EventHandler(this.btnQLSanPham_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBanHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBanHang.Depth = 0;
            this.btnBanHang.HighEmphasis = true;
            this.btnBanHang.Icon = null;
            this.btnBanHang.Location = new System.Drawing.Point(249, 54);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBanHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBanHang.Size = new System.Drawing.Size(196, 36);
            this.btnBanHang.TabIndex = 2;
            this.btnBanHang.Text = "Tạo Hóa Đơn Bán Hàng";
            this.btnBanHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBanHang.UseAccentColor = false;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaoCao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaoCao.Depth = 0;
            this.btnBaoCao.HighEmphasis = true;
            this.btnBaoCao.Icon = null;
            this.btnBaoCao.Location = new System.Drawing.Point(526, 54);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaoCao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoCao.Size = new System.Drawing.Size(170, 36);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Báo Cáo Doanh Thu";
            this.btnBaoCao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaoCao.UseAccentColor = false;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(786, 327);
            this.Controls.Add(this.groupBoxChucNang);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmMain";
            this.Text = "Xin Chào ! Vui Lòng Chọn Chức Năng";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBoxChucNang.ResumeLayout(false);
            this.groupBoxChucNang.PerformLayout();
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