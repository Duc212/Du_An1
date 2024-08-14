using B_BUS.Services;
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
        string _tkNhanvien;
        public Frm_Main(string tkNhanvien)
        {
            InitializeComponent();
            this._tkNhanvien = tkNhanvien;

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            string[] infor = _tkNhanvien.Split(":");
            lb_account.Text = infor[1];
            if (infor[0] == "2")
            {
                btn_NhanVien.Visible = false;
                btn_SanPham.Visible = false;

            }
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear();
            Frm_BanHang frm_BanHang = new Frm_BanHang();
            frm_BanHang.TopLevel = false;
            pn_Show.Controls.Add(frm_BanHang);
            frm_BanHang.FormBorderStyle = FormBorderStyle.None;
            lb_title.Text = frm_BanHang.Text;
            frm_BanHang.Dock = DockStyle.Fill;
            frm_BanHang.Show();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear();
            Frm_SanPham frm_SanPham = new Frm_SanPham();
            frm_SanPham.TopLevel = false;
            pn_Show.Controls.Add(frm_SanPham);
            frm_SanPham.FormBorderStyle = FormBorderStyle.None;
            frm_SanPham.BringToFront();
            lb_title.Text = frm_SanPham.Text;
            frm_SanPham.Dock = DockStyle.Fill;
            frm_SanPham.Show();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear();
            Frm_KhachHang frm_KhachHang = new Frm_KhachHang();
            frm_KhachHang.TopLevel = false;
            pn_Show.Controls.Add(frm_KhachHang);
            frm_KhachHang.FormBorderStyle = FormBorderStyle.None;
            frm_KhachHang.Dock = DockStyle.Fill;
            lb_title.Text = frm_KhachHang.Text;

            frm_KhachHang.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear();
            Frm_NhanVien frm_NhanVien = new Frm_NhanVien();
            frm_NhanVien.TopLevel = false;
            pn_Show.Controls.Add(frm_NhanVien);
            frm_NhanVien.FormBorderStyle = FormBorderStyle.None;
            frm_NhanVien.Dock = DockStyle.Fill;
            lb_title.Text = frm_NhanVien.Text;
            frm_NhanVien.Show();
        }

        private void pn_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GiamGia_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear();
            Frm_Sale frm_Sale = new Frm_Sale();
            frm_Sale.TopLevel = false;
            pn_Show.Controls.Add(frm_Sale);
            frm_Sale.FormBorderStyle = FormBorderStyle.None;
            frm_Sale.Dock = DockStyle.Fill;
            lb_title.Text = frm_Sale.Text;
            frm_Sale.Show();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            pn_Show.Controls.Clear();
            Frm_LichSuHoaDon frm_HoaDon = new Frm_LichSuHoaDon();
            frm_HoaDon.TopLevel = false;
            pn_Show.Controls.Add(frm_HoaDon);
            frm_HoaDon.FormBorderStyle = FormBorderStyle.None;
            frm_HoaDon.Dock = DockStyle.Fill;
            lb_title.Text = frm_HoaDon.Text;
            frm_HoaDon.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_account_Click(object sender, EventArgs e)
        {

        }
    }
}
