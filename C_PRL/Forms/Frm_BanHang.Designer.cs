namespace C_PRL.Forms
{
    partial class Frm_BanHang
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
            tlp_SanPham = new TableLayoutPanel();
            dtg_HoaDon = new DataGridView();
            dtg_HDCT = new DataGridView();
            groupBox1 = new GroupBox();
            lb_MaHD = new Label();
            btn_xoahd = new Button();
            btn_taohoadon = new Button();
            txt_name = new TextBox();
            txt_sdt = new TextBox();
            lb_TongTien = new Label();
            cbx_voucher = new ComboBox();
            cbx_SDT = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lb_Back = new Label();
            lb_Page = new Label();
            lb_Next = new Label();
            groupBox3 = new GroupBox();
            btn_TT = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_HoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_HDCT).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_SanPham
            // 
            tlp_SanPham.ColumnCount = 2;
            tlp_SanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_SanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_SanPham.Location = new Point(34, 44);
            tlp_SanPham.Name = "tlp_SanPham";
            tlp_SanPham.RowCount = 2;
            tlp_SanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_SanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_SanPham.Size = new Size(700, 600);
            tlp_SanPham.TabIndex = 0;
            tlp_SanPham.Paint += tableLayoutPanel1_Paint;
            // 
            // dtg_HoaDon
            // 
            dtg_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HoaDon.Location = new Point(6, 271);
            dtg_HoaDon.Name = "dtg_HoaDon";
            dtg_HoaDon.RowHeadersWidth = 62;
            dtg_HoaDon.Size = new Size(713, 204);
            dtg_HoaDon.TabIndex = 1;
            dtg_HoaDon.CellClick += dtg_HoaDon_CellClick;
            // 
            // dtg_HDCT
            // 
            dtg_HDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HDCT.Location = new Point(6, 30);
            dtg_HDCT.Name = "dtg_HDCT";
            dtg_HDCT.RowHeadersWidth = 62;
            dtg_HDCT.Size = new Size(713, 179);
            dtg_HDCT.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_MaHD);
            groupBox1.Controls.Add(btn_xoahd);
            groupBox1.Controls.Add(btn_taohoadon);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(txt_sdt);
            groupBox1.Controls.Add(lb_TongTien);
            groupBox1.Controls.Add(cbx_voucher);
            groupBox1.Controls.Add(cbx_SDT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtg_HoaDon);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(779, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 481);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn";
            // 
            // lb_MaHD
            // 
            lb_MaHD.AutoSize = true;
            lb_MaHD.Location = new Point(217, 31);
            lb_MaHD.Name = "lb_MaHD";
            lb_MaHD.Size = new Size(66, 25);
            lb_MaHD.TabIndex = 13;
            lb_MaHD.Text = "MãHD";
            // 
            // btn_xoahd
            // 
            btn_xoahd.BackColor = Color.Red;
            btn_xoahd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xoahd.ForeColor = SystemColors.ButtonFace;
            btn_xoahd.Location = new Point(449, 227);
            btn_xoahd.Name = "btn_xoahd";
            btn_xoahd.Size = new Size(183, 38);
            btn_xoahd.TabIndex = 12;
            btn_xoahd.Text = "-  Xóa Hóa Đơn";
            btn_xoahd.UseVisualStyleBackColor = false;
            btn_xoahd.Click += btn_xoahd_Click;
            // 
            // btn_taohoadon
            // 
            btn_taohoadon.BackColor = Color.LimeGreen;
            btn_taohoadon.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_taohoadon.ForeColor = SystemColors.ButtonFace;
            btn_taohoadon.Location = new Point(225, 227);
            btn_taohoadon.Name = "btn_taohoadon";
            btn_taohoadon.Size = new Size(176, 38);
            btn_taohoadon.TabIndex = 12;
            btn_taohoadon.Text = "+ Tạo Hóa Đơn";
            btn_taohoadon.UseVisualStyleBackColor = false;
            btn_taohoadon.Click += btn_taohoadon_Click;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(225, 111);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(471, 34);
            txt_name.TabIndex = 11;
            // 
            // txt_sdt
            // 
            txt_sdt.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_sdt.Location = new Point(225, 67);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.PlaceholderText = "Nhập SDT";
            txt_sdt.Size = new Size(223, 34);
            txt_sdt.TabIndex = 11;
            txt_sdt.TextChanged += txt_sdt_TextChanged;
            // 
            // lb_TongTien
            // 
            lb_TongTien.AutoSize = true;
            lb_TongTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lb_TongTien.ForeColor = Color.DodgerBlue;
            lb_TongTien.Location = new Point(225, 196);
            lb_TongTien.Name = "lb_TongTien";
            lb_TongTien.Size = new Size(24, 28);
            lb_TongTien.TabIndex = 9;
            lb_TongTien.Text = "0";
            // 
            // cbx_voucher
            // 
            cbx_voucher.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cbx_voucher.FormattingEnabled = true;
            cbx_voucher.Location = new Point(225, 156);
            cbx_voucher.Name = "cbx_voucher";
            cbx_voucher.Size = new Size(471, 36);
            cbx_voucher.TabIndex = 8;
            // 
            // cbx_SDT
            // 
            cbx_SDT.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cbx_SDT.FormattingEnabled = true;
            cbx_SDT.Location = new Point(474, 67);
            cbx_SDT.Name = "cbx_SDT";
            cbx_SDT.Size = new Size(222, 36);
            cbx_SDT.TabIndex = 7;
            cbx_SDT.TextChanged += cbx_SDT_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(50, 196);
            label5.Name = "label5";
            label5.Size = new Size(107, 28);
            label5.TabIndex = 6;
            label5.Text = "Tổng Tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(50, 159);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 5;
            label4.Text = "Voucher";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(50, 117);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 4;
            label3.Text = "Tên KH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(50, 75);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 3;
            label2.Text = "SDT Khách Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(50, 27);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 2;
            label1.Text = "Mã Hóa Đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtg_HDCT);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(785, 523);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(732, 215);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa Đơn Chi Tiết";
            // 
            // lb_Back
            // 
            lb_Back.AutoSize = true;
            lb_Back.Font = new Font("Segoe UI", 11F);
            lb_Back.Location = new Point(213, 708);
            lb_Back.Name = "lb_Back";
            lb_Back.Size = new Size(43, 30);
            lb_Back.TabIndex = 6;
            lb_Back.Text = "<<";
            lb_Back.Click += lb_Back_Click;
            // 
            // lb_Page
            // 
            lb_Page.AutoSize = true;
            lb_Page.Font = new Font("Segoe UI", 11F);
            lb_Page.Location = new Point(378, 710);
            lb_Page.Name = "lb_Page";
            lb_Page.Size = new Size(25, 30);
            lb_Page.TabIndex = 7;
            lb_Page.Text = "1";
            // 
            // lb_Next
            // 
            lb_Next.AutoSize = true;
            lb_Next.Font = new Font("Segoe UI", 11F);
            lb_Next.Location = new Point(519, 708);
            lb_Next.Name = "lb_Next";
            lb_Next.Size = new Size(43, 30);
            lb_Next.TabIndex = 8;
            lb_Next.Text = ">>";
            lb_Next.Click += lb_Next_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tlp_SanPham);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(1, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(750, 656);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Sản Phẩm";
            // 
            // btn_TT
            // 
            btn_TT.BackColor = Color.Yellow;
            btn_TT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TT.Location = new Point(1322, 744);
            btn_TT.Name = "btn_TT";
            btn_TT.Size = new Size(182, 58);
            btn_TT.TabIndex = 10;
            btn_TT.Text = "Thanh Toán";
            btn_TT.UseVisualStyleBackColor = false;
            btn_TT.Click += btn_TT_Click;
            // 
            // Frm_BanHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 814);
            Controls.Add(btn_TT);
            Controls.Add(groupBox3);
            Controls.Add(lb_Next);
            Controls.Add(lb_Page);
            Controls.Add(lb_Back);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_BanHang";
            Text = "Bán Hàng";
            Load += Frm_BanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_HoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_HDCT).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlp_SanPham;
        private DataGridView dtg_HoaDon;
        private DataGridView dtg_HDCT;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lb_Back;
        private Label lb_Page;
        private Label lb_Next;
        private GroupBox groupBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lb_Ten;
        private ComboBox cbx_voucher;
        private ComboBox cbx_SDT;
        private Label lb_TongTien;
        private TextBox txt_sdt;
        private TextBox txt_name;
        private Button btn_taohoadon;
        private Button btn_xoahd;
        //private Button btn_ThanhToan;
        private Label lb_MaHD;
        private Button btn_TT;
    }
}