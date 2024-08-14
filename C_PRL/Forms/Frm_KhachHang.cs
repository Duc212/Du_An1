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
    public partial class Frm_KhachHang : Form
    {
        KhachHangService _service;
        public Frm_KhachHang()
        {
            _service = new KhachHangService();
            InitializeComponent();
        }

        private void dtg_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_Data.Rows[e.RowIndex];

            txt_ten.Text = row.Cells[1].Value.ToString();
            txt_sodienThoai.Text = row.Cells[2].Value.ToString();
            txt_diem.Text = row.Cells[3].Value.ToString();

        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            LoadData(_service.GetKhachHangs());
        }
        private void LoadData(dynamic data)
        {
            dtg_Data.Rows.Clear();
            dtg_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int stt = 1;
            dtg_Data.ColumnCount = 4;
            dtg_Data.Columns[0].Name = "stt"; dtg_Data.Columns[0].HeaderText = "Số Thứ Tự";
            dtg_Data.Columns[1].Name = "sdt"; dtg_Data.Columns[1].HeaderText = "Số Điện Thoại";
            dtg_Data.Columns[2].Name = "ten"; dtg_Data.Columns[2].HeaderText = "Tên khách Hàng";
            dtg_Data.Columns[3].Name = "diem"; dtg_Data.Columns[3].HeaderText = "Điểm";




            foreach (var item in data)
            {
                dtg_Data.Rows.Add(stt++, item.SoDienThoai, item.TenKH, item.Diem);
            }

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sodienthoai = txt_sodienThoai.Text;
            string name = txt_ten.Text;
            int point = 0;
            _service.themKH(sodienthoai, name, point);
            LoadData(_service.GetKhachHangs());

        }
    }
}
