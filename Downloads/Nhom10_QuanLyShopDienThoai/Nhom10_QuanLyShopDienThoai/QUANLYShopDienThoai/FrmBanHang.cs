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
            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.Cyan400,
                TextShade.WHITE
            );

            gioHang.Columns.Add("MaSP", typeof(int));
            gioHang.Columns.Add("TenSP", typeof(string));
            gioHang.Columns.Add("DonGia", typeof(decimal));
            gioHang.Columns.Add("SoLuong", typeof(int));
            gioHang.Columns.Add("ThanhTien", typeof(decimal));

            dgvGioHang.DataSource = gioHang;
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

            gioHang.RowChanged += (s, ev) => CapNhatTongTien();
            gioHang.RowDeleted += (s, ev) => CapNhatTongTien();

            LoadSanPham();
            LoadKhachHang();
            CapNhatTongTien();
        }

        private void LoadSanPham()
        {
            string sql = "SELECT MaSP, TenSP, GiaBan, SoLuongTon FROM SAN_PHAM WHERE SoLuongTon > 0";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            cmbSanPham.DataSource = dt;
            cmbSanPham.DisplayMember = "TenSP";
            cmbSanPham.ValueMember = "MaSP";
        }

        private void LoadKhachHang()
        {
            string sql = "SELECT MaKH, ISNULL(TenKH + ' - ' + CONVERT(varchar,SDT), '-- Khách lẻ --') AS TenKH FROM KHACH_HANG";
            DataTable dt = DatabaseHelper.GetDataTable(sql);

            DataRow dr = dt.NewRow();
            dr["MaKH"] = 0;
            dr["TenKH"] = "-- Khách lẻ --";
            dt.Rows.InsertAt(dr, 0);

            cmbKhachHang.DataSource = dt;
            cmbKhachHang.DisplayMember = "TenKH";
            cmbKhachHang.ValueMember = "MaKH";
        }

        private void cmbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSanPham.SelectedValue == null || !int.TryParse(cmbSanPham.SelectedValue.ToString(), out int maSP)) return;

            string sql = $"SELECT GiaBan, SoLuongTon FROM SAN_PHAM WHERE MaSP = {maSP}";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                txtDonGia.Text = Convert.ToDecimal(dt.Rows[0]["GiaBan"]).ToString("N0");
                txtConLai.Text = dt.Rows[0]["SoLuongTon"].ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbSanPham.SelectedValue == null) return;

            int maSP = (int)cmbSanPham.SelectedValue;
            string tenSP = cmbSanPham.Text;

            if (!decimal.TryParse(txtDonGia.Text.Replace(",", ""), out decimal donGia)) return;
            int slMua = (int)numSL.Value;

            if (!int.TryParse(txtConLai.Text, out int slTon)) return;

            if (slMua <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                return;
            }
            if (slMua > slTon)
            {
                MessageBox.Show("Không đủ hàng trong kho!");
                return;
            }

            DataRow[] rows = gioHang.Select($"MaSP = {maSP}");
            if (rows.Length > 0)
            {
                rows[0]["SoLuong"] = (int)rows[0]["SoLuong"] + slMua;
                rows[0]["ThanhTien"] = Convert.ToDecimal(rows[0]["SoLuong"]) * donGia;
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
            }
        }

        private void CapNhatTongTien()
        {
            decimal tong = 0;
            foreach (DataRow r in gioHang.Rows)
                tong += Convert.ToDecimal(r["ThanhTien"]);
            lblTongTien.Text = tong.ToString("#,##0") + " đ";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHang.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng!");
                return;
            }

            decimal tongTien = 0;
            foreach (DataRow r in gioHang.Rows)
                tongTien += Convert.ToDecimal(r["ThanhTien"]);

            int maKH = (cmbKhachHang.SelectedValue is int kh && kh > 0) ? kh : 1;
            int maHD = 0;

            try
            {
                string sqlHD = "INSERT INTO HOA_DON (MaNV, NgayBan, MaKH, TongTien) " +
                               "OUTPUT INSERTED.MaHD VALUES (@MaNV, GETDATE(), @MaKH, @Tong)";
                SqlParameter[] p = {
                    new SqlParameter("@MaNV", maNVHienTai),
                    new SqlParameter("@MaKH", maKH),
                    new SqlParameter("@Tong", tongTien)
                };

                maHD = (int)DatabaseHelper.ExecuteScalar(sqlHD, p);
                maHDVuaTao = maHD;

                foreach (DataRow r in gioHang.Rows)
                {
                    int maSP = (int)r["MaSP"];
                    int sl = (int)r["SoLuong"];
                    decimal gia = (decimal)r["DonGia"];

                    string sqlCT = "INSERT INTO CT_HOA_DON (MaHD, MaSP, SoLuong, DonGia) VALUES (@hd, @sp, @sl, @gia)";
                    DatabaseHelper.ExecuteNonQuery(sqlCT, new SqlParameter[] {
                        new SqlParameter("@hd", maHD),
                        new SqlParameter("@sp", maSP),
                        new SqlParameter("@sl", sl),
                        new SqlParameter("@gia", gia)
                    });

                    string sqlKho = "UPDATE SAN_PHAM SET SoLuongTon = SoLuongTon - @sl WHERE MaSP = @sp";
                    DatabaseHelper.ExecuteNonQuery(sqlKho, new SqlParameter[] {
                        new SqlParameter("@sl", sl),
                        new SqlParameter("@sp", maSP)
                    });
                }

                MessageBox.Show($"THANH TOÁN THÀNH CÔNG!\nMã hóa đơn: HD{maHD:0000}\nTổng tiền: {tongTien:#,##0} đ.\nBấm IN HÓA ĐƠN để in.");
                gioHang.Clear();
                CapNhatTongTien();
                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi CSDL: " + ex.Message);
                return;
            }
        }

        private void InHoaDon(int maHD)
        {
            if (maHD <= 0)
            {
                MessageBox.Show("Vui lòng thanh toán trước.");
                return;
            }

            try
            {
                string sqlInHD = $@"SELECT HD.MaHD, HD.NgayBan, HD.TongTien, 
                                    SP.TenSP, CT.SoLuong, CT.DonGia AS GiaBanSP, 
                                    (CT.SoLuong * CT.DonGia) AS ThanhTien, NV.TenNV
                                FROM HOA_DON HD
                                JOIN CT_HOA_DON CT ON HD.MaHD = CT.MaHD
                                JOIN SAN_PHAM SP ON CT.MaSP = SP.MaSP
                                JOIN NHAN_VIEN NV ON HD.MaNV = NV.MaNV
                                WHERE HD.MaHD = {maHD}";

                DataTable dtInHD = DatabaseHelper.GetDataTable(sqlInHD);
                dtInHD.TableName = "dtChiTietHD";

                if (dtInHD.Rows.Count > 0)
                {
                    rptHoaDon rpt = new rptHoaDon();
                    rpt.SetDataSource(dtInHD);

                    FrmInBaoCao fIn = new FrmInBaoCao();
                    fIn.Text = $"Hóa đơn - HD{maHD:0000}";
                    fIn.crystalReportViewer1.ReportSource = rpt;
                    fIn.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu hóa đơn này!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi báo cáo: " + ex.Message);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            InHoaDon(maHDVuaTao);
        }
    }
}
