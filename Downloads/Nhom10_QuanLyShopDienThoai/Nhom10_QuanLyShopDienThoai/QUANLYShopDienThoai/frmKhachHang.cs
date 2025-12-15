using System;
using System.Data;
using System.Windows.Forms;

namespace QUANLYShopDienThoai
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void LoadKH()
        {
            string sql = "SELECT * FROM KHACH_HANG ORDER BY MaKH DESC";
            dgvKH.DataSource = DatabaseHelper.GetDataTable(sql);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();

            if (ten == "" || sdt == "")
                return;

            string sql = $@"
                INSERT INTO KHACH_HANG (TenKH, SDT, DiaChi)
                VALUES (N'{ten}', '{sdt}', N'{diachi}')
            ";

            DatabaseHelper.ExecuteNonQuery(sql);
            LoadKH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count == 0)
                return;

            string ma = dgvKH.SelectedRows[0].Cells["MaKH"].Value.ToString();
            string ten = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();

            string sql = $@"
                UPDATE KHACH_HANG
                SET TenKH = N'{ten}', SDT = '{sdt}', DiaChi = N'{diachi}'
                WHERE MaKH = {ma}
            ";

            DatabaseHelper.ExecuteNonQuery(sql);
            LoadKH();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtTenKH.Text = dgvKH.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
            txtSDT.Text = dgvKH.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dgvKH.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
        }
    }
}
