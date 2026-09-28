namespace BAI_4_CHUONG_5
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtSdt = new TextBox();
            txtTen = new TextBox();
            btnThem = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(-1, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(473, 444);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(498, 22);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(498, 117);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại";
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(498, 150);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(275, 27);
            txtSdt.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(498, 55);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(290, 27);
            txtTen.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(679, 211);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(679, 383);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(679, 327);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(679, 268);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(btnThem);
            Controls.Add(txtTen);
            Controls.Add(txtSdt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private TextBox txtSdt;
        private TextBox txtTen;
        private Button btnThem;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
    }
}
