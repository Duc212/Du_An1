using Aa_DAL.Models;
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
    public partial class Frm_SanPham : Form
    {
        SaleService _saleService;
        SanPhamServices _services;
        Guid _selectedId;
        List<Sale> _activeSales;
        public Frm_SanPham()
        {

            _services = new SanPhamServices();
            _saleService = new SaleService();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadData(dynamic data)
        {
            dtg_Data.Rows.Clear();
            dtg_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int stt = 1;
            dtg_Data.ColumnCount = 10;
            dtg_Data.Columns[0].Name = "stt"; dtg_Data.Columns[0].HeaderText = "Số Thứ Tự";
            dtg_Data.Columns[1].Name = "ten"; dtg_Data.Columns[1].HeaderText = "Tên Sản Phẩm";
            dtg_Data.Columns[2].Name = "mota"; dtg_Data.Columns[2].HeaderText = "Mô tả sản phẩm";
            dtg_Data.Columns[3].Name = "ncc"; dtg_Data.Columns[3].HeaderText = "Nhà Cung Cấp";
            dtg_Data.Columns[4].Name = "gia"; dtg_Data.Columns[4].HeaderText = "Giá";
            dtg_Data.Columns[5].Name = "soluong"; dtg_Data.Columns[5].HeaderText = "Sô lượng";
            dtg_Data.Columns[6].Name = "trangthai"; dtg_Data.Columns[6].HeaderText = "Trạng Thái";
            dtg_Data.Columns[7].Name = "imgurl";
            dtg_Data.Columns[7].Visible = false;
            dtg_Data.Columns[8].Name = "id";
            dtg_Data.Columns[8].Visible = false; // An cot ID
            dtg_Data.Columns[9].Name = "sale"; dtg_Data.Columns[6].HeaderText = "SaleID";





            foreach (var item in data)
            {
                dtg_Data.Rows.Add(stt++, item.TenSanPham, item.MoTa, item.NhaCungCap, item.Gia,
                    item.SoLuongTon, item.TrangThai, item.ImgURL, item.Id, item.SaleId);
            }

        }
        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            _activeSales = _saleService.GetActiveSales(); //DS Sale ON
            foreach(var item in _activeSales)
            {
                cbx_sale.Items.Add(item.Name);
            }
            LoadData(_services.GetAllSanPhams());
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sanpham = new SanPham()
                {
                    Id = Guid.NewGuid(),
                    TenSanPham = txt_tensp.Text,
                    NhaCungCap = txt_ncc.Text,
                    MoTa = txt_mota.Text,
                    Gia = long.Parse(txt_giaSP.Text),
                    SoLuongTon = int.Parse(txt_soluongton.Text),
                    TrangThai = cbx_trangthai.SelectedIndex,
                    ImgURL = ptb_Image.ImageLocation,
                    SaleId = _activeSales[cbx_sale.SelectedIndex].Id,
                };
                MessageBox.Show(_services.TaoSanPham(sanpham));
                LoadData(_services.GetAllSanPhams());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập số.");
                MessageBox.Show(ex.Message);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ptb_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            ptb_Image.ImageLocation = dialog.FileName;
            ptb_Image.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void dtg_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_Data.Rows[e.RowIndex];

            txt_tensp.Text = row.Cells[1].Value.ToString();
            txt_mota.Text = row.Cells[2].Value.ToString();
            txt_ncc.Text = row.Cells[3].Value.ToString();
            txt_giaSP.Text = row.Cells[4].Value.ToString();
            txt_soluongton.Text = row.Cells[5].Value.ToString();
            cbx_trangthai.SelectedIndex = int.Parse(row.Cells[6].Value.ToString());
            ptb_Image.ImageLocation = row.Cells[7].Value.ToString();
            _selectedId = Guid.Parse(row.Cells[8].Value.ToString());
            //cbx_sale.SelectedIndex = int.Parse(row.Cells[9].Value.ToString());
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            LoadData(_services.TimTheoTen(txt_timkiem.Text));
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa sản phẩm này?", "Sửa sản phẩm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string tensanpham = txt_tensp.Text;
                    string mota = txt_mota.Text;
                    string img = ptb_Image.ImageLocation;
                    int trangthai = cbx_trangthai.SelectedIndex;
                    long gia = long.Parse(txt_giaSP.Text);
                    int soluongton = int.Parse(txt_soluongton.Text);
                    string ncc = txt_ncc.Text;
                    Guid id = _selectedId;
                    Guid saleId = _activeSales[cbx_sale.SelectedIndex].Id;
                    MessageBox.Show(_services.UpdateSanPham(id, tensanpham, mota, img, trangthai, gia, soluongton, ncc, saleId));
                    LoadData(_services.GetAllSanPhams());

                }
                catch (Exception)
                {

                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ.");

                }

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn Xóa khóa Sản Phẩm này", "Xóa Sản Phẩm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var deleteresult = _services.XoaSanPham(_selectedId);
                    MessageBox.Show(deleteresult);
                    LoadData(_services.GetAllSanPhams());
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Xóa Thất Bại.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
