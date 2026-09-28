namespace BAI_3_CHUONG_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtDiemToan = new TextBox();
            txtDiemVan = new TextBox();
            txtDiemAnh = new TextBox();
            btnLuu = new Button();
            btnXoa = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 34);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 34);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Điểm Văn ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(664, 34);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Điểm Anh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 34);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Họ tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 34);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Điểm toán";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(21, 73);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(94, 27);
            txtMaHS.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(147, 73);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(100, 27);
            txtHoTen.TabIndex = 6;
            // 
            // txtDiemToan
            // 
            txtDiemToan.Location = new Point(304, 73);
            txtDiemToan.Name = "txtDiemToan";
            txtDiemToan.Size = new Size(94, 27);
            txtDiemToan.TabIndex = 7;
            // 
            // txtDiemVan
            // 
            txtDiemVan.Location = new Point(467, 73);
            txtDiemVan.Name = "txtDiemVan";
            txtDiemVan.Size = new Size(96, 27);
            txtDiemVan.TabIndex = 8;
            // 
            // txtDiemAnh
            // 
            txtDiemAnh.Location = new Point(641, 73);
            txtDiemAnh.Name = "txtDiemAnh";
            txtDiemAnh.Size = new Size(111, 27);
            txtDiemAnh.TabIndex = 9;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(255, 128, 0);
            btnLuu.Location = new Point(12, 118);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Silver;
            btnXoa.Location = new Point(120, 118);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa trắng";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 171);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 264);
            listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(txtDiemAnh);
            Controls.Add(txtDiemVan);
            Controls.Add(txtDiemToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtDiemToan;
        private TextBox txtDiemVan;
        private TextBox txtDiemAnh;
        private Button btnLuu;
        private Button btnXoa;
        private ListBox listBox1;
    }
}
