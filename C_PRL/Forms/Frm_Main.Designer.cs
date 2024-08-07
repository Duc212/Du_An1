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
            pn_Menu = new Panel();
            button6 = new Button();
            btn_KhachHang = new Button();
            btn_NhanVien = new Button();
            btn_SanPham = new Button();
            btn_HoaDon = new Button();
            btn_BanHang = new Button();
            panel1 = new Panel();
            pn_Show = new Panel();
            pn_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Menu
            // 
            pn_Menu.BackColor = Color.ForestGreen;
            pn_Menu.Controls.Add(button6);
            pn_Menu.Controls.Add(btn_KhachHang);
            pn_Menu.Controls.Add(btn_NhanVien);
            pn_Menu.Controls.Add(btn_SanPham);
            pn_Menu.Controls.Add(btn_HoaDon);
            pn_Menu.Controls.Add(btn_BanHang);
            pn_Menu.Controls.Add(panel1);
            pn_Menu.Dock = DockStyle.Left;
            pn_Menu.Location = new Point(0, 0);
            pn_Menu.Name = "pn_Menu";
            pn_Menu.Size = new Size(300, 755);
            pn_Menu.TabIndex = 0;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Bottom;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(0, 684);
            button6.Name = "button6";
            button6.Size = new Size(300, 71);
            button6.TabIndex = 6;
            button6.Text = "Thoát";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // btn_KhachHang
            // 
            btn_KhachHang.Dock = DockStyle.Top;
            btn_KhachHang.FlatStyle = FlatStyle.Flat;
            btn_KhachHang.ForeColor = SystemColors.ButtonHighlight;
            btn_KhachHang.Location = new Point(0, 434);
            btn_KhachHang.Name = "btn_KhachHang";
            btn_KhachHang.Size = new Size(300, 71);
            btn_KhachHang.TabIndex = 5;
            btn_KhachHang.Text = "Khách Hàng";
            btn_KhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btn_KhachHang.UseVisualStyleBackColor = true;
            btn_KhachHang.Click += btn_KhachHang_Click;
            // 
            // btn_NhanVien
            // 
            btn_NhanVien.Dock = DockStyle.Top;
            btn_NhanVien.FlatStyle = FlatStyle.Flat;
            btn_NhanVien.ForeColor = SystemColors.ButtonHighlight;
            btn_NhanVien.Location = new Point(0, 363);
            btn_NhanVien.Name = "btn_NhanVien";
            btn_NhanVien.Size = new Size(300, 71);
            btn_NhanVien.TabIndex = 4;
            btn_NhanVien.Text = "Nhân Viên";
            btn_NhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btn_NhanVien.UseVisualStyleBackColor = true;
            // 
            // btn_SanPham
            // 
            btn_SanPham.Dock = DockStyle.Top;
            btn_SanPham.FlatStyle = FlatStyle.Flat;
            btn_SanPham.ForeColor = SystemColors.ButtonHighlight;
            btn_SanPham.Location = new Point(0, 292);
            btn_SanPham.Name = "btn_SanPham";
            btn_SanPham.Size = new Size(300, 71);
            btn_SanPham.TabIndex = 3;
            btn_SanPham.Text = "Sản Phẩm";
            btn_SanPham.TextAlign = ContentAlignment.MiddleLeft;
            btn_SanPham.UseVisualStyleBackColor = true;
            btn_SanPham.Click += btn_SanPham_Click;
            // 
            // btn_HoaDon
            // 
            btn_HoaDon.Dock = DockStyle.Top;
            btn_HoaDon.FlatStyle = FlatStyle.Flat;
            btn_HoaDon.ForeColor = SystemColors.ButtonHighlight;
            btn_HoaDon.Location = new Point(0, 221);
            btn_HoaDon.Name = "btn_HoaDon";
            btn_HoaDon.Size = new Size(300, 71);
            btn_HoaDon.TabIndex = 2;
            btn_HoaDon.Text = "Hóa Đơn";
            btn_HoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btn_HoaDon.UseVisualStyleBackColor = true;
            // 
            // btn_BanHang
            // 
            btn_BanHang.Dock = DockStyle.Top;
            btn_BanHang.FlatStyle = FlatStyle.Flat;
            btn_BanHang.ForeColor = SystemColors.ButtonHighlight;
            btn_BanHang.ImageAlign = ContentAlignment.TopRight;
            btn_BanHang.Location = new Point(0, 150);
            btn_BanHang.Name = "btn_BanHang";
            btn_BanHang.RightToLeft = RightToLeft.No;
            btn_BanHang.Size = new Size(300, 71);
            btn_BanHang.TabIndex = 1;
            btn_BanHang.Text = "Bán Hàng";
            btn_BanHang.TextAlign = ContentAlignment.MiddleLeft;
            btn_BanHang.UseVisualStyleBackColor = true;
            btn_BanHang.Click += btn_BanHang_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 150);
            panel1.TabIndex = 0;
            // 
            // pn_Show
            // 
            pn_Show.Location = new Point(303, 12);
            pn_Show.Name = "pn_Show";
            pn_Show.Size = new Size(1125, 719);
            pn_Show.TabIndex = 1;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 755);
            Controls.Add(pn_Show);
            Controls.Add(pn_Menu);
            Name = "Frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Main";
            Load += Frm_Main_Load;
            pn_Menu.ResumeLayout(false);
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
    }
}