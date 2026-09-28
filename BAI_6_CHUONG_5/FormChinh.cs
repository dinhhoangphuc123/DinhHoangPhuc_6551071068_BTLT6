namespace BAI_6_CHUONG_5
{
    // Form chính (MDI Container) - dựng hoàn toàn bằng code, không cần file Designer
    public class FormChinh : Form
    {
        private readonly ToolStripStatusLabel lblTrangThai = new ToolStripStatusLabel();

        public FormChinh()
        {
            Text = "Note Manager";
            IsMdiContainer = true;
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1000, 700);

            // Menu "Tệp"
            var mnuMoMoi = new ToolStripMenuItem("Mở ghi chú mới");
            var mnuSapXep = new ToolStripMenuItem("Sắp xếp cửa sổ");
            var mnuThoat = new ToolStripMenuItem("Thoát");
            var mnuTep = new ToolStripMenuItem("Tệp");
            mnuTep.DropDownItems.AddRange(new ToolStripItem[] { mnuMoMoi, mnuSapXep, mnuThoat });

            // Menu "Cửa sổ"
            var mnuXepTang = new ToolStripMenuItem("Xếp tầng");
            var mnuXepNgang = new ToolStripMenuItem("Xếp ngang");
            var mnuXepDoc = new ToolStripMenuItem("Xếp dọc");
            var mnuCuaSo = new ToolStripMenuItem("Cửa sổ");
            mnuCuaSo.DropDownItems.AddRange(new ToolStripItem[] { mnuXepTang, mnuXepNgang, mnuXepDoc });

            var menuStrip = new MenuStrip();
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuTep, mnuCuaSo });
            MainMenuStrip = menuStrip;

            var statusStrip = new StatusStrip();
            statusStrip.Items.Add(lblTrangThai);

            Controls.Add(menuStrip);
            Controls.Add(statusStrip);

            mnuMoMoi.Click += mnuMoMoi_Click;
            mnuSapXep.Click += mnuXepTang_Click;   // "Sắp xếp cửa sổ" = xếp tầng
            mnuThoat.Click += mnuThoat_Click;
            mnuXepTang.Click += mnuXepTang_Click;
            mnuXepNgang.Click += mnuXepNgang_Click;
            mnuXepDoc.Click += mnuXepDoc_Click;

            CapNhatTrangThai();
        }

        private void mnuMoMoi_Click(object? sender, EventArgs e)
        {
            Form1 ghiChu = new Form1();   // Form1 chính là form ghi chú (MDI Child)
            ghiChu.MdiParent = this;
            // Đợi form con đóng hẳn rồi mới đếm lại
            ghiChu.FormClosed += (s, ev) =>
            {
                if (IsHandleCreated && !IsDisposed)
                    BeginInvoke(new Action(CapNhatTrangThai));
            };
            ghiChu.Show();   // MDI Child dùng Show(), không dùng ShowDialog()
            CapNhatTrangThai();
        }

        private void mnuThoat_Click(object? sender, EventArgs e) => Close();

        private void mnuXepTang_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);

        private void mnuXepNgang_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);

        private void mnuXepDoc_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);

        private void CapNhatTrangThai()
        {
            lblTrangThai.Text = "Số ghi chú đang mở: " + MdiChildren.Length;
        }
    }
}
