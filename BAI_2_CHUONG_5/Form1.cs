using System.ComponentModel;
using System.Globalization;

namespace BAI_2_CHUONG_5
{
    public partial class Form1 : Form
    {
        private const string DinhDangNgay = "d/M/yyyy";   // nhận cả 05/10/2026 lẫn 5/10/2026

        public Form1()
        {
            InitializeComponent();

            // Cho phép rời ô sai và bấm X đóng form (ô sai vẫn đỏ + hiện icon lỗi)
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            FormClosing += (s, e) => e.Cancel = false;   // không cho validation chặn việc đóng form

            // Designer chưa gắn sự kiện nên gắn ở đây
            txtHoTen.Validating += txtHoTen_Validating;
            txtcccd.Validating += txtcccd_Validating;
            txtNhan.Validating += txtNhan_Validating;
            txtTra.Validating += txtTra_Validating;
            txtLon.Validating += txtLon_Validating;
            txtNho.Validating += txtNho_Validating;

            foreach (TextBox txt in new[] { txtHoTen, txtcccd, txtNhan, txtTra, txtLon, txtNho })
                txt.Validated += TextBox_Validated;

            btnDat.Click += btnDat_Click;
        }

        // ---------- Hàm dùng chung ----------
        private void BaoLoi(TextBox txt, CancelEventArgs e, string thongBao)
        {
            e.Cancel = true;
            errorProvider1.SetError(txt, thongBao);
            txt.BackColor = Color.MistyRose;
        }

        private void DungRoi(TextBox txt)
        {
            errorProvider1.SetError(txt, "");
            txt.BackColor = Color.Honeydew;
        }

        private static bool TryParseNgay(string s, out DateTime ngay) =>
            DateTime.TryParseExact(s.Trim(), DinhDangNgay, CultureInfo.InvariantCulture, DateTimeStyles.None, out ngay);

        // ---------- Validating ----------
        private void txtHoTen_Validating(object? sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                BaoLoi(txtHoTen, e, "Họ tên không được để trống");
            else
                DungRoi(txtHoTen);
        }

        private void txtcccd_Validating(object? sender, CancelEventArgs e)
        {
            string s = txtcccd.Text;
            if (s.Length != 12 || !s.All(char.IsAsciiDigit))
                BaoLoi(txtcccd, e, "Số CCCD phải gồm đúng 12 chữ số");
            else
                DungRoi(txtcccd);
        }

        private void txtNhan_Validating(object? sender, CancelEventArgs e)
        {
            if (!TryParseNgay(txtNhan.Text, out DateTime ngayNhan))
                BaoLoi(txtNhan, e, "Ngày nhận phải đúng định dạng dd/MM/yyyy");
            else if (ngayNhan < DateTime.Today)
                BaoLoi(txtNhan, e, "Ngày nhận phải từ hôm nay trở đi");
            else
                DungRoi(txtNhan);
        }

        private void txtTra_Validating(object? sender, CancelEventArgs e)
        {
            if (!TryParseNgay(txtTra.Text, out DateTime ngayTra))
                BaoLoi(txtTra, e, "Ngày trả phải đúng định dạng dd/MM/yyyy");
            else if (!TryParseNgay(txtNhan.Text, out DateTime ngayNhan))
                BaoLoi(txtTra, e, "Vui lòng nhập ngày nhận hợp lệ trước");
            else if (ngayTra <= ngayNhan)
                BaoLoi(txtTra, e, "Ngày trả phải sau ngày nhận");
            else
                DungRoi(txtTra);
        }

        private void txtLon_Validating(object? sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtLon.Text, out int soNguoi) || soNguoi < 1 || soNguoi > 4)
                BaoLoi(txtLon, e, "Số người lớn phải là số nguyên từ 1 đến 4");
            else
                DungRoi(txtLon);
        }

        private void txtNho_Validating(object? sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtNho.Text, out int soTre) || soTre < 0 || soTre > 3)
                BaoLoi(txtNho, e, "Số trẻ em phải là số nguyên từ 0 đến 3");
            else
                DungRoi(txtNho);
        }

        // ---------- Validated (dùng chung cho 6 TextBox) ----------
        private void TextBox_Validated(object? sender, EventArgs e)
        {
            ((TextBox)sender!).BackColor = Color.Honeydew;
        }

        // ---------- Đặt phòng ----------
        private void btnDat_Click(object? sender, EventArgs e)
        {
            // Ô chưa từng được focus sẽ chưa validate, nên kiểm tra lại toàn bộ trước khi đặt
            if (!ValidateChildren())
                return;

            TryParseNgay(txtNhan.Text, out DateTime ngayNhan);
            TryParseNgay(txtTra.Text, out DateTime ngayTra);
            int soDem = (ngayTra - ngayNhan).Days;

            MessageBox.Show(
                "Đặt phòng thành công!\n" +
                "Khách hàng: " + txtHoTen.Text + "\n" +
                "Số đêm: " + soDem + "\n" +
                "Người lớn: " + txtLon.Text + " - Trẻ em: " + txtNho.Text,
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}