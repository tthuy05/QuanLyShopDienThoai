namespace QUANLYShopDienThoai
{
    partial class frmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbSanPham = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDonGia = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtConLai = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbKhachHang = new MaterialSkin.Controls.MaterialComboBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnThanhToan = new MaterialSkin.Controls.MaterialButton();
            this.lblTong = new MaterialSkin.Controls.MaterialLabel();
            this.lblTongTien = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInHoaDon = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            resources.ApplyResources(this.materialDivider1, "materialDivider1");
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // cmbSanPham
            // 
            this.cmbSanPham.AutoResize = false;
            this.cmbSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSanPham.Depth = 0;
            this.cmbSanPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSanPham.DropDownHeight = 174;
            this.cmbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSanPham.DropDownWidth = 121;
            resources.ApplyResources(this.cmbSanPham, "cmbSanPham");
            this.cmbSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSanPham.FormattingEnabled = true;
            this.cmbSanPham.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSanPham.Name = "cmbSanPham";
            this.cmbSanPham.StartIndex = 0;
            this.cmbSanPham.SelectedIndexChanged += new System.EventHandler(this.cmbSanPham_SelectedIndexChanged);
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // txtDonGia
            // 
            this.txtDonGia.AnimateReadOnly = false;
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDonGia.Depth = 0;
            resources.ApplyResources(this.txtDonGia, "txtDonGia");
            this.txtDonGia.LeadingIcon = null;
            this.txtDonGia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // materialLabel4
            // 
            resources.ApplyResources(this.materialLabel4, "materialLabel4");
            this.materialLabel4.Depth = 0;
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            // 
            // txtConLai
            // 
            this.txtConLai.AnimateReadOnly = false;
            this.txtConLai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConLai.Depth = 0;
            resources.ApplyResources(this.txtConLai, "txtConLai");
            this.txtConLai.ForeColor = System.Drawing.Color.Red;
            this.txtConLai.LeadingIcon = null;
            this.txtConLai.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.ReadOnly = true;
            this.txtConLai.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            resources.ApplyResources(this.materialLabel5, "materialLabel5");
            this.materialLabel5.Depth = 0;
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            // 
            // numSL
            // 
            resources.ApplyResources(this.numSL, "numSL");
            this.numSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSL.Name = "numSL";
            this.numSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThem
            // 
            resources.ApplyResources(this.btnThem, "btnThem");
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = ((System.Drawing.Image)(resources.GetObject("btnThem.Icon")));
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // materialLabel6
            // 
            resources.ApplyResources(this.materialLabel6, "materialLabel6");
            this.materialLabel6.Depth = 0;
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.AutoResize = false;
            this.cmbKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbKhachHang.Depth = 0;
            this.cmbKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbKhachHang.DropDownHeight = 174;
            this.cmbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhachHang.DropDownWidth = 121;
            resources.ApplyResources(this.cmbKhachHang, "cmbKhachHang");
            this.cmbKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.StartIndex = 0;
            // 
            // dgvGioHang
            // 
            resources.ApplyResources(this.dgvGioHang, "dgvGioHang");
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGioHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGioHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGioHang.EnableHeadersVisualStyles = false;
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGioHang.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGioHang.RowTemplate.Height = 35;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnXoa
            // 
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = ((System.Drawing.Image)(resources.GetObject("btnXoa.Icon")));
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThanhToan
            // 
            resources.ApplyResources(this.btnThanhToan, "btnThanhToan");
            this.btnThanhToan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThanhToan.Depth = 0;
            this.btnThanhToan.HighEmphasis = true;
            this.btnThanhToan.Icon = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Icon")));
            this.btnThanhToan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThanhToan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThanhToan.UseAccentColor = false;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTong
            // 
            resources.ApplyResources(this.lblTong, "lblTong");
            this.lblTong.Depth = 0;
            this.lblTong.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTong.Name = "lblTong";
            this.lblTong.Click += new System.EventHandler(this.lblTong_Click);
            // 
            // lblTongTien
            // 
            resources.ApplyResources(this.lblTongTien, "lblTongTien");
            this.lblTongTien.Depth = 0;
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTongTien.Name = "lblTongTien";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnInHoaDon
            // 
            resources.ApplyResources(this.btnInHoaDon, "btnInHoaDon");
            this.btnInHoaDon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInHoaDon.Depth = 0;
            this.btnInHoaDon.HighEmphasis = true;
            this.btnInHoaDon.Icon = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.Icon")));
            this.btnInHoaDon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInHoaDon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInHoaDon.UseAccentColor = false;
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // frmBanHang
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.cmbKhachHang);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtConLai);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cmbSanPham);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmbSanPham;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtDonGia;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtConLai;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.NumericUpDown numSL;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox cmbKhachHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnThanhToan;
        private MaterialSkin.Controls.MaterialLabel lblTong;
        private MaterialSkin.Controls.MaterialLabel lblTongTien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnInHoaDon;
    }
}