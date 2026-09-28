namespace BAI_4_CHUONG_5
{
    public partial class Form1 : Form
    {
        // -1: đang ở chế độ thêm mới; >= 0: đang sửa item ở vị trí này
        private int _indexDangSua = -1;

        public Form1()
        {
            InitializeComponent();

            // Designer chưa gắn sự kiện nên gắn ở đây
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;
            FormClosing += Form1_FormClosing;
        }

        // Tách 1 dòng "Tên - SĐT" thành 2 phần
        private static (string ten, string sdt) TachLienHe(string dong)
        {
            int vitri = dong.LastIndexOf(" - ");
            return (dong[..vitri], dong[(vitri + 3)..]);
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSdt.Text.Trim();

            if (ten == "" || sdt == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên và số điện thoại",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dong = ten + " - " + sdt;

            if (_indexDangSua >= 0)
            {
                listBox1.Items[_indexDangSua] = dong;
                _indexDangSua = -1;
                txtTen.Clear();
                txtSdt.Clear();
                MessageBox.Show("Cập nhật thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listBox1.Items.Add(dong);
                txtTen.Clear();
                txtSdt.Clear();
                MessageBox.Show("Thêm thành công",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để sửa",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (ten, sdt) = TachLienHe(listBox1.SelectedItem!.ToString()!);
            txtTen.Text = ten;
            txtSdt.Text = sdt;
            _indexDangSua = listBox1.SelectedIndex;
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (ten, _) = TachLienHe(listBox1.SelectedItem!.ToString()!);

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa liên hệ " + ten + "? Thao tác này không thể hoàn tác!",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq != DialogResult.Yes)
                return;

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            _indexDangSua = -1;   // vị trí các item đã đổi nên hủy trạng thái đang sửa
            MessageBox.Show("Xóa thành công",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object? sender, EventArgs e)
        {
            Close();   // sẽ đi qua FormClosing để hỏi xác nhận nếu còn dữ liệu chưa lưu
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (txtTen.Text == "" && txtSdt.Text == "")
                return;

            DialogResult kq = MessageBox.Show(
                "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                "Xác nhận thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (kq == DialogResult.Cancel)
                e.Cancel = true;
            else if (kq == DialogResult.No)
            {
                txtTen.Clear();
                txtSdt.Clear();
            }
            // Yes: cứ thoát bình thường
        }
    }
}