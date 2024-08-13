namespace C_PRL.Forms
{
    partial class Frm_Sale
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_ten = new TextBox();
            txt_mota = new TextBox();
            dtp_start = new DateTimePicker();
            dtp_end = new DateTimePicker();
            txt_ptgiam = new TextBox();
            cbx_trangthai = new ComboBox();
            groupBox1 = new GroupBox();
            dtg_Data = new DataGridView();
            btn_them = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Data).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(45, 30);
            label1.Name = "label1";
            label1.Size = new Size(52, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(45, 86);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 1;
            label2.Text = "Mô Tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(45, 146);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 2;
            label3.Text = "Bắt Đầu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(45, 212);
            label4.Name = "label4";
            label4.Size = new Size(108, 32);
            label4.TabIndex = 0;
            label4.Text = "Kết Thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(45, 268);
            label5.Name = "label5";
            label5.Size = new Size(188, 32);
            label5.TabIndex = 1;
            label5.Text = "Phần Trăm Giảm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(45, 329);
            label6.Name = "label6";
            label6.Size = new Size(125, 32);
            label6.TabIndex = 2;
            label6.Text = "Trạng Thái";
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(289, 25);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(667, 37);
            txt_ten.TabIndex = 3;
            // 
            // txt_mota
            // 
            txt_mota.Location = new Point(289, 81);
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(667, 37);
            txt_mota.TabIndex = 4;
            // 
            // dtp_start
            // 
            dtp_start.Location = new Point(289, 141);
            dtp_start.Name = "dtp_start";
            dtp_start.Size = new Size(400, 37);
            dtp_start.TabIndex = 5;
            // 
            // dtp_end
            // 
            dtp_end.Location = new Point(289, 209);
            dtp_end.Name = "dtp_end";
            dtp_end.Size = new Size(400, 37);
            dtp_end.TabIndex = 5;
            // 
            // txt_ptgiam
            // 
            txt_ptgiam.Location = new Point(289, 263);
            txt_ptgiam.Name = "txt_ptgiam";
            txt_ptgiam.Size = new Size(213, 37);
            txt_ptgiam.TabIndex = 6;
            // 
            // cbx_trangthai
            // 
            cbx_trangthai.FormattingEnabled = true;
            cbx_trangthai.Items.AddRange(new object[] { "Hoạt Động", "Ngừng Hoạt Động" });
            cbx_trangthai.Location = new Point(289, 323);
            cbx_trangthai.Name = "cbx_trangthai";
            cbx_trangthai.Size = new Size(323, 38);
            cbx_trangthai.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_Data);
            groupBox1.Location = new Point(45, 396);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1343, 323);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dtg_Data
            // 
            dtg_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Data.Location = new Point(6, 36);
            dtg_Data.Name = "dtg_Data";
            dtg_Data.RowHeadersWidth = 62;
            dtg_Data.Size = new Size(1331, 281);
            dtg_Data.TabIndex = 0;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(1093, 86);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(144, 58);
            btn_them.TabIndex = 9;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1093, 192);
            button2.Name = "button2";
            button2.Size = new Size(144, 58);
            button2.TabIndex = 10;
            button2.Text = "Sửa ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1093, 304);
            button3.Name = "button3";
            button3.Size = new Size(144, 58);
            button3.TabIndex = 11;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // Frm_Sale
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 718);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_them);
            Controls.Add(groupBox1);
            Controls.Add(cbx_trangthai);
            Controls.Add(txt_ptgiam);
            Controls.Add(dtp_end);
            Controls.Add(dtp_start);
            Controls.Add(txt_mota);
            Controls.Add(txt_ten);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Frm_Sale";
            Text = "Sale";
            Load += Frm_Sale_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_ten;
        private TextBox txt_mota;
        private DateTimePicker dtp_start;
        private DateTimePicker dtp_end;
        private TextBox txt_ptgiam;
        private ComboBox cbx_trangthai;
        private GroupBox groupBox1;
        private DataGridView dtg_Data;
        private Button btn_them;
        private Button button2;
        private Button button3;
    }
}