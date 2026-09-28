namespace BAI_6_CHUONG_5
{
    // Form1 chính là form ghi chú (MDI Child)
    public partial class Form1 : Form
    {
        // Designer đang dùng ListBox cho phần nội dung; ListBox không gõ chữ được
        // nên thay bằng TextBox nhiều dòng (tạo bằng code, đặt đúng vị trí cũ)
        private readonly TextBox txtNoiDung = new TextBox();

        private bool _daThayDoi = false;

        public Form1()
        {
            InitializeComponent();

            Text = "Ghi chú mới";
            AutoValidate = AutoValidate.EnableAllowFocusChange;   // tránh bị kẹt focus / không đóng được cửa sổ

            // Thay ListBox bằng TextBox nhiều dòng
            txtNoiDung.Multiline = true;
            txtNoiDung.ScrollBars = ScrollBars.Vertical;
            txtNoiDung.Location = lsitNoiDung.Location;
            txtNoiDung.Size = lsitNoiDung.Size;
            txtNoiDung.TabIndex = lsitNoiDung.TabIndex;
            Controls.Remove(lsitNoiDung);
            lsitNoiDung.Dispose();
            Controls.Add(txtNoiDung);

            // Mức độ ưu tiên
            cbbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPriority.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao" });
            cbbPriority.SelectedIndex = 1;

            // Bàn phím
            KeyPreview = true;
            KeyDown += Form1_KeyDown;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;

            // Chuột
            label1.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;   // label "Tiêu đề" ở đầu form
            btnLuu.MouseEnter += btnLuu_MouseEnter;
            btnLuu.MouseLeave += btnLuu_MouseLeave;

            // Validating / Validated
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;

            btnLuu.Click += btnLuu_Click;

            // Theo dõi thay đổi (dùng cho Escape) - gắn sau khi đã đặt giá trị ban đầu
            txtTieuDe.TextChanged += (s, e) => _daThayDoi = true;
            txtNoiDung.TextChanged += (s, e) => _daThayDoi = true;
            cbbPriority.SelectedIndexChanged += (s, e) => _daThayDoi = true;
        }

        // ---------- ③ Bàn phím ----------
        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;   // tránh tiếng "bíp"
                btnLuu.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (!_daThayDoi)
                {
                    Close();
                    return;
                }

                DialogResult kq = MessageBox.Show(
                    "Nội dung đã thay đổi. Bạn có muốn đóng ghi chú không?",
                    "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                    Close();
            }
        }

        // Giới hạn tối đa 500 ký tự
        private void txtNoiDung_KeyPress(object? sender, KeyPressEventArgs e)
        {
            bool kyTuThuong = !char.IsControl(e.KeyChar);   // Backspace, Enter... không tính
            int sauKhiGo = txtNoiDung.TextLength - txtNoiDung.SelectionLength + 1;

            if (kyTuThuong && sauKhiGo > 500)
                e.Handled = true;
        }

        // ---------- ③ Chuột ----------
        private void lblTieuDeForm_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        private void btnLuu_MouseEnter(object? sender, EventArgs e)
        {
            btnLuu.BackColor = Color.LightSkyBlue;
        }

        private void btnLuu_MouseLeave(object? sender, EventArgs e)
        {
            btnLuu.UseVisualStyleBackColor = true;   // trả về màu nền mặc định
        }

        // ---------- ④ Validating / Validated ----------
        private void txtTieuDe_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            string tieuDe = txtTieuDe.Text.Trim();

            if (tieuDe == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được để trống");
                txtTieuDe.BackColor = Color.MistyRose;
            }
            else if (tieuDe.Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề tối đa 50 ký tự");
                txtTieuDe.BackColor = Color.MistyRose;
            }
        }

        private void txtTieuDe_Validated(object? sender, EventArgs e)
        {
            txtTieuDe.BackColor = Color.White;
            errorProvider1.SetError(txtTieuDe, "");
        }

        private void btnLuu_Click(object? sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            Text = txtTieuDe.Text.Trim();
            _daThayDoi = false;
            MessageBox.Show("Đã lưu ghi chú", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}