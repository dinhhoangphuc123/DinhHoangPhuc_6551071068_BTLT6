namespace BAI_5_CHUONG_5
{
    // Form dialog chọn ghế - dựng hoàn toàn bằng code, không cần file Designer
    public class FormChonGhe : Form
    {
        private readonly ListBox lstGhe = new ListBox();
        private readonly Label lblGheDaChon = new Label();
        private readonly Button btnXacNhan = new Button();
        private readonly Button btnBoQua = new Button();

        public string GheChon { get; private set; } = "";

        public FormChonGhe(string gheHienTai)
        {
            Text = "Chọn ghế";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;

            // Xếp ghế theo hàng ngang: A1..A5 / B1..B5 / C1..C5 (ListBox nhiều cột, 3 dòng)
            for (int so = 1; so <= 5; so++)
                foreach (char hang in "ABC")
                    lstGhe.Items.Add(hang.ToString() + so);
            lstGhe.MultiColumn = true;
            lstGhe.ColumnWidth = 40;
            lstGhe.IntegralHeight = false;
            lstGhe.Size = new Size(240, 3 * lstGhe.ItemHeight + 6);
            lstGhe.Location = new Point(10, 10);
            lstGhe.SelectedIndexChanged += lstGhe_SelectedIndexChanged;

            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Text = "Đang chọn: ";
            lblGheDaChon.Location = new Point(10, lstGhe.Bottom + 10);

            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.Size = new Size(90, 28);
            btnXacNhan.Location = new Point(50, lstGhe.Bottom + 45);
            btnXacNhan.Click += btnXacNhan_Click;

            btnBoQua.Text = "Bỏ qua";
            btnBoQua.Size = new Size(90, 28);
            btnBoQua.Location = new Point(150, lstGhe.Bottom + 45);
            btnBoQua.Click += btnBoQua_Click;

            ClientSize = new Size(260, btnXacNhan.Bottom + 12);
            Controls.AddRange(new Control[] { lstGhe, lblGheDaChon, btnXacNhan, btnBoQua });
            AcceptButton = btnXacNhan;
            CancelButton = btnBoQua;

            // Chọn sẵn ghế cũ (nếu có) - gán sau khi đã gắn sự kiện để label tự cập nhật
            if (gheHienTai != "" && lstGhe.Items.Contains(gheHienTai))
                lstGhe.SelectedItem = gheHienTai;
        }

        private void lstGhe_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lblGheDaChon.Text = "Đang chọn: " + lstGhe.SelectedItem;
        }

        private void btnXacNhan_Click(object? sender, EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một ghế",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GheChon = lstGhe.SelectedItem.ToString()!;
            DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
