namespace QUANLYShopDienThoai
{
    partial class frmTimKiemHD
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox grpThongTinHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DataGridView dgvCTHD;

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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.grpThongTinHD = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.grpThongTinHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã hóa đơn:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(160, 18);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(150, 22);
            this.txtMaHD.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTim.Location = new System.Drawing.Point(330, 15);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(101, 28);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // grpThongTinHD
            // 
            this.grpThongTinHD.Controls.Add(this.label2);
            this.grpThongTinHD.Controls.Add(this.txtNgay);
            this.grpThongTinHD.Controls.Add(this.label3);
            this.grpThongTinHD.Controls.Add(this.txtKhachHang);
            this.grpThongTinHD.Controls.Add(this.label4);
            this.grpThongTinHD.Controls.Add(this.txtNhanVien);
            this.grpThongTinHD.Controls.Add(this.label5);
            this.grpThongTinHD.Controls.Add(this.txtTongTien);
            this.grpThongTinHD.Location = new System.Drawing.Point(30, 60);
            this.grpThongTinHD.Name = "grpThongTinHD";
            this.grpThongTinHD.Size = new System.Drawing.Size(500, 150);
            this.grpThongTinHD.TabIndex = 3;
            this.grpThongTinHD.TabStop = false;
            this.grpThongTinHD.Text = "Thông tin hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày bán:";
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(120, 27);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.ReadOnly = true;
            this.txtNgay.Size = new System.Drawing.Size(300, 22);
            this.txtNgay.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách hàng:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(120, 62);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.ReadOnly = true;
            this.txtKhachHang.Size = new System.Drawing.Size(300, 22);
            this.txtKhachHang.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhân viên:";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(120, 97);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(300, 22);
            this.txtNhanVien.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(120, 132);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(150, 22);
            this.txtTongTien.TabIndex = 7;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.ColumnHeadersHeight = 29;
            this.dgvCTHD.Location = new System.Drawing.Point(30, 230);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.Size = new System.Drawing.Size(730, 200);
            this.dgvCTHD.TabIndex = 4;
            // 
            // frmTimKiemHD
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.grpThongTinHD);
            this.Controls.Add(this.dgvCTHD);
            this.Name = "frmTimKiemHD";
            this.Text = "TÌM KIẾM HÓA ĐƠN";
            this.grpThongTinHD.ResumeLayout(false);
            this.grpThongTinHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
