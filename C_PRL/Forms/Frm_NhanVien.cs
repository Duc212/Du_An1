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
    public partial class Frm_NhanVien : Form
    {
        NhanVienService _service;
        public Frm_NhanVien()
        {
            InitializeComponent();
            _service = new NhanVienService();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string taikhoan = txt_taikhoan.Text;
            string matkhau = txt_matkhau.Text;
            int vaitro = cbx_Vaitro.SelectedIndex;
            if (string.IsNullOrEmpty(taikhoan) || string.IsNullOrEmpty(matkhau) || vaitro == 0)
            {
                MessageBox.Show("Thông tin Nhập sai");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn thêm chứ", "Thêm Tài Khoan", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string message = _service.CreateNV(taikhoan, matkhau, vaitro);
                    MessageBox.Show(message);
                    LoadDataToGridView();
                }

            }
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();

        }
        public void LoadDataToGridView()
        {
            dtg_Data.DataSource = null;
            var data = _service.GetNhanViens();
            dtg_Data.DataSource = data;
        }

        private void dtg_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_Data.Rows[e.RowIndex];
            txt_taikhoan.Text = row.Cells[0].Value.ToString();
            txt_matkhau.Text = row.Cells[1].Value.ToString();
            cbx_Vaitro.SelectedIndex = Convert.ToInt32(row.Cells[2].Value);

        }

        private void btn_Khoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn khóa tài khoản này", "Khóa Tài Khoản", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string taikhoan = txt_taikhoan.Text;
                string message = _service.KhoaNV(taikhoan);
                MessageBox.Show(message);
                LoadDataToGridView();
            }

        }

        private void btn_MoKhoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn mở khóa tài khoản này", "Mở Khóa Tài Khoản", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string taikhoan = txt_taikhoan.Text;
                string message = _service.MoKhoaNV(taikhoan);
                MessageBox.Show(message);
                LoadDataToGridView();
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn Sửa khóa tài khoản này", "Sửa Tài Khoản", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string taikhoan = txt_taikhoan.Text;
                string password = txt_matkhau.Text;
                int vaitro = cbx_Vaitro.SelectedIndex;
                MessageBox.Show(_service.UpdateNV(taikhoan, password, vaitro));
                LoadDataToGridView();
            }


        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn Xóa khóa tài khoản này", "Xóa Tài Khoản", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var deleteresult = _service.XoaNV(txt_taikhoan.Text);
                MessageBox.Show(deleteresult);
                LoadDataToGridView();
            }

        }
    }
}
