namespace C_PRL.Forms
{
    partial class cpn_banhang
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
            btn_Mua = new Button();
            txt_SLBan = new TextBox();
            lb_SLValue = new Label();
            lb_SoLuong = new Label();
            lb_GiaValue = new Label();
            lb_Gia = new Label();
            lb_Ten = new Label();
            ptb_Img = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptb_Img).BeginInit();
            SuspendLayout();
            // 
            // btn_Mua
            // 
            btn_Mua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Mua.Location = new Point(207, 193);
            btn_Mua.Name = "btn_Mua";
            btn_Mua.Size = new Size(115, 42);
            btn_Mua.TabIndex = 18;
            btn_Mua.Text = "Bán";
            btn_Mua.UseVisualStyleBackColor = true;
            // 
            // txt_SLBan
            // 
            txt_SLBan.Location = new Point(8, 199);
            txt_SLBan.Name = "txt_SLBan";
            txt_SLBan.PlaceholderText = "Nhập SL Bán";
            txt_SLBan.Size = new Size(193, 31);
            txt_SLBan.TabIndex = 17;
            // 
            // lb_SLValue
            // 
            lb_SLValue.AutoSize = true;
            lb_SLValue.Location = new Point(207, 144);
            lb_SLValue.Name = "lb_SLValue";
            lb_SLValue.Size = new Size(24, 25);
            lb_SLValue.TabIndex = 16;
            lb_SLValue.Text = "...";
            // 
            // lb_SoLuong
            // 
            lb_SoLuong.AutoSize = true;
            lb_SoLuong.Location = new Point(207, 119);
            lb_SoLuong.Name = "lb_SoLuong";
            lb_SoLuong.Size = new Size(89, 25);
            lb_SoLuong.TabIndex = 15;
            lb_SoLuong.Text = "Số Lượng";
            // 
            // lb_GiaValue
            // 
            lb_GiaValue.AutoSize = true;
            lb_GiaValue.Location = new Point(207, 81);
            lb_GiaValue.Name = "lb_GiaValue";
            lb_GiaValue.Size = new Size(24, 25);
            lb_GiaValue.TabIndex = 14;
            lb_GiaValue.Text = "...";
            // 
            // lb_Gia
            // 
            lb_Gia.AutoSize = true;
            lb_Gia.Location = new Point(207, 56);
            lb_Gia.Name = "lb_Gia";
            lb_Gia.Size = new Size(62, 25);
            lb_Gia.TabIndex = 13;
            lb_Gia.Text = "Giá SP";
            // 
            // lb_Ten
            // 
            lb_Ten.AutoSize = true;
            lb_Ten.Location = new Point(206, 9);
            lb_Ten.Name = "lb_Ten";
            lb_Ten.Size = new Size(51, 25);
            lb_Ten.TabIndex = 12;
            lb_Ten.Text = "Coca";
            // 
            // ptb_Img
            // 
            ptb_Img.Location = new Point(7, 9);
            ptb_Img.Name = "ptb_Img";
            ptb_Img.Size = new Size(193, 160);
            ptb_Img.TabIndex = 11;
            ptb_Img.TabStop = false;
            // 
            // cpn_banhang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 244);
            Controls.Add(btn_Mua);
            Controls.Add(txt_SLBan);
            Controls.Add(lb_SLValue);
            Controls.Add(lb_SoLuong);
            Controls.Add(lb_GiaValue);
            Controls.Add(lb_Gia);
            Controls.Add(lb_Ten);
            Controls.Add(ptb_Img);
            Name = "cpn_banhang";
            Text = "cpn_banhang";
            ((System.ComponentModel.ISupportInitialize)ptb_Img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Mua;
        private TextBox txt_SLBan;
        private Label lb_SLValue;
        private Label lb_SoLuong;
        private Label lb_GiaValue;
        private Label lb_Gia;
        private Label lb_Ten;
        private PictureBox ptb_Img;
    }
}