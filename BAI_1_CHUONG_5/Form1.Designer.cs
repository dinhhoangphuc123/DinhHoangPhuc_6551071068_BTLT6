namespace BAI_1_CHUONG_5
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
            label6 = new Label();
            label7 = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            txtHoTen = new TextBox();
            txtSdt = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(675, 82);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký tài khoản mới ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(218, 20);
            label2.TabIndex = 1;
            label2.Text = "Vui lòng nhập đầy đủ thông tin ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 128);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 189);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 247);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(192, 303);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Mật khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(128, 362);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 6;
            label7.Text = "Xác nhận mật khẩu";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Blue;
            btnDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(277, 420);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(145, 50);
            btnDangKy.TabIndex = 7;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Silver;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.ForeColor = Color.Black;
            btnHuy.Location = new Point(447, 420);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(136, 50);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(277, 121);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(306, 27);
            txtHoTen.TabIndex = 9;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(277, 182);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(306, 27);
            txtSdt.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(277, 240);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(306, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(277, 296);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(306, 27);
            txtMatKhau.TabIndex = 12;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(277, 355);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(306, 27);
            txtXacNhanMatKhau.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 509);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(txtSdt);
            Controls.Add(txtHoTen);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(label7);
            Controls.Add(label6);
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
        private Label label6;
        private Label label7;
        private Button btnDangKy;
        private Button btnHuy;
        private TextBox txtHoTen;
        private TextBox txtSdt;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMatKhau;
    }
}
