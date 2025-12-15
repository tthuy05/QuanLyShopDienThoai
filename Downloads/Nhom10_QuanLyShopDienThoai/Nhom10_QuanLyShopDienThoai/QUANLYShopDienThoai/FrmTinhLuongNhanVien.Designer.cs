namespace QUANLYShopDienThoai
{
    partial class FrmTinhLuongNhanVien
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cboThang;
        private MaterialSkin.Controls.MaterialComboBox cboNam;
        private MaterialSkin.Controls.MaterialButton btnTinhLuong;
        private System.Windows.Forms.DataGridView dgvLuong;

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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.SuspendLayout();

            // divider
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 120);
            this.materialDivider1.Size = new System.Drawing.Size(900, 3);

            // label tháng
            this.materialLabel1.Text = "Tháng";
            this.materialLabel1.Location = new System.Drawing.Point(40, 80);

            // combobox tháng
            this.cboThang.AutoResize = false;
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.Items.AddRange(new object[] {
                "1","2","3","4","5","6","7","8","9","10","11","12"});
            this.cboThang.Location = new System.Drawing.Point(100, 70);
            this.cboThang.Size = new System.Drawing.Size(120, 49);

            // label năm
            this.materialLabel2.Text = "Năm";
            this.materialLabel2.Location = new System.Drawing.Point(260, 80);

            // combobox năm
            this.cboNam.AutoResize = false;
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.Items.AddRange(new object[] {
                "2023","2024","2025","2026"});
            this.cboNam.Location = new System.Drawing.Point(310, 70);
            this.cboNam.Size = new System.Drawing.Size(140, 49);

            // button tính lương
            this.btnTinhLuong.Text = "TÍNH LƯƠNG";
            this.btnTinhLuong.HighEmphasis = true;
            this.btnTinhLuong.Location = new System.Drawing.Point(500, 75);
            this.btnTinhLuong.Size = new System.Drawing.Size(160, 36);
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);

            // datagridview
            this.dgvLuong.Location = new System.Drawing.Point(30, 150);
            this.dgvLuong.Size = new System.Drawing.Size(840, 360);
            this.dgvLuong.ReadOnly = true;
            this.dgvLuong.RowHeadersVisible = false;
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuong.BackgroundColor = System.Drawing.Color.White;

            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.dgvLuong);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Name = "FrmTinhLuongNhanVien";
            this.Text = "Tính lương nhân viên";
            this.Load += new System.EventHandler(this.FrmTinhLuongNhanVien_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
