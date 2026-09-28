using System.Globalization;

namespace BAI_3_CHUONG_5
{
    public partial class Form1 : Form
    {
        // Designer chưa có ErrorProvider nên tạo bằng code
        private readonly ErrorProvider errorProvider1 = new ErrorProvider();

        public Form1()
        {
            InitializeComponent();

            errorProvider1.ContainerControl = this;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            DangKyEnterChuyenField();

            // Nhận focus -> bôi xanh toàn bộ nội dung cũ
            txtDiemToan.Enter += TxtDiem_Enter;
            txtDiemVan.Enter += TxtDiem_Enter;
            txtDiemAnh.Enter += TxtDiem_Enter;

            btnLuu.Click += btnLuu_Click;
            btnXoa.Click += btnXoa_Click;
        }

        // Nhấn Enter trong TextBox -> sang ô kế tiếp; riêng txtDiemAnh -> Lưu
        private void DangKyEnterChuyenField()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox txt)
                    txt.KeyPress += TextBox_KeyPress;
            }
        }

        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            e.Handled = true;   // chặn tiếng "bíp"

            if (sender == txtDiemAnh)
                btnLuu.PerformClick();
            else
                SelectNextControl((Control)sender!, true, true, true, true);
        }

        private void TxtDiem_Enter(object? sender, EventArgs e)
        {
            ((TextBox)sender!).SelectAll();
        }

        // Kiểm tra 1 ô điểm (0.0 - 10.0). Chấp nhận cả "8.5" lẫn "8,5"
        private bool KiemTraDiem(TextBox txt, out decimal diem)
        {
            string s = txt.Text.Trim().Replace(',', '.');
            bool ok = decimal.TryParse(s, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out diem)
                      && diem >= 0m && diem <= 10m;

            errorProvider1.SetError(txt, ok ? "" : "Điểm phải là số từ 0.0 đến 10.0");
            return ok;
        }

        private void btnLuu_Click(object? sender, EventArgs e)
        {
            bool toanOk = KiemTraDiem(txtDiemToan, out decimal toan);
            bool vanOk = KiemTraDiem(txtDiemVan, out decimal van);
            bool anhOk = KiemTraDiem(txtDiemAnh, out decimal anh);

            if (!toanOk || !vanOk || !anhOk)
            {
                // Đưa con trỏ về ô sai đầu tiên
                if (!toanOk) txtDiemToan.Focus();
                else if (!vanOk) txtDiemVan.Focus();
                else txtDiemAnh.Focus();
                return;
            }

            string dong = $"{txtMaHS.Text} | {txtHoTen.Text} | " +
                          $"T:{toan.ToString("0.0", CultureInfo.InvariantCulture)} " +
                          $"V:{van.ToString("0.0", CultureInfo.InvariantCulture)} " +
                          $"A:{anh.ToString("0.0", CultureInfo.InvariantCulture)}";
            listBox1.Items.Add(dong);

            XoaTrangForm();
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            XoaTrangForm();
        }

        private void XoaTrangForm()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtDiemToan.Clear();
            txtDiemVan.Clear();
            txtDiemAnh.Clear();
            errorProvider1.Clear();
            txtMaHS.Focus();
        }
    }
}