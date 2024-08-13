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
            groupBox2 = new GroupBox();
            lb_Back = new Label();
            lb_Page = new Label();
            lb_Next = new Label();
            groupBox3 = new GroupBox();
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
            dtg_HoaDon.Location = new Point(12, 147);
            dtg_HoaDon.Name = "dtg_HoaDon";
            dtg_HoaDon.RowHeadersWidth = 62;
            dtg_HoaDon.Size = new Size(720, 207);
            dtg_HoaDon.TabIndex = 1;
            // 
            // dtg_HDCT
            // 
            dtg_HDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HDCT.Location = new Point(17, 60);
            dtg_HDCT.Name = "dtg_HDCT";
            dtg_HDCT.RowHeadersWidth = 62;
            dtg_HDCT.Size = new Size(715, 174);
            dtg_HDCT.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_HoaDon);
            groupBox1.Location = new Point(779, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 376);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtg_HDCT);
            groupBox2.Location = new Point(779, 412);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(738, 256);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa Đơn Chi Tiết";
            // 
            // lb_Back
            // 
            lb_Back.AutoSize = true;
            lb_Back.Font = new Font("Segoe UI", 11F);
            lb_Back.Location = new Point(211, 671);
            lb_Back.Name = "lb_Back";
            lb_Back.Size = new Size(43, 30);
            lb_Back.TabIndex = 6;
            lb_Back.Text = "<<";
            // 
            // lb_Page
            // 
            lb_Page.AutoSize = true;
            lb_Page.Font = new Font("Segoe UI", 11F);
            lb_Page.Location = new Point(376, 673);
            lb_Page.Name = "lb_Page";
            lb_Page.Size = new Size(25, 30);
            lb_Page.TabIndex = 7;
            lb_Page.Text = "1";
            // 
            // lb_Next
            // 
            lb_Next.AutoSize = true;
            lb_Next.Font = new Font("Segoe UI", 11F);
            lb_Next.Location = new Point(514, 670);
            lb_Next.Name = "lb_Next";
            lb_Next.Size = new Size(43, 30);
            lb_Next.TabIndex = 8;
            lb_Next.Text = ">>";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tlp_SanPham);
            groupBox3.Location = new Point(1, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(750, 656);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Sản Phẩm";
            // 
            // Frm_BanHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 718);
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
    }
}