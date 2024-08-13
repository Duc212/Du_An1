namespace C_PRL.Forms
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            pn_Menu = new Panel();
            button1 = new Button();
            btn_GiamGia = new Button();
            button6 = new Button();
            btn_KhachHang = new Button();
            btn_NhanVien = new Button();
            btn_SanPham = new Button();
            btn_HoaDon = new Button();
            btn_BanHang = new Button();
            panel1 = new Panel();
            label1 = new Label();
            lb_account = new Label();
            pn_Show = new Panel();
            pn_title = new Panel();
            lb_title = new Label();
            pn_Menu.SuspendLayout();
            panel1.SuspendLayout();
            pn_title.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Menu
            // 
            pn_Menu.BackColor = Color.DarkCyan;
            pn_Menu.Controls.Add(button1);
            pn_Menu.Controls.Add(btn_GiamGia);
            pn_Menu.Controls.Add(button6);
            pn_Menu.Controls.Add(btn_KhachHang);
            pn_Menu.Controls.Add(btn_NhanVien);
            pn_Menu.Controls.Add(btn_SanPham);
            pn_Menu.Controls.Add(btn_HoaDon);
            pn_Menu.Controls.Add(btn_BanHang);
            pn_Menu.Controls.Add(panel1);
            pn_Menu.Dock = DockStyle.Left;
            pn_Menu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pn_Menu.Location = new Point(0, 0);
            pn_Menu.Name = "pn_Menu";
            pn_Menu.Size = new Size(265, 807);
            pn_Menu.TabIndex = 0;
            pn_Menu.Paint += pn_Menu_Paint;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 504);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(265, 72);
            button1.TabIndex = 8;
            button1.Text = "Thống Kê";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_GiamGia
            // 
            btn_GiamGia.Dock = DockStyle.Top;
            btn_GiamGia.FlatStyle = FlatStyle.Flat;
            btn_GiamGia.ForeColor = SystemColors.Control;
            btn_GiamGia.Image = (Image)resources.GetObject("btn_GiamGia.Image");
            btn_GiamGia.ImageAlign = ContentAlignment.MiddleLeft;
            btn_GiamGia.Location = new Point(0, 432);
            btn_GiamGia.Name = "btn_GiamGia";
            btn_GiamGia.Padding = new Padding(10, 0, 0, 0);
            btn_GiamGia.Size = new Size(265, 72);
            btn_GiamGia.TabIndex = 7;
            btn_GiamGia.Text = "Quản Lý Sale";
            btn_GiamGia.TextAlign = ContentAlignment.MiddleLeft;
            btn_GiamGia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_GiamGia.UseVisualStyleBackColor = true;
            btn_GiamGia.Click += btn_GiamGia_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Bottom;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(0, 736);
            button6.Name = "button6";
            button6.Size = new Size(265, 71);
            button6.TabIndex = 6;
            button6.Text = "Thoát";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btn_KhachHang
            // 
            btn_KhachHang.Dock = DockStyle.Top;
            btn_KhachHang.FlatStyle = FlatStyle.Flat;
            btn_KhachHang.ForeColor = SystemColors.Control;
            btn_KhachHang.Image = (Image)resources.GetObject("btn_KhachHang.Image");
            btn_KhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_KhachHang.Location = new Point(0, 360);
            btn_KhachHang.Name = "btn_KhachHang";
            btn_KhachHang.Padding = new Padding(10, 0, 0, 0);
            btn_KhachHang.Size = new Size(265, 72);
            btn_KhachHang.TabIndex = 5;
            btn_KhachHang.Text = "Khách Hàng";
            btn_KhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btn_KhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_KhachHang.UseVisualStyleBackColor = true;
            btn_KhachHang.Click += btn_KhachHang_Click;
            // 
            // btn_NhanVien
            // 
            btn_NhanVien.Dock = DockStyle.Top;
            btn_NhanVien.FlatStyle = FlatStyle.Flat;
            btn_NhanVien.ForeColor = SystemColors.Control;
            btn_NhanVien.Image = (Image)resources.GetObject("btn_NhanVien.Image");
            btn_NhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NhanVien.Location = new Point(0, 288);
            btn_NhanVien.Name = "btn_NhanVien";
            btn_NhanVien.Padding = new Padding(10, 0, 0, 0);
            btn_NhanVien.Size = new Size(265, 72);
            btn_NhanVien.TabIndex = 4;
            btn_NhanVien.Text = "Nhân Viên";
            btn_NhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btn_NhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_NhanVien.UseVisualStyleBackColor = true;
            btn_NhanVien.Click += btn_NhanVien_Click;
            // 
            // btn_SanPham
            // 
            btn_SanPham.Dock = DockStyle.Top;
            btn_SanPham.FlatStyle = FlatStyle.Flat;
            btn_SanPham.ForeColor = SystemColors.Control;
            btn_SanPham.Image = (Image)resources.GetObject("btn_SanPham.Image");
            btn_SanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btn_SanPham.Location = new Point(0, 216);
            btn_SanPham.Name = "btn_SanPham";
            btn_SanPham.Padding = new Padding(10, 0, 0, 0);
            btn_SanPham.Size = new Size(265, 72);
            btn_SanPham.TabIndex = 3;
            btn_SanPham.Text = "Sản Phẩm";
            btn_SanPham.TextAlign = ContentAlignment.MiddleLeft;
            btn_SanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_SanPham.UseVisualStyleBackColor = true;
            btn_SanPham.Click += btn_SanPham_Click;
            // 
            // btn_HoaDon
            // 
            btn_HoaDon.Dock = DockStyle.Top;
            btn_HoaDon.FlatStyle = FlatStyle.Flat;
            btn_HoaDon.ForeColor = SystemColors.Control;
            btn_HoaDon.Image = (Image)resources.GetObject("btn_HoaDon.Image");
            btn_HoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_HoaDon.Location = new Point(0, 144);
            btn_HoaDon.Name = "btn_HoaDon";
            btn_HoaDon.Padding = new Padding(10, 0, 0, 0);
            btn_HoaDon.Size = new Size(265, 72);
            btn_HoaDon.TabIndex = 2;
            btn_HoaDon.Text = "Hóa Đơn";
            btn_HoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btn_HoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_HoaDon.UseVisualStyleBackColor = true;
            btn_HoaDon.Click += btn_HoaDon_Click;
            // 
            // btn_BanHang
            // 
            btn_BanHang.AutoSize = true;
            btn_BanHang.Dock = DockStyle.Top;
            btn_BanHang.FlatStyle = FlatStyle.Flat;
            btn_BanHang.ForeColor = SystemColors.Control;
            btn_BanHang.Image = (Image)resources.GetObject("btn_BanHang.Image");
            btn_BanHang.ImageAlign = ContentAlignment.TopLeft;
            btn_BanHang.Location = new Point(0, 72);
            btn_BanHang.Name = "btn_BanHang";
            btn_BanHang.Padding = new Padding(10, 0, 0, 0);
            btn_BanHang.RightToLeft = RightToLeft.No;
            btn_BanHang.Size = new Size(265, 72);
            btn_BanHang.TabIndex = 1;
            btn_BanHang.Text = "Bán Hàng";
            btn_BanHang.TextAlign = ContentAlignment.MiddleLeft;
            btn_BanHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_BanHang.UseVisualStyleBackColor = true;
            btn_BanHang.Click += btn_BanHang_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lb_account);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(115, 32);
            label1.TabIndex = 1;
            label1.Text = "Xin Chào,";
            // 
            // lb_account
            // 
            lb_account.AutoSize = true;
            lb_account.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_account.Location = new Point(123, 22);
            lb_account.Name = "lb_account";
            lb_account.Size = new Size(29, 32);
            lb_account.TabIndex = 0;
            lb_account.Text = "...";
            // 
            // pn_Show
            // 
            pn_Show.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pn_Show.BackColor = SystemColors.ButtonFace;
            pn_Show.Location = new Point(265, 72);
            pn_Show.Name = "pn_Show";
            pn_Show.Size = new Size(1520, 735);
            pn_Show.TabIndex = 1;
            // 
            // pn_title
            // 
            pn_title.BackColor = Color.LightSeaGreen;
            pn_title.Controls.Add(lb_title);
            pn_title.Dock = DockStyle.Top;
            pn_title.Location = new Point(265, 0);
            pn_title.Name = "pn_title";
            pn_title.Size = new Size(1520, 72);
            pn_title.TabIndex = 2;
            // 
            // lb_title
            // 
            lb_title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_title.AutoSize = true;
            lb_title.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_title.ForeColor = SystemColors.ControlLightLight;
            lb_title.Location = new Point(684, 17);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(96, 38);
            lb_title.TabIndex = 0;
            lb_title.Text = "Home";
            lb_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1785, 807);
            Controls.Add(pn_title);
            Controls.Add(pn_Show);
            Controls.Add(pn_Menu);
            Name = "Frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Main";
            Load += Frm_Main_Load;
            pn_Menu.ResumeLayout(false);
            pn_Menu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Menu;
        private Panel panel1;
        private Button btn_KhachHang;
        private Button btn_NhanVien;
        private Button btn_SanPham;
        private Button btn_HoaDon;
        private Button btn_BanHang;
        private Button button6;
        private Panel pn_Show;
        private Label lb_account;
        private Label label1;
        private Button btn_GiamGia;
        private Button button1;
        private Panel pn_title;
        private Label lb_title;
    }
}