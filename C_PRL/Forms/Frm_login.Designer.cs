namespace C_PRL.Forms
{
    partial class Frm_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_taikhoan = new TextBox();
            txt_matkhau = new TextBox();
            btn_dangnhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 104);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Tai Khoan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 173);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Mat Khau";
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Location = new Point(225, 98);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(370, 31);
            txt_taikhoan.TabIndex = 2;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(225, 170);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(370, 31);
            txt_matkhau.TabIndex = 3;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Location = new Point(315, 266);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(137, 60);
            btn_dangnhap.TabIndex = 4;
            btn_dangnhap.Text = "Đăng Nhập";
            btn_dangnhap.UseVisualStyleBackColor = true;
            // 
            // Frm_login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_dangnhap);
            Controls.Add(txt_matkhau);
            Controls.Add(txt_taikhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_login";
            Text = "Frm_login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_taikhoan;
        private TextBox txt_matkhau;
        private Button btn_dangnhap;
    }
}