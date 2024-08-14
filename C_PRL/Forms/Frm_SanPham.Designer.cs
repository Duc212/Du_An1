namespace C_PRL.Forms
{
    partial class Frm_SanPham
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
            dtg_Data = new DataGridView();
            ptb_Image = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btn_tim = new Button();
            btn_Show = new Button();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            btn_Them = new Button();
            label4 = new Label();
            txt_timkiem = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            txt_tensp = new TextBox();
            txt_giaSP = new TextBox();
            txt_ncc = new TextBox();
            txt_soluongton = new TextBox();
            label1 = new Label();
            txt_mota = new TextBox();
            cbx_trangthai = new ComboBox();
            label6 = new Label();
            cbx_sale = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtg_Data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Image).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_Data
            // 
            dtg_Data.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtg_Data.BackgroundColor = SystemColors.ActiveCaption;
            dtg_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Data.Location = new Point(6, 81);
            dtg_Data.Name = "dtg_Data";
            dtg_Data.RowHeadersWidth = 62;
            dtg_Data.Size = new Size(1333, 256);
            dtg_Data.TabIndex = 0;
            dtg_Data.CellContentClick += dtg_Data_CellContentClick;
            // 
            // ptb_Image
            // 
            ptb_Image.Location = new Point(20, 30);
            ptb_Image.Name = "ptb_Image";
            ptb_Image.Size = new Size(272, 213);
            ptb_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Image.TabIndex = 1;
            ptb_Image.TabStop = false;
            ptb_Image.Click += ptb_Image_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(522, 109);
            label2.Name = "label2";
            label2.Size = new Size(163, 32);
            label2.TabIndex = 3;
            label2.Text = "Số Lượng Tồn";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(56, 191);
            label3.Name = "label3";
            label3.Size = new Size(102, 32);
            label3.TabIndex = 4;
            label3.Text = "Mã NCC";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btn_tim);
            groupBox1.Controls.Add(btn_Show);
            groupBox1.Controls.Add(btn_Xoa);
            groupBox1.Controls.Add(btn_Sua);
            groupBox1.Controls.Add(btn_Them);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_timkiem);
            groupBox1.Controls.Add(dtg_Data);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(12, 316);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1349, 431);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = " Sản Phẩm";
            // 
            // btn_tim
            // 
            btn_tim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_tim.ForeColor = SystemColors.ActiveCaptionText;
            btn_tim.Location = new Point(1207, 27);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(132, 48);
            btn_tim.TabIndex = 8;
            btn_tim.Text = "Tìm";
            btn_tim.UseVisualStyleBackColor = true;
            btn_tim.Click += btn_tim_Click;
            // 
            // btn_Show
            // 
            btn_Show.Anchor = AnchorStyles.Top;
            btn_Show.ForeColor = SystemColors.ActiveCaptionText;
            btn_Show.Location = new Point(899, 356);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(165, 57);
            btn_Show.TabIndex = 6;
            btn_Show.Text = "Hiển Thị DS";
            btn_Show.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Anchor = AnchorStyles.Top;
            btn_Xoa.ForeColor = SystemColors.ActiveCaptionText;
            btn_Xoa.Location = new Point(677, 356);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(160, 57);
            btn_Xoa.TabIndex = 5;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Anchor = AnchorStyles.Top;
            btn_Sua.ForeColor = SystemColors.ActiveCaptionText;
            btn_Sua.Location = new Point(466, 356);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(160, 57);
            btn_Sua.TabIndex = 4;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.Anchor = AnchorStyles.Top;
            btn_Them.ForeColor = SystemColors.ActiveCaptionText;
            btn_Them.Location = new Point(254, 356);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(160, 57);
            btn_Them.TabIndex = 3;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(861, 35);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 2;
            label4.Text = "Tìm Kiếm";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_timkiem.Location = new Point(1002, 32);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(188, 39);
            txt_timkiem.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(56, 29);
            label5.Name = "label5";
            label5.Size = new Size(165, 32);
            label5.TabIndex = 6;
            label5.Text = "Tên Sản Phẩm";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(522, 189);
            label7.Name = "label7";
            label7.Size = new Size(125, 32);
            label7.TabIndex = 8;
            label7.Text = "Trạng Thái";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = SystemColors.Desktop;
            label8.Location = new Point(522, 29);
            label8.Name = "label8";
            label8.Size = new Size(100, 32);
            label8.TabIndex = 9;
            label8.Text = "Đơn Giá";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(ptb_Image);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.ForeColor = SystemColors.Desktop;
            groupBox2.Location = new Point(1004, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 261);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ảnh Sản Phẩm";
            // 
            // txt_tensp
            // 
            txt_tensp.Font = new Font("Segoe UI", 12F);
            txt_tensp.Location = new Point(266, 29);
            txt_tensp.Name = "txt_tensp";
            txt_tensp.Size = new Size(222, 39);
            txt_tensp.TabIndex = 12;
            // 
            // txt_giaSP
            // 
            txt_giaSP.Anchor = AnchorStyles.Top;
            txt_giaSP.Font = new Font("Segoe UI", 12F);
            txt_giaSP.Location = new Point(701, 29);
            txt_giaSP.Name = "txt_giaSP";
            txt_giaSP.Size = new Size(258, 39);
            txt_giaSP.TabIndex = 15;
            // 
            // txt_ncc
            // 
            txt_ncc.Font = new Font("Segoe UI", 12F);
            txt_ncc.Location = new Point(266, 189);
            txt_ncc.Name = "txt_ncc";
            txt_ncc.Size = new Size(222, 39);
            txt_ncc.TabIndex = 17;
            // 
            // txt_soluongton
            // 
            txt_soluongton.Anchor = AnchorStyles.Top;
            txt_soluongton.Font = new Font("Segoe UI", 12F);
            txt_soluongton.Location = new Point(701, 109);
            txt_soluongton.Name = "txt_soluongton";
            txt_soluongton.Size = new Size(258, 39);
            txt_soluongton.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(56, 109);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 19;
            label1.Text = "Mô Tả Sản Phẩm";
            // 
            // txt_mota
            // 
            txt_mota.Font = new Font("Segoe UI", 12F);
            txt_mota.Location = new Point(266, 109);
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(222, 39);
            txt_mota.TabIndex = 20;
            // 
            // cbx_trangthai
            // 
            cbx_trangthai.Anchor = AnchorStyles.Top;
            cbx_trangthai.Font = new Font("Segoe UI", 12F);
            cbx_trangthai.FormattingEnabled = true;
            cbx_trangthai.Items.AddRange(new object[] { "Hoạt Động", "Ngừng Kinh Doanh" });
            cbx_trangthai.Location = new Point(701, 188);
            cbx_trangthai.Name = "cbx_trangthai";
            cbx_trangthai.Size = new Size(260, 40);
            cbx_trangthai.TabIndex = 21;
            cbx_trangthai.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(522, 258);
            label6.Name = "label6";
            label6.Size = new Size(58, 32);
            label6.TabIndex = 4;
            label6.Text = "Sale";
            // 
            // cbx_sale
            // 
            cbx_sale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbx_sale.FormattingEnabled = true;
            cbx_sale.Location = new Point(701, 258);
            cbx_sale.Name = "cbx_sale";
            cbx_sale.Size = new Size(260, 40);
            cbx_sale.TabIndex = 22;
            // 
            // Frm_SanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1373, 753);
            Controls.Add(cbx_sale);
            Controls.Add(cbx_trangthai);
            Controls.Add(txt_mota);
            Controls.Add(label1);
            Controls.Add(txt_soluongton);
            Controls.Add(txt_ncc);
            Controls.Add(txt_giaSP);
            Controls.Add(txt_tensp);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Frm_SanPham";
            Text = "Sản Phẩm";
            Load += Frm_SanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Data).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Image).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_Data;
        private PictureBox ptb_Image;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txt_timkiem;
        private Label label5;
        private Label label7;
        private Label label8;
        private GroupBox groupBox2;
        private TextBox txt_tensp;
        private TextBox txt_giaSP;
        private TextBox txt_ncc;
        private Button btn_tim;
        private Button btn_Show;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private TextBox txt_soluongton;
        private Label label1;
        private TextBox txt_mota;
        private ComboBox cbx_trangthai;
        private Label label6;
        private ComboBox cbx_sale;
    }
}