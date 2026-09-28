namespace BAI_6_CHUONG_5
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
            btnLuu = new Button();
            label1 = new Label();
            txtTieuDe = new TextBox();
            label2 = new Label();
            cbbPriority = new ComboBox();
            label3 = new Label();
            lsitNoiDung = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(551, 372);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(164, 29);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Tiêu đề";
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(35, 64);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(369, 27);
            txtTieuDe.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 117);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "Nội dung";
            // 
            // cbbPriority
            // 
            cbbPriority.FormattingEnabled = true;
            cbbPriority.Location = new Point(35, 373);
            cbbPriority.Name = "cbbPriority";
            cbbPriority.Size = new Size(369, 28);
            cbbPriority.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 335);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 5;
            label3.Text = "Priority:";
            // 
            // lsitNoiDung
            // 
            lsitNoiDung.FormattingEnabled = true;
            lsitNoiDung.Location = new Point(35, 156);
            lsitNoiDung.Name = "lsitNoiDung";
            lsitNoiDung.Size = new Size(369, 144);
            lsitNoiDung.TabIndex = 6;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsitNoiDung);
            Controls.Add(label3);
            Controls.Add(cbbPriority);
            Controls.Add(label2);
            Controls.Add(txtTieuDe);
            Controls.Add(label1);
            Controls.Add(btnLuu);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLuu;
        private Label label1;
        private TextBox txtTieuDe;
        private Label label2;
        private ComboBox cbbPriority;
        private Label label3;
        private ListBox lsitNoiDung;
        private ErrorProvider errorProvider1;
    }
}
