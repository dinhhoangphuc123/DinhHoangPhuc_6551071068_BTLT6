namespace BAI_2_CHUONG_5
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtHoTen = new TextBox();
            txtcccd = new TextBox();
            txtNhan = new TextBox();
            txtTra = new TextBox();
            txtLon = new TextBox();
            txtNho = new TextBox();
            btnDat = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 8);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 71);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Số CCCD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 136);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày nhận phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 198);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày trả phòng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 328);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 4;
            label5.Text = "Số trẻ em ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 261);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 5;
            label6.Text = "Số người lớn";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(77, 31);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(435, 27);
            txtHoTen.TabIndex = 6;
            // 
            // txtcccd
            // 
            txtcccd.Location = new Point(77, 94);
            txtcccd.Name = "txtcccd";
            txtcccd.Size = new Size(435, 27);
            txtcccd.TabIndex = 7;
            // 
            // txtNhan
            // 
            txtNhan.Location = new Point(77, 159);
            txtNhan.Name = "txtNhan";
            txtNhan.Size = new Size(435, 27);
            txtNhan.TabIndex = 8;
            // 
            // txtTra
            // 
            txtTra.Location = new Point(77, 221);
            txtTra.Name = "txtTra";
            txtTra.Size = new Size(435, 27);
            txtTra.TabIndex = 9;
            // 
            // txtLon
            // 
            txtLon.Location = new Point(77, 285);
            txtLon.Name = "txtLon";
            txtLon.Size = new Size(435, 27);
            txtLon.TabIndex = 10;
            // 
            // txtNho
            // 
            txtNho.Location = new Point(77, 360);
            txtNho.Name = "txtNho";
            txtNho.Size = new Size(435, 27);
            txtNho.TabIndex = 11;
            // 
            // btnDat
            // 
            btnDat.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDat.BackColor = Color.Blue;
            btnDat.ForeColor = Color.White;
            btnDat.Location = new Point(77, 403);
            btnDat.Name = "btnDat";
            btnDat.Size = new Size(435, 47);
            btnDat.TabIndex = 12;
            btnDat.Text = "Đặt phòng";
            btnDat.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(800, 515);
            Controls.Add(btnDat);
            Controls.Add(txtNho);
            Controls.Add(txtLon);
            Controls.Add(txtTra);
            Controls.Add(txtNhan);
            Controls.Add(txtcccd);
            Controls.Add(txtHoTen);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private TextBox txtHoTen;
        private TextBox txtcccd;
        private TextBox txtNhan;
        private TextBox txtTra;
        private TextBox txtLon;
        private TextBox txtNho;
        private Button btnDat;
        private ErrorProvider errorProvider1;
    }
}
