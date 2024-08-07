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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear();
            Frm_BanHang frm_BanHang = new Frm_BanHang();
            frm_BanHang.TopLevel = false;
            pn_Show.Controls.Add(frm_BanHang);
            frm_BanHang.FormBorderStyle = FormBorderStyle.None;
            frm_BanHang.Show();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear();
            Frm_SanPham frm_SanPham = new Frm_SanPham();
            frm_SanPham.TopLevel = false;
            pn_Show.Controls.Add(frm_SanPham);
            frm_SanPham.FormBorderStyle = FormBorderStyle.None;
            frm_SanPham.Show();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear();
            Frm_KhachHang frm_KhachHang = new Frm_KhachHang();
            frm_KhachHang.TopLevel = false;
            pn_Show.Controls.Add(frm_KhachHang);
            frm_KhachHang.FormBorderStyle = FormBorderStyle.None;
            frm_KhachHang.Show();
        }
    }
}
