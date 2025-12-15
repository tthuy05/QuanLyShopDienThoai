namespace QUANLYShopDienThoai
{
    partial class FrmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.cardInput = new MaterialSkin.Controls.MaterialCard();
            this.flowLayoutPanelActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnLamMoi = new MaterialSkin.Controls.MaterialButton();
            this.txtSoLuong = new MaterialSkin.Controls.MaterialTextBox();
            this.lblSoLuong = new MaterialSkin.Controls.MaterialLabel();
            this.txtGiaBan = new MaterialSkin.Controls.MaterialTextBox();
            this.lblGiaBan = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenSP = new MaterialSkin.Controls.MaterialTextBox();
            this.lblSanPham = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaSP = new MaterialSkin.Controls.MaterialTextBox();
            this.lblMaSP = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitleInput = new MaterialSkin.Controls.MaterialLabel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnMain = new MaterialSkin.Controls.MaterialButton();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.cardInput.SuspendLayout();
            this.flowLayoutPanelActions.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelLeft, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelRight, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1094, 633);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeft.Controls.Add(this.cardInput);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10);
            this.panelLeft.Size = new System.Drawing.Size(350, 633);
            this.panelLeft.TabIndex = 0;
            // 
            // cardInput
            // 
            this.cardInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardInput.Controls.Add(this.flowLayoutPanelActions);
            this.cardInput.Controls.Add(this.txtSoLuong);
            this.cardInput.Controls.Add(this.lblSoLuong);
            this.cardInput.Controls.Add(this.txtGiaBan);
            this.cardInput.Controls.Add(this.lblGiaBan);
            this.cardInput.Controls.Add(this.txtTenSP);
            this.cardInput.Controls.Add(this.lblSanPham);
            this.cardInput.Controls.Add(this.txtMaSP);
            this.cardInput.Controls.Add(this.lblMaSP);
            this.cardInput.Controls.Add(this.lblTitleInput);
            this.cardInput.Depth = 0;
            this.cardInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardInput.Location = new System.Drawing.Point(10, 10);
            this.cardInput.Margin = new System.Windows.Forms.Padding(14);
            this.cardInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardInput.Name = "cardInput";
            this.cardInput.Padding = new System.Windows.Forms.Padding(14);
            this.cardInput.Size = new System.Drawing.Size(330, 613);
            this.cardInput.TabIndex = 0;
            // 
            // flowLayoutPanelActions
            // 
            this.flowLayoutPanelActions.Controls.Add(this.btnThem);
            this.flowLayoutPanelActions.Controls.Add(this.btnSua);
            this.flowLayoutPanelActions.Controls.Add(this.btnXoa);
            this.flowLayoutPanelActions.Controls.Add(this.btnLamMoi);
            this.flowLayoutPanelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelActions.Location = new System.Drawing.Point(14, 469);
            this.flowLayoutPanelActions.Name = "flowLayoutPanelActions";
            this.flowLayoutPanelActions.Size = new System.Drawing.Size(302, 130);
            this.flowLayoutPanelActions.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = ((System.Drawing.Image)(resources.GetObject("btnThem.Icon")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(4, 6);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThem.Size = new System.Drawing.Size(135, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = false;
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSua.Depth = 0;
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = ((System.Drawing.Image)(resources.GetObject("btnSua.Icon")));
            this.btnSua.Location = new System.Drawing.Point(147, 6);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(135, 45);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "SỬA";
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = false;
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = ((System.Drawing.Image)(resources.GetObject("btnXoa.Icon")));
            this.btnXoa.Location = new System.Drawing.Point(4, 63);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(135, 45);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = true;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AutoSize = false;
            this.btnLamMoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLamMoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLamMoi.Depth = 0;
            this.btnLamMoi.HighEmphasis = true;
            this.btnLamMoi.Icon = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Icon")));
            this.btnLamMoi.Location = new System.Drawing.Point(147, 63);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLamMoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLamMoi.Size = new System.Drawing.Size(135, 45);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnLamMoi.UseAccentColor = false;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.AnimateReadOnly = false;
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuong.Depth = 0;
            this.txtSoLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSoLuong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoLuong.LeadingIcon = null;
            this.txtSoLuong.Location = new System.Drawing.Point(14, 269);
            this.txtSoLuong.MaxLength = 50;
            this.txtSoLuong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoLuong.Multiline = false;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(302, 50);
            this.txtSoLuong.TabIndex = 8;
            this.txtSoLuong.Text = "";
            this.txtSoLuong.TrailingIcon = null;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Depth = 0;
            this.lblSoLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSoLuong.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSoLuong.Location = new System.Drawing.Point(14, 250);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblSoLuong.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblSoLuong.Size = new System.Drawing.Size(69, 19);
            this.lblSoLuong.TabIndex = 7;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.AnimateReadOnly = false;
            this.txtGiaBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaBan.Depth = 0;
            this.txtGiaBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGiaBan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGiaBan.LeadingIcon = null;
            this.txtGiaBan.Location = new System.Drawing.Point(14, 200);
            this.txtGiaBan.MaxLength = 50;
            this.txtGiaBan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGiaBan.Multiline = false;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(302, 50);
            this.txtGiaBan.TabIndex = 6;
            this.txtGiaBan.Text = "";
            this.txtGiaBan.TrailingIcon = null;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Depth = 0;
            this.lblGiaBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGiaBan.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGiaBan.Location = new System.Drawing.Point(14, 181);
            this.lblGiaBan.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblGiaBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblGiaBan.Size = new System.Drawing.Size(60, 19);
            this.lblGiaBan.TabIndex = 5;
            this.lblGiaBan.Text = "Giá bán:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.AnimateReadOnly = false;
            this.txtTenSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenSP.Depth = 0;
            this.txtTenSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenSP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenSP.LeadingIcon = null;
            this.txtTenSP.Location = new System.Drawing.Point(14, 131);
            this.txtTenSP.MaxLength = 50;
            this.txtTenSP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenSP.Multiline = false;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(302, 50);
            this.txtTenSP.TabIndex = 4;
            this.txtTenSP.Text = "";
            this.txtTenSP.TrailingIcon = null;
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Depth = 0;
            this.lblSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSanPham.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSanPham.Location = new System.Drawing.Point(14, 112);
            this.lblSanPham.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblSanPham.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblSanPham.Size = new System.Drawing.Size(107, 19);
            this.lblSanPham.TabIndex = 3;
            this.lblSanPham.Text = "Tên sản phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.AnimateReadOnly = false;
            this.txtMaSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaSP.Depth = 0;
            this.txtMaSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaSP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaSP.LeadingIcon = null;
            this.txtMaSP.Location = new System.Drawing.Point(14, 62);
            this.txtMaSP.MaxLength = 50;
            this.txtMaSP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaSP.Multiline = false;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(302, 50);
            this.txtMaSP.TabIndex = 2;
            this.txtMaSP.Text = "";
            this.txtMaSP.TrailingIcon = null;
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Depth = 0;
            this.lblMaSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaSP.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMaSP.Location = new System.Drawing.Point(14, 43);
            this.lblMaSP.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblMaSP.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblMaSP.Size = new System.Drawing.Size(52, 19);
            this.lblMaSP.TabIndex = 1;
            this.lblMaSP.Text = "Mã SP:";
            // 
            // lblTitleInput
            // 
            this.lblTitleInput.AutoSize = true;
            this.lblTitleInput.Depth = 0;
            this.lblTitleInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleInput.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitleInput.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTitleInput.Location = new System.Drawing.Point(14, 14);
            this.lblTitleInput.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblTitleInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitleInput.Name = "lblTitleInput";
            this.lblTitleInput.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblTitleInput.Size = new System.Drawing.Size(180, 29);
            this.lblTitleInput.TabIndex = 0;
            this.lblTitleInput.Text = "Thông tin chi tiết";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.dgvSanPham);
            this.panelRight.Controls.Add(this.panelSearch);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(350, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panelRight.Size = new System.Drawing.Size(744, 633);
            this.panelRight.TabIndex = 1;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.ColumnHeadersHeight = 50;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.Location = new System.Drawing.Point(10, 90);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSanPham.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.RowTemplate.Height = 40;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(724, 533);
            this.dgvSanPham.TabIndex = 1;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnMain);
            this.panelSearch.Controls.Add(this.btnTimKiem);
            this.panelSearch.Controls.Add(this.txtTimKiem);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(10, 20);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(724, 70);
            this.panelSearch.TabIndex = 0;
            // 
            // btnMain
            // 
            this.btnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMain.AutoSize = false;
            this.btnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMain.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMain.Depth = 0;
            this.btnMain.HighEmphasis = true;
            this.btnMain.Icon = ((System.Drawing.Image)(resources.GetObject("btnMain.Icon")));
            this.btnMain.Location = new System.Drawing.Point(571, 6);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMain.Name = "btnMain";
            this.btnMain.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMain.Size = new System.Drawing.Size(127, 50);
            this.btnMain.TabIndex = 2;
            this.btnMain.Text = "MENU";
            this.btnMain.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnMain.UseAccentColor = false;
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = false;
            this.btnTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiem.Depth = 0;
            this.btnTimKiem.HighEmphasis = true;
            this.btnTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Icon")));
            this.btnTimKiem.Location = new System.Drawing.Point(400, 5);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(100, 50);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "TÌM";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AnimateReadOnly = false;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Depth = 0;
            this.txtTimKiem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimKiem.Hint = "Nhập tên sản phẩm cần tìm...";
            this.txtTimKiem.LeadingIcon = null;
            this.txtTimKiem.Location = new System.Drawing.Point(0, 5);
            this.txtTimKiem.MaxLength = 50;
            this.txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(390, 50);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "";
            this.txtTimKiem.TrailingIcon = null;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmSanPham";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.cardInput.ResumeLayout(false);
            this.cardInput.PerformLayout();
            this.flowLayoutPanelActions.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private MaterialSkin.Controls.MaterialCard cardInput;
        private MaterialSkin.Controls.MaterialLabel lblTitleInput;
        private MaterialSkin.Controls.MaterialTextBox txtMaSP;
        private MaterialSkin.Controls.MaterialLabel lblMaSP;
        private MaterialSkin.Controls.MaterialTextBox txtSoLuong;
        private MaterialSkin.Controls.MaterialLabel lblSoLuong;
        private MaterialSkin.Controls.MaterialTextBox txtGiaBan;
        private MaterialSkin.Controls.MaterialLabel lblGiaBan;
        private MaterialSkin.Controls.MaterialTextBox txtTenSP;
        private MaterialSkin.Controls.MaterialLabel lblSanPham;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelActions;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnLamMoi;
        private System.Windows.Forms.Panel panelSearch;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialButton btnMain;
        private System.Windows.Forms.DataGridView dgvSanPham;
    }
}