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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            button6 = new Button();
            btn_Close = new Button();
            btn_Show = new Button();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            btn_Them = new Button();
            label4 = new Label();
            txt_timkiem = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            txt_masp = new TextBox();
            txt_tensp = new TextBox();
            txt_loaisp = new TextBox();
            txt_trangthai = new TextBox();
            txt_giaSP = new TextBox();
            txt_ncc = new TextBox();
            txt_soluongton = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_Data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_Data
            // 
            dtg_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Data.Location = new Point(6, 82);
            dtg_Data.Name = "dtg_Data";
            dtg_Data.RowHeadersWidth = 62;
            dtg_Data.Size = new Size(1210, 237);
            dtg_Data.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 174);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 38);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 2;
            label1.Text = "Mã Sản Phẩm";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 81);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 3;
            label2.Text = "Số Lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 129);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Mã NCC";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(btn_Close);
            groupBox1.Controls.Add(btn_Show);
            groupBox1.Controls.Add(btn_Xoa);
            groupBox1.Controls.Add(btn_Sua);
            groupBox1.Controls.Add(btn_Them);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_timkiem);
            groupBox1.Controls.Add(dtg_Data);
            groupBox1.Location = new Point(-1, 261);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1213, 403);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bảng Chi Tiết Sản Phẩm";
            // 
            // button6
            // 
            button6.Location = new Point(369, 25);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 8;
            button6.Text = "Tìm";
            button6.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(710, 349);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(112, 34);
            btn_Close.TabIndex = 7;
            btn_Close.Text = "Đóng";
            btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Show
            // 
            btn_Show.Location = new Point(538, 349);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(112, 34);
            btn_Show.TabIndex = 6;
            btn_Show.Text = "Hiển Thị DS";
            btn_Show.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(369, 349);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(112, 34);
            btn_Xoa.TabIndex = 5;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(204, 349);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(112, 34);
            btn_Sua.TabIndex = 4;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(38, 349);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(112, 34);
            btn_Them.TabIndex = 3;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 27);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 2;
            label4.Text = "Tìm Kiếm";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(148, 27);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(188, 31);
            txt_timkiem.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 78);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 6;
            label5.Text = "Tên Sản Phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 123);
            label6.Name = "label6";
            label6.Size = new Size(128, 25);
            label6.TabIndex = 7;
            label6.Text = "Loại Sản Phẩm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 171);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 8;
            label7.Text = "Trạng Thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(449, 32);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 9;
            label8.Text = "Đơn Giá";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(819, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 217);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ảnh Sản Phẩm";
            // 
            // txt_masp
            // 
            txt_masp.Location = new Point(185, 32);
            txt_masp.Name = "txt_masp";
            txt_masp.Size = new Size(196, 31);
            txt_masp.TabIndex = 11;
            // 
            // txt_tensp
            // 
            txt_tensp.Location = new Point(185, 75);
            txt_tensp.Name = "txt_tensp";
            txt_tensp.Size = new Size(196, 31);
            txt_tensp.TabIndex = 12;
            // 
            // txt_loaisp
            // 
            txt_loaisp.Location = new Point(185, 123);
            txt_loaisp.Name = "txt_loaisp";
            txt_loaisp.Size = new Size(196, 31);
            txt_loaisp.TabIndex = 13;
            // 
            // txt_trangthai
            // 
            txt_trangthai.Location = new Point(185, 165);
            txt_trangthai.Name = "txt_trangthai";
            txt_trangthai.Size = new Size(196, 31);
            txt_trangthai.TabIndex = 14;
            // 
            // txt_giaSP
            // 
            txt_giaSP.Location = new Point(562, 26);
            txt_giaSP.Name = "txt_giaSP";
            txt_giaSP.Size = new Size(214, 31);
            txt_giaSP.TabIndex = 15;
            // 
            // txt_ncc
            // 
            txt_ncc.Location = new Point(562, 126);
            txt_ncc.Name = "txt_ncc";
            txt_ncc.Size = new Size(214, 31);
            txt_ncc.TabIndex = 17;
            // 
            // txt_soluongton
            // 
            txt_soluongton.Location = new Point(562, 81);
            txt_soluongton.Name = "txt_soluongton";
            txt_soluongton.Size = new Size(214, 31);
            txt_soluongton.TabIndex = 18;
            // 
            // Frm_SanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 663);
            Controls.Add(txt_soluongton);
            Controls.Add(txt_ncc);
            Controls.Add(txt_giaSP);
            Controls.Add(txt_trangthai);
            Controls.Add(txt_loaisp);
            Controls.Add(txt_tensp);
            Controls.Add(txt_masp);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_SanPham";
            Text = "Frm_SanPham";
            Load += Frm_SanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Data).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_Data;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txt_timkiem;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox2;
        private TextBox txt_masp;
        private TextBox txt_tensp;
        private TextBox txt_loaisp;
        private TextBox txt_trangthai;
        private TextBox txt_giaSP;
        private TextBox txt_ncc;
        private Button button6;
        private Button btn_Close;
        private Button btn_Show;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private TextBox txt_soluongton;
    }
}