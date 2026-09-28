namespace BAI_1_CHUONG_5
{
    public partial class Form1 : Form
    {
        // Designer chưa có ErrorProvider nên tạo bằng code, không đụng vào file Designer
        private readonly ErrorProvider errorProvider1 = new ErrorProvider();

        public Form1()
        {
            InitializeComponent();

            errorProvider1.ContainerControl = this;

            txtMatKhau.PasswordChar = '*';
            txtXacNhanMatKhau.PasswordChar = '*';

            btnDangKy.Click += btnDangKy_Click;
            btnHuy.Click += btnHuy_Click;
        }

        // Designer đang tham chiếu handler này nên phải giữ lại
        private void txtHoTen_ParentChanged(object sender, EventArgs e)
        {

        }

        private bool KiemTraHopLe()
        {
            bool hopLe = true;

            // (1) Họ tên: không trống, tối thiểu 3 ký tự
            if (txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống và tối thiểu 3 ký tự");
                hopLe = false;
            }
            else errorProvider1.SetError(txtHoTen, "");

            // (2) SĐT: đúng 10 chữ số, bắt đầu bằng "0"
            string sdt = txtSdt.Text;
            if (sdt.Length != 10 || !sdt.All(char.IsAsciiDigit) || !sdt.StartsWith("0"))
            {
                errorProvider1.SetError(txtSdt, "Số điện thoại phải gồm 10 chữ số và bắt đầu bằng 0");
                hopLe = false;
            }
            else errorProvider1.SetError(txtSdt, "");

            // (3) Email: có "@" và có "." phía sau "@"
            string email = txtEmail.Text;
            int viTriAt = email.IndexOf('@');
            if (viTriAt < 0 || email.IndexOf('.', viTriAt) < 0)
            {
                errorProvider1.SetError(txtEmail, "Email không đúng định dạng");
                hopLe = false;
            }
            else errorProvider1.SetError(txtEmail, "");

            // (4) Mật khẩu: tối thiểu 6 ký tự
            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự");
                hopLe = false;
            }
            else errorProvider1.SetError(txtMatKhau, "");

            // (5) Xác nhận mật khẩu: phải khớp
            if (txtXacNhanMatKhau.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(txtXacNhanMatKhau, "Xác nhận mật khẩu không khớp");
                hopLe = false;
            }
            else errorProvider1.SetError(txtXacNhanMatKhau, "");

            return hopLe;
        }

        private void btnDangKy_Click(object? sender, EventArgs e)
        {
            if (!KiemTraHopLe())
                return;

            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object? sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            Close();
        }
    }
}