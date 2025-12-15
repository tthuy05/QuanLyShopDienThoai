using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace QUANLYShopDienThoai
{
    public partial class frmBanHang : MaterialForm
    {
        DataTable gioHang = new DataTable();
        DataTable dtSanPham = new DataTable();
        int maNVHienTai = 1;
        private int maHDVuaTao = 0;

        public frmBanHang(int maNV = 1)
        {
            InitializeComponent();
            maNVHienTai = maNV;
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Cyan400, TextShade.WHITE);

            if (gioHang.Columns.Count == 0)
            {
                gioHang.Columns.Add("MaSP", typeof(int));
                gioHang.Columns.Add("TenSP", typeof(string));
                gioHang.Columns.Add("DonGia", typeof(decimal));
                gioHang.Columns.Add("SoLuong", typeof(int));
                gioHang.Columns.Add("ThanhTien", typeof(decimal));
            }

            dgvGioHang.DataSource = gioHang;
            CauHinhGridView();

            gioHang.RowChanged += (s, ev) => CapNhatTongTien();
            gioHang.RowDeleted += (s, ev) => CapNhatTongTien();

            LoadKhachHang();
            LoadSanPham();
            CapNhatTongTien();
        }

        private void CauHinhGridView()
        {
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.AllowUserToResizeColumns = true;
            dgvGioHang.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            dgvGioHang.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvGioHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGioHang.EnableHeadersVisualStyles = false;

            dgvGioHang.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgvGioHang.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            dgvGioHang.Columns["ThanhTien"].DefaultCellStyle.ForeColor = Color.Red;
            dgvGioHang.Columns["ThanhTien"].DefaultCellStyle.Font = new Font(dgvGioHang.Font, FontStyle.Bold);
        }

        private void LoadKhachHang()
        {
            try
            {
                string sql = "SELECT MaKH, TenKH + ' - ' + SDT AS HienThi FROM KHACH_HANG";
                DataTable dt = DatabaseHelper.GetDataTable(sql);

                cmbKhachHang.DataSource = dt;
                cmbKhachHang.DisplayMember = "HienThi"; 
                cmbKhachHang.ValueMember = "MaKH";     
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải khách hàng: " + ex.Message);
            }
        }

        private void LoadSanPham()
        {
            try
            {
                this.cmbSanPham.SelectedIndexChanged -= new EventHandler(cmbSanPham_SelectedIndexChanged);

                string sql = "SELECT MaSP, TenSP, GiaBan, SoLuongTon FROM SAN_PHAM WHERE SoLuongTon > 0";
                dtSanPham = DatabaseHelper.GetDataTable(sql);

                cmbSanPham.DataSource = dtSanPham;
                cmbSanPham.DisplayMember = "TenSP";
                cmbSanPham.ValueMember = "MaSP";

                this.cmbSanPham.SelectedIndexChanged += new EventHandler(cmbSanPham_SelectedIndexChanged);

                if (cmbSanPham.Items.Count > 0)
                {
                    cmbSanPham.SelectedIndex = 0;
                    HienThiThongTinSanPham();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sản phẩm: " + ex.Message);
            }
        }

        private void cmbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiThongTinSanPham();
        }

        private void HienThiThongTinSanPham()
        {
            try
            {
                if (cmbSanPham.SelectedIndex == -1 || cmbSanPham.SelectedItem == null) return;

                // Lấy DataRowView từ dòng đang chọn (An toàn nhất)
                DataRowView drv = cmbSanPham.SelectedItem as DataRowView;
                if (drv != null)
                {
                    decimal gia = Convert.ToDecimal(drv["GiaBan"]);
                    int ton = Convert.ToInt32(drv["SoLuongTon"]);

                    txtDonGia.Text = gia.ToString("N0");
                    txtConLai.Text = ton.ToString();

                    txtDonGia.Refresh();
                    txtConLai.Refresh();
                }
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbSanPham.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn sản phẩm!"); return; }

            int maSP = 0;
            if (cmbSanPham.SelectedValue is int) maSP = (int)cmbSanPham.SelectedValue;
            else int.TryParse(cmbSanPham.SelectedValue.ToString(), out maSP);

            string tenSP = cmbSanPham.Text;

            if (!decimal.TryParse(txtDonGia.Text.Replace(",", "").Replace(".", ""), out decimal donGia)) return;

            int slMua = (int)numSL.Value;
            int.TryParse(txtConLai.Text, out int slTon);

            if (slMua <= 0) { MessageBox.Show("Số lượng > 0!"); return; }
            if (slMua > slTon) { MessageBox.Show("Kho không đủ hàng!"); return; }

            DataRow[] rows = gioHang.Select($"MaSP = {maSP}");
            if (rows.Length > 0)
            {
                int slMoi = (int)rows[0]["SoLuong"] + slMua;
                if (slMoi > slTon) { MessageBox.Show("Vượt quá tồn kho!"); return; }
                rows[0]["SoLuong"] = slMoi;
                rows[0]["ThanhTien"] = slMoi * donGia;
            }
            else
            {
                gioHang.Rows.Add(maSP, tenSP, donGia, slMua, donGia * slMua);
            }
            CapNhatTongTien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.SelectedRows.Count > 0 && !dgvGioHang.SelectedRows[0].IsNewRow)
            {
                gioHang.Rows.RemoveAt(dgvGioHang.SelectedRows[0].Index);
                CapNhatTongTien();
            }
        }

        private void CapNhatTongTien()
        {
            decimal tong = 0;
            foreach (DataRow r in gioHang.Rows)
            {
                if (r.RowState != DataRowState.Deleted)
                    tong += Convert.ToDecimal(r["ThanhTien"]);
            }
            lblTongTien.Text = tong.ToString("#,##0") + " đ";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHang.Rows.Count == 0) { MessageBox.Show("Giỏ hàng trống!"); return; }

            if (cmbKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Dữ liệu khách hàng không hợp lệ!");
                return;
            }

            if (MessageBox.Show("Xác nhận thanh toán?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No) return;

            decimal tongTien = 0;
            foreach (DataRow r in gioHang.Rows) tongTien += Convert.ToDecimal(r["ThanhTien"]);

            int maKH = Convert.ToInt32(cmbKhachHang.SelectedValue);

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    string sqlHD = "INSERT INTO HOA_DON (MaNV, NgayBan, MaKH, TongTien) OUTPUT INSERTED.MaHD VALUES (@MaNV, GETDATE(), @MaKH, @Tong)";
                    SqlCommand cmd = new SqlCommand(sqlHD, conn, tran);
                    cmd.Parameters.AddWithValue("@MaNV", maNVHienTai);
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@Tong", tongTien);

                    maHDVuaTao = (int)cmd.ExecuteScalar();

                    foreach (DataRow r in gioHang.Rows)
                    {
                        string sqlCT = "INSERT INTO CT_HOA_DON (MaHD, MaSP, SoLuong, DonGia) VALUES (@hd, @sp, @sl, @gia)";
                        SqlCommand cmdCT = new SqlCommand(sqlCT, conn, tran);
                        cmdCT.Parameters.AddWithValue("@hd", maHDVuaTao);
                        cmdCT.Parameters.AddWithValue("@sp", r["MaSP"]);
                        cmdCT.Parameters.AddWithValue("@sl", r["SoLuong"]);
                        cmdCT.Parameters.AddWithValue("@gia", r["DonGia"]);
                        cmdCT.ExecuteNonQuery();

                        string sqlKho = "UPDATE SAN_PHAM SET SoLuongTon = SoLuongTon - @sl WHERE MaSP = @sp";
                        SqlCommand cmdKho = new SqlCommand(sqlKho, conn, tran);
                        cmdKho.Parameters.AddWithValue("@sl", r["SoLuong"]);
                        cmdKho.Parameters.AddWithValue("@sp", r["MaSP"]);
                        cmdKho.ExecuteNonQuery();
                    }

                    tran.Commit();
                    MessageBox.Show($"Thanh toán thành công! Mã HĐ: {maHDVuaTao}");

                    // Reset
                    gioHang.Clear();
                    CapNhatTongTien();
                    LoadSanPham();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi thanh toán: " + ex.Message);
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (maHDVuaTao <= 0) { MessageBox.Show("Chưa có hóa đơn vừa tạo!"); return; }
            try
            {
                string sql = $@"SELECT HD.MaHD, HD.NgayBan, HD.TongTien, SP.TenSP, CT.SoLuong, CT.DonGia AS GiaBanSP, (CT.SoLuong*CT.DonGia) AS ThanhTien, NV.TenNV 
                                FROM HOA_DON HD JOIN CT_HOA_DON CT ON HD.MaHD=CT.MaHD JOIN SAN_PHAM SP ON CT.MaSP=SP.MaSP JOIN NHAN_VIEN NV ON HD.MaNV=NV.MaNV 
                                WHERE HD.MaHD={maHDVuaTao}";
                DataTable dt = DatabaseHelper.GetDataTable(sql);

                dt.TableName = "dtChiTietHD";

                if (dt.Rows.Count > 0)
                {
                    rptHoaDon rpt = new rptHoaDon();
                    rpt.SetDataSource(dt);
                    FrmInBaoCao f = new FrmInBaoCao();
                    f.crystalReportViewer1.ReportSource = rpt;
                    f.ShowDialog();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi in: " + ex.Message); }
        }
    }
}