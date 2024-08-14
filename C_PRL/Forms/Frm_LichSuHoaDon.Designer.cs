namespace C_PRL.Forms
{
    partial class Frm_LichSuHoaDon
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
            groupBox1 = new GroupBox();
            dtg_LichSu = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            dtg_SanPham = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_LichSu).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_SanPham).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_LichSu);
            groupBox1.Location = new Point(39, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1304, 340);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // dtg_LichSu
            // 
            dtg_LichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_LichSu.Location = new Point(36, 30);
            dtg_LichSu.Name = "dtg_LichSu";
            dtg_LichSu.RowHeadersWidth = 62;
            dtg_LichSu.Size = new Size(1237, 276);
            dtg_LichSu.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtg_SanPham);
            groupBox2.Location = new Point(39, 456);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1304, 380);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Sản Phẩm";
            // 
            // dtg_SanPham
            // 
            dtg_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_SanPham.Location = new Point(36, 60);
            dtg_SanPham.Name = "dtg_SanPham";
            dtg_SanPham.RowHeadersWidth = 62;
            dtg_SanPham.Size = new Size(1237, 279);
            dtg_SanPham.TabIndex = 0;
            // 
            // Frm_LichSuHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 879);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_LichSuHoaDon";
            Text = "Hóa Đơn";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_LichSu).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_SanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtg_LichSu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private DataGridView dtg_SanPham;
    }
}