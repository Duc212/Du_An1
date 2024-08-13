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
    public partial class Frm_login : Form
    {
        NhanVienService _nhanVienService;
        public Frm_login()
        {
            InitializeComponent();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            _nhanVienService = new NhanVienService();
            string taikhoan = txt_taikhoan.Text;
            string matkhau = txt_matkhau.Text;
            string tkNhanvien = _nhanVienService.Login(taikhoan, matkhau);
            if (string.IsNullOrEmpty(tkNhanvien))
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
            }else if (tkNhanvien.Split(':')[0] == "0")
            {
                MessageBox.Show("Tai Khoan Cua Ban Da Bi Khoa");
            }
            else
            {

                Frm_Main main = new Frm_Main(tkNhanvien);
                //main.FormBorderStyle = FormBorderStyle.None;
                this.Hide();
                main.ShowDialog();
                this.Show();
                txt_taikhoan.Text = "";
                txt_matkhau.Text = "";
            }
        }

        private void cbx_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_ShowPass.Checked) 
            {
                txt_matkhau.PasswordChar = '\0';
            }
            else
            {
                txt_matkhau.PasswordChar = '*';
            }

            
        }
    }
}
