namespace BAI_5_CHUONG_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Designer chưa đặt các thuộc tính/dữ liệu này nên đặt ở đây
            txtGheDaChon.ReadOnly = true;
            cbbPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSuatChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPhim.Items.AddRange(new object[] { "Chiến binh cuối cùng", "Biệt đội siêu hạng", "Mưa trên phố cổ" });
            cbbSuatChieu.Items.AddRange(new object[] { "09:00", "14:00", "19:00" });

            btnChonGhe.Click += btnChonGhe_Click;
            btnDatVe.Click += btnDatVe_Click;
            btnHuy.Click += btnHuy_Click;
        }

        private void btnChonGhe_Click(object? sender, EventArgs e)
        {
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    txtGheDaChon.Text = dlg.GheChon;
            }
        }

        private void btnDatVe_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKhach.Text) ||
                cbbPhim.SelectedIndex < 0 ||
                cbbSuatChieu.SelectedIndex < 0 ||
                txtGheDaChon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ tên khách, phim, suất chiếu và ghế",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "Đặt vé thành công!\n" +
                "Khách hàng: " + txtKhach.Text.Trim() + "\n" +
                "Phim: " + cbbPhim.Text + "\n" +
                "Suất chiếu: " + cbbSuatChieu.Text + "\n" +
                "Ghế: " + txtGheDaChon.Text + "\n" +
                "Giá: 75.000đ/vé",
                "Xác nhận đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Đề không nói rõ nút Hủy làm gì; ở đây xóa trắng toàn bộ thông tin đang nhập
        private void btnHuy_Click(object? sender, EventArgs e)
        {
            txtKhach.Clear();
            cbbPhim.SelectedIndex = -1;
            cbbSuatChieu.SelectedIndex = -1;
            txtGheDaChon.Clear();
            txtKhach.Focus();
        }
    }
}