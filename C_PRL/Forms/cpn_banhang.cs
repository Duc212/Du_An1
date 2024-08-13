using Aa_DAL.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.Forms
{
    public partial class cpn_banhang : Form
    {
        public cpn_banhang()
        {
            InitializeComponent();
        }
        public Panel CreateSp(SanPham sp )
        {
            Button btn_Mua = new Button();
            TextBox txt_SLBan = new TextBox();
            Label lb_SLValue = new Label();
            Label lb_SoLuong = new Label();
            Label lb_GiaValue = new Label();
            Label lb_Gia = new Label();
            Label lb_Ten = new Label();
            PictureBox ptb_Img = new PictureBox();

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
            lb_SLValue.Text = sp.SoLuongTon.ToString();
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
            lb_GiaValue.Text = sp.Gia.ToString();

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
            lb_Ten.Text = sp.TenSanPham;
            // 
            // pictureBox1
            // 
            ptb_Img.Location = new Point(7, 9);
            ptb_Img.Name = "ptb_Img";
            ptb_Img.Size = new Size(193, 160);
            ptb_Img.TabIndex = 11;
            ptb_Img.TabStop = false;
            ptb_Img.ImageLocation = sp.ImgURL;
            // 
            // cpn_banhang
            // 
            Panel pn = new Panel();
            pn.Size = new Size(350, 300);
            pn.Name = sp.Id.ToString(); 
            pn.Controls.Add(btn_Mua);
            pn.Controls.Add(txt_SLBan);
            pn.Controls.Add(lb_SLValue);
            pn.Controls.Add(lb_SoLuong);
            pn.Controls.Add(lb_GiaValue);
            pn.Controls.Add(lb_Gia);
            pn.Controls.Add(lb_Ten);
            pn.Controls.Add(ptb_Img);

            return pn;
        }
    }
}
