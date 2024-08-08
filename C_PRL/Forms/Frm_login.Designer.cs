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
            cbx_ShowPass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(98, 98);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(98, 173);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_taikhoan.Location = new Point(246, 98);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.PlaceholderText = "Nhập Tài Khoản";
            txt_taikhoan.Size = new Size(370, 34);
            txt_taikhoan.TabIndex = 2;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_matkhau.Location = new Point(246, 170);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.PasswordChar = '*';
            txt_matkhau.PlaceholderText = "Nhập Mật Khẩu";
            txt_matkhau.Size = new Size(370, 34);
            txt_matkhau.TabIndex = 3;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_dangnhap.Location = new Point(246, 310);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(213, 60);
            btn_dangnhap.TabIndex = 4;
            btn_dangnhap.Text = "Đăng Nhập";
            btn_dangnhap.UseVisualStyleBackColor = true;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // cbx_ShowPass
            // 
            cbx_ShowPass.AutoSize = true;
            cbx_ShowPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cbx_ShowPass.Location = new Point(246, 241);
            cbx_ShowPass.Name = "cbx_ShowPass";
            cbx_ShowPass.Size = new Size(252, 36);
            cbx_ShowPass.TabIndex = 5;
            cbx_ShowPass.Text = "Hiển Thị Mật Khẩu";
            cbx_ShowPass.UseVisualStyleBackColor = true;
            cbx_ShowPass.CheckedChanged += cbx_ShowPass_CheckedChanged;
            // 
            // Frm_login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbx_ShowPass);
            Controls.Add(btn_dangnhap);
            Controls.Add(txt_matkhau);
            Controls.Add(txt_taikhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_login";
            Text = "Frm_login";
            Load += Frm_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_taikhoan;
        private TextBox txt_matkhau;
        private Button btn_dangnhap;
        private CheckBox cbx_ShowPass;
    }
}