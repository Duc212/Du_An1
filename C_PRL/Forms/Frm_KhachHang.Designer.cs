namespace C_PRL.Forms
{
    partial class Frm_KhachHang
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
            btn_them = new Button();
            button2 = new Button();
            button3 = new Button();
            txt_ten = new TextBox();
            txt_sodienThoai = new TextBox();
            txt_diem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_Data).BeginInit();
            SuspendLayout();
            // 
            // dtg_Data
            // 
            dtg_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Data.Location = new Point(2, 380);
            dtg_Data.Name = "dtg_Data";
            dtg_Data.RowHeadersWidth = 62;
            dtg_Data.Size = new Size(1129, 271);
            dtg_Data.TabIndex = 0;
            dtg_Data.CellContentClick += dtg_Data_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 66);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên KH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 131);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 2;
            label2.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 191);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 3;
            label3.Text = "Điểm";
            // 
            // btn_them
            // 
            btn_them.Location = new Point(96, 271);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(135, 61);
            btn_them.TabIndex = 4;
            btn_them.Text = "Thêm Khách Hàng";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // button2
            // 
            button2.Location = new Point(345, 271);
            button2.Name = "button2";
            button2.Size = new Size(135, 61);
            button2.TabIndex = 5;
            button2.Text = "Cập Nhật Thông Tin";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(570, 271);
            button3.Name = "button3";
            button3.Size = new Size(135, 61);
            button3.TabIndex = 6;
            button3.Text = "Xóa Thông Tin";
            button3.UseVisualStyleBackColor = true;
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(219, 60);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(682, 31);
            txt_ten.TabIndex = 7;
            // 
            // txt_sodienThoai
            // 
            txt_sodienThoai.Location = new Point(219, 128);
            txt_sodienThoai.Name = "txt_sodienThoai";
            txt_sodienThoai.Size = new Size(682, 31);
            txt_sodienThoai.TabIndex = 8;
            // 
            // txt_diem
            // 
            txt_diem.Location = new Point(219, 185);
            txt_diem.Name = "txt_diem";
            txt_diem.Size = new Size(682, 31);
            txt_diem.TabIndex = 9;
            // 
            // Frm_KhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 663);
            Controls.Add(txt_diem);
            Controls.Add(txt_sodienThoai);
            Controls.Add(txt_ten);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_them);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtg_Data);
            Name = "Frm_KhachHang";
            Text = "Khách Hàng";
            Load += Frm_KhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_Data;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_them;
        private Button button2;
        private Button button3;
        private TextBox txt_ten;
        private TextBox txt_sodienThoai;
        private TextBox txt_diem;
    }
}