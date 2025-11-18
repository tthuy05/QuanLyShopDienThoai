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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnQLSanPham = new System.Windows.Forms.Button();
            this.groupBoxChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin Chào ! Vui Lòng Chọn Chức Năng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Controls.Add(this.btnLogout);
            this.groupBoxChucNang.Controls.Add(this.btnBaoCao);
            this.groupBoxChucNang.Controls.Add(this.btnBanHang);
            this.groupBoxChucNang.Controls.Add(this.btnQLSanPham);
            this.groupBoxChucNang.Location = new System.Drawing.Point(1, 66);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Size = new System.Drawing.Size(787, 246);
            this.groupBoxChucNang.TabIndex = 1;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Các Chức Năng";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(312, 160);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(152, 37);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBaoCao.Location = new System.Drawing.Point(562, 54);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(171, 49);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "Báo Cáo Doanh Thu";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.ForeColor = System.Drawing.Color.Black;
            this.btnBanHang.Location = new System.Drawing.Point(300, 56);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(188, 47);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "Tạo Hóa Đơn Bán Hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnQLSanPham
            // 
            this.btnQLSanPham.ForeColor = System.Drawing.Color.Black;
            this.btnQLSanPham.Location = new System.Drawing.Point(52, 61);
            this.btnQLSanPham.Name = "btnQLSanPham";
            this.btnQLSanPham.Size = new System.Drawing.Size(176, 42);
            this.btnQLSanPham.TabIndex = 0;
            this.btnQLSanPham.Text = "Quản Lý Sản Phẩm ";
            this.btnQLSanPham.UseVisualStyleBackColor = true;
            this.btnQLSanPham.Click += new System.EventHandler(this.btnQLSanPham_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(786, 327);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBoxChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnQLSanPham;
    }
}