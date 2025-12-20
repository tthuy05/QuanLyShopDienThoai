namespace QUANLYShopDienThoai
{
    partial class FrmTinhLuongNhanVien
    {
        private System.ComponentModel.IContainer components = null;

        // Các control cũ
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cboThang;
        private MaterialSkin.Controls.MaterialComboBox cboNam;
        private MaterialSkin.Controls.MaterialButton btnTinhLuong;
        private System.Windows.Forms.DataGridView dgvLuong;

        // --- CÁC CONTROL MỚI THÊM VÀO ---
        private MaterialSkin.Controls.MaterialTextBox txtTenNV;
        private MaterialSkin.Controls.MaterialTextBox txtTaiKhoan;
        private MaterialSkin.Controls.MaterialTextBox txtMatKhau;
        private MaterialSkin.Controls.MaterialTextBox txtChucVu;
        private MaterialSkin.Controls.MaterialTextBox txtLuongCoBan;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnXoa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cboThang = new MaterialSkin.Controls.MaterialComboBox();
            this.cboNam = new MaterialSkin.Controls.MaterialComboBox();
            this.btnTinhLuong = new MaterialSkin.Controls.MaterialButton();
            this.dgvLuong = new System.Windows.Forms.DataGridView();

            // Khởi tạo các control mới
            this.txtTenNV = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTaiKhoan = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMatKhau = new MaterialSkin.Controls.MaterialTextBox();
            this.txtChucVu = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLuongCoBan = new MaterialSkin.Controls.MaterialTextBox();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.SuspendLayout();

            // 1. Khu vực TÍNH LƯƠNG (Phía trên)
            this.materialLabel1.Text = "Tháng";
            this.materialLabel1.Location = new System.Drawing.Point(40, 80);

            this.cboThang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            this.cboThang.Location = new System.Drawing.Point(100, 70);
            this.cboThang.Size = new System.Drawing.Size(100, 49);

            this.materialLabel2.Text = "Năm";
            this.materialLabel2.Location = new System.Drawing.Point(220, 80);

            this.cboNam.Items.AddRange(new object[] { "2023", "2024", "2025", "2026" });
            this.cboNam.Location = new System.Drawing.Point(270, 70);
            this.cboNam.Size = new System.Drawing.Size(120, 49);

            this.btnTinhLuong.Text = "XEM LƯƠNG";
            this.btnTinhLuong.Location = new System.Drawing.Point(410, 75);
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);

            this.materialDivider1.Location = new System.Drawing.Point(0, 130);
            this.materialDivider1.Size = new System.Drawing.Size(950, 3);

            // 2. Khu vực NHẬP THÔNG TIN (Phía giữa)
            // Tên NV
            this.txtTenNV.Hint = "Tên nhân viên";
            this.txtTenNV.Location = new System.Drawing.Point(40, 150);
            this.txtTenNV.Size = new System.Drawing.Size(200, 50);

            // Tài khoản
            this.txtTaiKhoan.Hint = "Tài khoản";
            this.txtTaiKhoan.Location = new System.Drawing.Point(260, 150);
            this.txtTaiKhoan.Size = new System.Drawing.Size(150, 50);

            // Mật khẩu
            this.txtMatKhau.Hint = "Mật khẩu";
            this.txtMatKhau.Password = true;
            this.txtMatKhau.Location = new System.Drawing.Point(430, 150);
            this.txtMatKhau.Size = new System.Drawing.Size(150, 50);

            // Chức vụ
            this.txtChucVu.Hint = "Chức vụ";
            this.txtChucVu.Location = new System.Drawing.Point(600, 150);
            this.txtChucVu.Size = new System.Drawing.Size(130, 50);

            // Lương cơ bản
            this.txtLuongCoBan.Hint = "Lương CB";
            this.txtLuongCoBan.Location = new System.Drawing.Point(750, 150);
            this.txtLuongCoBan.Size = new System.Drawing.Size(130, 50);

            // Nút Thêm
            this.btnThem.Text = "THÊM MỚI";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.Location = new System.Drawing.Point(40, 215);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // Nút Xóa
            this.btnXoa.Text = "XÓA CHỌN";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnXoa.Location = new System.Drawing.Point(160, 215);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 3. Bảng dữ liệu (Phía dưới)
            this.dgvLuong.Location = new System.Drawing.Point(30, 270);
            this.dgvLuong.Size = new System.Drawing.Size(880, 250);
            this.dgvLuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Form settings
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtLuongCoBan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvLuong);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);

            this.Text = "Quản lý & Tính lương nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}