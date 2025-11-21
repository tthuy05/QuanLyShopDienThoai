using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QUANLYShopDienThoai
{
    public partial class FrmSanPham : Form
    {

        // Biến này lưu đường dẫn file ảnh gốc mà người dùng vừa chọn
        string duongDanAnhGoc = "";

        public FrmSanPham()
        {
            InitializeComponent();
        }

        // 1. Khi Form mở lên thì load dữ liệu
        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            SetupInterface();
        }

        // Hàm load dữ liệu từ SQL lên lưới
        private void LoadData()
        {
            string sql = "SELECT * FROM SAN_PHAM";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            dgvSanPham.DataSource = dt;
        }

        // Hàm cài đặt giao diện (đặt tên cột, khóa nút)
        private void SetupInterface()
        {
            if (dgvSanPham.Columns.Count > 0)
            {
                dgvSanPham.Columns["MaSP"].HeaderText = "Mã SP";
                dgvSanPham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
                dgvSanPham.Columns["GiaBan"].HeaderText = "Giá Bán";
                dgvSanPham.Columns["SoLuongTon"].HeaderText = "Số Lượng";

                // Định dạng tiền tệ (VD: 20,000,000)
                dgvSanPham.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
                dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            // Khóa ô Mã SP (Vì ID tự tăng trong SQL)
            txtMaSP.ReadOnly = true;

            // Mặc định khóa nút Sửa/Xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        // 2. Sự kiện Click vào bảng -> Đổ dữ liệu lên các ô nhập
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();

                // Xử lý giá (xóa dấu phẩy nếu có)
                string gia = row.Cells["GiaBan"].Value.ToString();
                txtGiaBan.Text = gia.Replace(",", "").Replace(".", "");

                txtSoLuong.Text = row.Cells["SoLuongTon"].Value.ToString();

                // Điều khiển nút
                btnThem.Enabled = false; // Đang chọn hàng cũ thì không cho Thêm
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        // 3. Nút LÀM MỚI (Reset form)
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            txtTimKiem.Clear();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            LoadData(); // Tải lại bảng gốc
            txtTenSP.Focus();
        }

        // 4. Nút THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtGiaBan.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên và Giá sản phẩm!");
                return;
            }

            

            string tenFileAnh = ""; // Mặc định là rỗng nếu không chọn ảnh

            // --- XỬ LÝ ẢNH ---
            if (!string.IsNullOrEmpty(duongDanAnhGoc))
            {
                // 1. Lấy tên file gốc (VD: iphone15.jpg)
                string tenGoc = System.IO.Path.GetFileName(duongDanAnhGoc);

                // 2. Tạo tên file mới (Thêm thời gian vào để tránh trùng tên với ảnh cũ)
                // VD: 638350_iphone15.jpg
                tenFileAnh = DateTime.Now.Ticks.ToString() + "_" + tenGoc;

                // 3. Xác định đường dẫn đích (Thư mục Images trong project)
                string thuMucDich = System.IO.Path.Combine(Application.StartupPath, "Images");

                // Tạo thư mục nếu chưa có
                if (!System.IO.Directory.Exists(thuMucDich))
                    System.IO.Directory.CreateDirectory(thuMucDich);

                // 4. Đường dẫn lưu file cuối cùng
                string duongDanDich = System.IO.Path.Combine(thuMucDich, tenFileAnh);

                // 5. COPY FILE (Từ Desktop -> Vào thư mục Project)
                try
                {
                    System.IO.File.Copy(duongDanAnhGoc, duongDanDich, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu ảnh: " + ex.Message);
                    return;
                }
            }
            // -----------------

            // CÂU LỆNH SQL (Thêm cột HinhAnh)
            string sql = "INSERT INTO SAN_PHAM (TenSP, GiaBan, SoLuongTon, HinhAnh) VALUES (@Ten, @Gia, @SL, @Hinh)";
            SqlParameter[] p = {
                new SqlParameter("@Ten", txtTenSP.Text),
                new SqlParameter("@Gia", decimal.Parse(txtGiaBan.Text)),
                new SqlParameter("@SL", int.Parse(txtSoLuong.Text)),
                new SqlParameter("@Hinh", tenFileAnh) // Chỉ lưu cái tên ngắn gọn vào SQL
            };

            DatabaseHelper.ExecuteNonQuery(sql, p);
            MessageBox.Show("Thêm thành công!");
            btnLamMoi_Click(sender, e); // Reset sau khi thêm
        }

        // 5. Nút SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            // --- 1. XỬ LÝ TÊN ẢNH CẦN LƯU ---
            string tenAnhCapNhat = "";

            // Trường hợp A: Người dùng có chọn ảnh mới (biến duongDanAnhGoc có dữ liệu)
            if (!string.IsNullOrEmpty(duongDanAnhGoc))
            {
                // Copy ảnh mới vào thư mục dự án (Giống hệt nút Thêm)
                string thuMucImages = System.IO.Path.Combine(Application.StartupPath, "Images");
                if (!System.IO.Directory.Exists(thuMucImages)) System.IO.Directory.CreateDirectory(thuMucImages);

                string tenFileGoc = System.IO.Path.GetFileName(duongDanAnhGoc);
                tenAnhCapNhat = DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_" + tenFileGoc;
                string duongDanDich = System.IO.Path.Combine(thuMucImages, tenAnhCapNhat);

                try
                {
                    System.IO.File.Copy(duongDanAnhGoc, duongDanDich, true);
                }
                catch { }
            }
            else
            {
                // Trường hợp B: Người dùng KHÔNG chọn ảnh mới -> Giữ nguyên ảnh cũ
                // Lấy tên ảnh cũ từ dòng đang chọn trong bảng
                if (dgvSanPham.CurrentRow != null)
                {
                    var val = dgvSanPham.CurrentRow.Cells["HinhAnh"].Value;
                    tenAnhCapNhat = (val != null) ? val.ToString() : "";
                }
            }

            // --- 2. CÂU LỆNH SQL (ĐÃ BỔ SUNG HinhAnh=@Hinh) ---
            string sql = "UPDATE SAN_PHAM SET TenSP=@Ten, GiaBan=@Gia, SoLuongTon=@SL, HinhAnh=@Hinh WHERE MaSP=@ID";

            SqlParameter[] p = {
            new SqlParameter("@Ten", txtTenSP.Text),
            new SqlParameter("@Gia", decimal.Parse(txtGiaBan.Text)),
            new SqlParameter("@SL", int.Parse(txtSoLuong.Text)),
            new SqlParameter("@Hinh", tenAnhCapNhat), // Quan trọng: Cập nhật cột HinhAnh
            new SqlParameter("@ID", txtMaSP.Text)
        };

            DatabaseHelper.ExecuteNonQuery(sql, p);
            MessageBox.Show("Cập nhật thành công!");

            // Reset lại biến đường dẫn để tránh lỗi cho lần sau
            duongDanAnhGoc = "";

            btnLamMoi_Click(sender, e); // Load lại bảng để thấy ảnh mới ngay lập tức
        }

        // 6. Nút XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "") return;

            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sql = "DELETE FROM SAN_PHAM WHERE MaSP=@ID";
                SqlParameter[] p = { new SqlParameter("@ID", txtMaSP.Text) };

                DatabaseHelper.ExecuteNonQuery(sql, p);
                MessageBox.Show("Đã xóa sản phẩm!");
                btnLamMoi_Click(sender, e);
            }
        }

        // 7. Nút TÌM KIẾM
        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            string sql = $"SELECT * FROM SAN_PHAM WHERE TenSP LIKE N'%{tuKhoa}%'";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            dgvSanPham.DataSource = dt;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }


        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // Chỉ cho phép chọn các đuôi file ảnh chuẩn
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            open.Title = "Chọn ảnh sản phẩm";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // 1. Giải phóng ảnh cũ nếu đang có (để tiết kiệm bộ nhớ)
                if (picHinhAnh.Image != null)
                {
                    picHinhAnh.Image.Dispose();
                    picHinhAnh.Image = null;
                }

                // 2. Lưu đường dẫn
                duongDanAnhGoc = open.FileName;

                // 3. Load ảnh bằng hàm an toàn (Thay vì Image.FromFile)
                Image img = LoadAnhAnToan(duongDanAnhGoc);

                if (img != null)
                {
                    picHinhAnh.Image = img;
                }
                else
                {
                    MessageBox.Show("File ảnh bị lỗi hoặc định dạng không hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm đọc ảnh an toàn, tránh lỗi OutOfMemory và khóa file
        private Image LoadAnhAnToan(string duongDan)
        {
            try
            {
                if (string.IsNullOrEmpty(duongDan) || !System.IO.File.Exists(duongDan))
                    return null;

                // Đọc file vào bộ nhớ đệm (byte array) trước
                byte[] buffer = System.IO.File.ReadAllBytes(duongDan);

                // Tạo MemoryStream từ bộ nhớ đệm
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(buffer))
                {
                    // Tạo ảnh từ dòng dữ liệu này
                    return Image.FromStream(ms);
                }
            }
            catch (Exception)
            {
                // Nếu file lỗi thì trả về null (không crash phần mềm)
                return null;
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                // 1. Đổ dữ liệu chữ (Tên, Giá...)
                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();

                string gia = row.Cells["GiaBan"].Value.ToString();
                txtGiaBan.Text = gia.Replace(",", "").Replace(".", "");

                txtSoLuong.Text = row.Cells["SoLuongTon"].Value.ToString();

                // --- 2. ĐOẠN CODE HIỂN THỊ ẢNH (BẠN KIỂM TRA XEM CÓ CHƯA) ---
                // Lấy tên file ảnh từ cột HinhAnh
                var cellHinhAnh = row.Cells["HinhAnh"].Value;
                string tenAnh = (cellHinhAnh != null) ? cellHinhAnh.ToString() : "";

                if (!string.IsNullOrEmpty(tenAnh))
                {
                    // Đường dẫn: bin\Debug\Images\ten_anh.jpg
                    string duongDan = System.IO.Path.Combine(Application.StartupPath, "Images", tenAnh);

                    if (System.IO.File.Exists(duongDan))
                    {
                        picHinhAnh.Image = Image.FromFile(duongDan);
                    }
                    else
                    {
                        picHinhAnh.Image = null; // Có tên nhưng mất file
                    }
                }
                else
                {
                    picHinhAnh.Image = null; // Cột HinhAnh bị rỗng
                }
                // -----------------------------------------------------------

                // Điều khiển nút
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}