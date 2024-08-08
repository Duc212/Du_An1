namespace C_PRL.Forms
{
    partial class Frm_NhanVien
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_taikhoan = new TextBox();
            txt_matkhau = new TextBox();
            cbx_Vaitro = new ComboBox();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Khoa = new Button();
            btn_MoKhoa = new Button();
            btn_Xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_Data).BeginInit();
            SuspendLayout();
            // 
            // dtg_Data
            // 
            dtg_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Data.Location = new Point(12, 388);
            dtg_Data.Name = "dtg_Data";
            dtg_Data.RowHeadersWidth = 62;
            dtg_Data.Size = new Size(1119, 263);
            dtg_Data.TabIndex = 0;
            dtg_Data.CellClick += dtg_Data_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(80, 28);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 1;
            label1.Text = "Tai Khoan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(80, 91);
            label2.Name = "label2";
            label2.Size = new Size(113, 30);
            label2.TabIndex = 2;
            label2.Text = "Mat Khau";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(80, 155);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 3;
            label3.Text = "Vai Tro";
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txt_taikhoan.Location = new Point(243, 34);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(578, 34);
            txt_taikhoan.TabIndex = 4;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txt_matkhau.Location = new Point(243, 101);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(578, 34);
            txt_matkhau.TabIndex = 5;
            // 
            // cbx_Vaitro
            // 
            cbx_Vaitro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cbx_Vaitro.FormattingEnabled = true;
            cbx_Vaitro.Items.AddRange(new object[] { "Khóa", "Admin", "Nhân Viên" });
            cbx_Vaitro.Location = new Point(243, 152);
            cbx_Vaitro.Name = "cbx_Vaitro";
            cbx_Vaitro.Size = new Size(352, 36);
            cbx_Vaitro.TabIndex = 6;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(80, 269);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(135, 59);
            btn_Them.TabIndex = 7;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(253, 269);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(135, 59);
            btn_Sua.TabIndex = 8;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Khoa
            // 
            btn_Khoa.Location = new Point(428, 269);
            btn_Khoa.Name = "btn_Khoa";
            btn_Khoa.Size = new Size(135, 59);
            btn_Khoa.TabIndex = 9;
            btn_Khoa.Text = "Khóa";
            btn_Khoa.UseVisualStyleBackColor = true;
            btn_Khoa.Click += btn_Khoa_Click;
            // 
            // btn_MoKhoa
            // 
            btn_MoKhoa.Location = new Point(593, 269);
            btn_MoKhoa.Name = "btn_MoKhoa";
            btn_MoKhoa.Size = new Size(135, 59);
            btn_MoKhoa.TabIndex = 10;
            btn_MoKhoa.Text = "Mở Khóa";
            btn_MoKhoa.UseVisualStyleBackColor = true;
            btn_MoKhoa.Click += btn_MoKhoa_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(759, 269);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(135, 59);
            btn_Xoa.TabIndex = 11;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // Frm_NhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 663);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_MoKhoa);
            Controls.Add(btn_Khoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(cbx_Vaitro);
            Controls.Add(txt_matkhau);
            Controls.Add(txt_taikhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtg_Data);
            Name = "Frm_NhanVien";
            Text = "Frm_NhanVien";
            Load += Frm_NhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_Data;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_taikhoan;
        private TextBox txt_matkhau;
        private ComboBox cbx_Vaitro;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Khoa;
        private Button btn_MoKhoa;
        private Button btn_Xoa;
    }
}