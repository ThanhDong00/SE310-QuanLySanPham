using QuanLySanPham.Controller;
using QuanLySanPham.Model;

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        private SanPhamController sanPhamController;

        public Form1()
        {
            InitializeComponent();
            sanPhamController = new SanPhamController();
            LoadData();
        }

        public void LoadData()
        {
            List<SanPham> sanPhams = sanPhamController.GetAllSanPham();
            dtgvAll.DataSource = sanPhams;
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham
            {
                MaSanPham = txbMaSP.Text,
                TenSanPham = txbTenSP.Text,
                SoLuong = int.Parse(txbSoLuong.Text),
                DonGia = decimal.Parse(txbDonGia.Text),
                XuatXu = txbXuatXu.Text,
                NgayHetHan = dtpkNgayHetHan.Value,
            };

            sanPhamController.AddSanPham(sanPham);

            txbMaSP.Text = string.Empty;
            txbTenSP.Text = string.Empty;
            txbSoLuong.Text = string.Empty;
            txbDonGia.Text = string.Empty;
            txbXuatXu.Text = string.Empty;
            dtpkNgayHetHan.Value = DateTime.Now;

            LoadData();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            string MaSP = txbMaSP.Text;

            bool isDeleted = sanPhamController.DeleteSanPham(MaSP);

            if (isDeleted)
            {
                MessageBox.Show("Xóa sản phẩm thành công!");

                txbMaSP.Text = String.Empty;
                LoadData();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm!");
            }
        }

        private void btnMaxPrice_Click(object sender, EventArgs e)
        {
            SanPham sp = sanPhamController.GetSanPhamCoDonGiaCaoNhat();

            if (sp != null)
            {
                List<SanPham> sanPhamMaxList = new List<SanPham> { sp };

                dtgvFind.DataSource = sanPhamMaxList;
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào.");
                dtgvFind.DataSource = null;
            }
        }

        private void btnJapanSP_Click(object sender, EventArgs e)
        {
            SanPham sanPham = sanPhamController.GetSanPhamXuatXuNhatBan();

            if (sanPham != null)
            {
                List<SanPham> SPNhatBanList = new List<SanPham> { sanPham };

                dtgvFind.DataSource = SPNhatBanList;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào xuất xứ Nhật Bản!");
                dtgvFind.DataSource = null;
            }
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            List<SanPham> sanPhamsQuaHan = sanPhamController.GetSanPhamQuaHan();

            if (sanPhamsQuaHan != null && sanPhamsQuaHan.Count > 0)
            {
                dtgvFind.DataSource = sanPhamsQuaHan;
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào đã quá hạn.");
                dtgvFind.DataSource = null;
            }
        }

        private void btnPriceFromTo_Click(object sender, EventArgs e)
        {
            if (txbMin.Text == "" || txbMax.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giới hạn đơn giá mà bạn muốn!");
                return;
            }

            List<SanPham> sanPhamsDonGia = sanPhamController.GetSanPhamCoDonGia(decimal.Parse(txbMin.Text), decimal.Parse(txbMax.Text));

            if (sanPhamsDonGia != null && sanPhamsDonGia.Count > 0)
            {
                dtgvFind.DataSource = sanPhamsDonGia;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào!");
                dtgvFind.DataSource = null;
            }
        }

        private void btnDeleteFrom_Click(object sender, EventArgs e)
        {
            string xuatXu = rtxbFrom.Text;

            bool isDeleted = sanPhamController.DeleteSanPhamsByXuatXu(xuatXu);

            if (isDeleted)
            {
                MessageBox.Show("Xóa sản phẩm có xuất xứ '" + xuatXu + "' thành công!");

                rtxbFrom.Text = string.Empty;
                LoadData();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào có xuất xứ '" + xuatXu + "'.");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ sản phẩm trong kho?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                bool isDeleted = sanPhamController.DeleteAllSanPham();

                if (isDeleted)
                {
                    MessageBox.Show("Xóa toàn bộ sản phẩm thành công!");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm nào để xóa.");
                }
            }
        }

        private void btnDeleteExpired_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả sản phẩm đã quá hạn?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                bool isDeleted = sanPhamController.DeleteExpiredSanPham();

                if (isDeleted)
                {
                    MessageBox.Show("Xóa thành công các sản phẩm quá hạn!");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm nào quá hạn để xóa.");
                }
            }
        }

        private void dtgvAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvAll.Rows[e.RowIndex];

                // Lấy giá trị từ cột "MaSanPham" và gán nó vào TextBox txbMaSP
                txbMaSP.Text = selectedRow.Cells["MaSanPham"].Value.ToString();
            }
        }
    }
}
