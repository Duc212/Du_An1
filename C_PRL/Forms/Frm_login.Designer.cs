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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            label1 = new Label();
            label2 = new Label();
            txt_taikhoan = new TextBox();
            txt_matkhau = new TextBox();
            btn_dangnhap = new Button();
            cbx_ShowPass = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(370, 54);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(370, 162);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_taikhoan.Location = new Point(370, 106);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.PlaceholderText = "Nhập Tài Khoản";
            txt_taikhoan.Size = new Size(370, 34);
            txt_taikhoan.TabIndex = 2;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_matkhau.Location = new Point(370, 214);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.PasswordChar = '*';
            txt_matkhau.PlaceholderText = "Nhập Mật Khẩu";
            txt_matkhau.Size = new Size(370, 34);
            txt_matkhau.TabIndex = 3;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_dangnhap.Location = new Point(370, 351);
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
            cbx_ShowPass.Location = new Point(370, 279);
            cbx_ShowPass.Name = "cbx_ShowPass";
            cbx_ShowPass.Size = new Size(252, 36);
            cbx_ShowPass.TabIndex = 5;
            cbx_ShowPass.Text = "Hiển Thị Mật Khẩu";
            cbx_ShowPass.UseVisualStyleBackColor = true;
            cbx_ShowPass.CheckedChanged += cbx_ShowPass_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGoldenrodYellow;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Frm_login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(cbx_ShowPass);
            Controls.Add(btn_dangnhap);
            Controls.Add(txt_matkhau);
            Controls.Add(txt_taikhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_login";
            Load += Frm_login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}