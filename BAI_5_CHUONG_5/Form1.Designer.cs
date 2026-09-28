namespace BAI_5_CHUONG_5
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
            txtKhach = new TextBox();
            cbbPhim = new ComboBox();
            cbbSuatChieu = new ComboBox();
            txtGheDaChon = new TextBox();
            btnDatVe = new Button();
            btnChonGhe = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên khách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 132);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Phim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 246);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Suất chiếu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 355);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 3;
            label4.Text = "Ghế đã chọn:";
            // 
            // txtKhach
            // 
            txtKhach.Location = new Point(22, 62);
            txtKhach.Name = "txtKhach";
            txtKhach.Size = new Size(370, 27);
            txtKhach.TabIndex = 4;
            // 
            // cbbPhim
            // 
            cbbPhim.FormattingEnabled = true;
            cbbPhim.Location = new Point(22, 168);
            cbbPhim.Name = "cbbPhim";
            cbbPhim.Size = new Size(370, 28);
            cbbPhim.TabIndex = 5;
            // 
            // cbbSuatChieu
            // 
            cbbSuatChieu.FormattingEnabled = true;
            cbbSuatChieu.Location = new Point(22, 279);
            cbbSuatChieu.Name = "cbbSuatChieu";
            cbbSuatChieu.Size = new Size(370, 28);
            cbbSuatChieu.TabIndex = 6;
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Location = new Point(22, 392);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.Size = new Size(370, 27);
            txtGheDaChon.TabIndex = 7;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(154, 481);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(94, 29);
            btnDatVe.TabIndex = 8;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new Point(23, 481);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(94, 29);
            btnChonGhe.TabIndex = 9;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(298, 481);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(btnHuy);
            Controls.Add(btnChonGhe);
            Controls.Add(btnDatVe);
            Controls.Add(txtGheDaChon);
            Controls.Add(cbbSuatChieu);
            Controls.Add(cbbPhim);
            Controls.Add(txtKhach);
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
        private TextBox txtKhach;
        private ComboBox cbbPhim;
        private ComboBox cbbSuatChieu;
        private TextBox txtGheDaChon;
        private Button btnDatVe;
        private Button btnChonGhe;
        private Button btnHuy;
    }
}
