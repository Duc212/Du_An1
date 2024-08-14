using Aa_DAL.Models;
using B_BUS.Services;
using C_PRL.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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
    public partial class Frm_BanHang : Form
    {
        List<SanPham> _sanPhams;
        List<KhachHang> _khachhangs;

        SanPhamServices _sanphamservice;
        SaleService _saleservice;
        KhachHangService _khachhangservice;
        HoaDonService _hoadonservice;
        HDCTServices _hdctservice;
        public Frm_BanHang()
        {
            _sanphamservice = new SanPhamServices();
            _hdctservice = new HDCTServices();
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {

        }

        public Panel CreateSp(SaleProduct sp)
        {
            Button btn_Mua = new Button();
            TextBox txt_SLBan = new TextBox();
            Label lb_SLValue = new Label();
            Label lb_SoLuong = new Label();
            Label lb_GiaValue = new Label();
            Label lb_Gia = new Label();
            Label lb_Ten = new Label();
            PictureBox ptb_Img = new PictureBox();
            Label lb_GiaMoi = new Label();

            // 
            // btn_Mua
            // 
            btn_Mua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Mua.Location = new Point(205, 172);
            btn_Mua.Name = "btn_Mua";
            btn_Mua.Size = new Size(115, 42);
            btn_Mua.TabIndex = 18;
            btn_Mua.Text = "Bán";
            btn_Mua.UseVisualStyleBackColor = true;
            btn_Mua.Click += Btn_Mua_Click;
            // 
            // txt_SLBan
            // 
            txt_SLBan.Location = new Point(205, 138);
            txt_SLBan.Name = "txt_SLBan";
            txt_SLBan.PlaceholderText = "Nhập SL Bán";
            txt_SLBan.Size = new Size(116, 31);
            txt_SLBan.TabIndex = 17;
            // 
            // lb_SLValue
            // 
            lb_SLValue.AutoSize = true;
            lb_SLValue.Location = new Point(206, 92);
            lb_SLValue.Name = "lb_SLValue";
            lb_SLValue.Size = new Size(24, 25);
            lb_SLValue.TabIndex = 16;
            lb_SLValue.Text = sp.SoLuongTon.ToString();
            // 
            // lb_SoLuong
            // 
            lb_SoLuong.AutoSize = true;
            lb_SoLuong.Location = new Point(206, 54);
            lb_SoLuong.Name = "lb_SoLuong";
            lb_SoLuong.Size = new Size(89, 25);
            lb_SoLuong.TabIndex = 15;
            lb_SoLuong.Text = "Số Lượng";
            // 
            // lb_GiaValue
            // 
            lb_GiaValue.AutoSize = true;
            lb_GiaValue.Location = new Point(72, 197);
            lb_GiaValue.Name = "lb_GiaValue";
            lb_GiaValue.Size = new Size(24, 25);
            lb_GiaValue.TabIndex = 14;
            lb_GiaValue.Text = sp.Gia.ToString();
            lb_GiaValue.Font = new Font(lb_Gia.Font, FontStyle.Strikeout);

            // 
            // lb_Gia
            // 
            lb_Gia.AutoSize = true;
            lb_Gia.Location = new Point(42, 172);
            lb_Gia.Name = "lb_Gia";
            lb_Gia.Size = new Size(121, 25);
            lb_Gia.TabIndex = 13;
            lb_Gia.Text = "Giá Sản Phẩm";
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
            ptb_Img.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // lb_GiaMoi
            lb_GiaMoi.AutoSize = true;
            lb_GiaMoi.Location = new Point(72, 222);
            lb_GiaMoi.Name = "lb_GiaMoi";
            lb_GiaMoi.Size = new Size(52, 25);
            lb_GiaMoi.TabIndex = 19;
            lb_GiaMoi.Text = sp.GiaSale.ToString();
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
            pn.Controls.Add(lb_GiaMoi);

            return pn;
        }

        private void Btn_Mua_Click(object? sender, EventArgs e)
        {
            _hdctservice = new HDCTServices();
            _hoadonservice = new HoaDonService();
            long gia = 0;
            int soluong = 0;
            //Lay thong tin panel chua san pham
            Button btn_Mua = sender as Button;
            Panel cpnSp = btn_Mua.Parent as Panel;
            //Lay danh sach label trong Panel 
            List<Label> labels = new List<Label>();
            List<TextBox> textboxs = new List<TextBox>();
            foreach (var item in cpnSp.Controls)
            {
                if (item is Label) labels.Add(item as Label);
                if (item is TextBox) textboxs.Add(item as TextBox);

            }
            foreach (var item in labels)
            {
                if (item.Name == "lb_GiaMoi")
                {
                    gia = Convert.ToInt64(item.Text); break;
                }
            }
            foreach (var item in textboxs)
            {
                if (item.Name == "txt_SLBan")
                {
                    soluong = Convert.ToInt32(item.Text); break;
                }
            }

            // Lay cac thuoc tinh can thiet
            Guid sanphamId = Guid.Parse(cpnSp.Name);

            Guid hoadonId = Guid.Parse(lb_MaHD.Text);



            long tongTien = _hdctservice.TinhTongTien(hoadonId);
            lb_TongTien.Text = tongTien.ToString("N0") + "VND";

            _hoadonservice.getTongTientoHD(hoadonId, tongTien);
            dtg_HoaDon.Refresh();
            _hdctservice.AddToHoaDon(hoadonId, sanphamId, gia, soluong);
            LoadHDCT(Guid.Parse(lb_MaHD.Text));
        }
        public void LoadHDCT(Guid hoadonId)
        {
            _hdctservice = new HDCTServices();
            dtg_HDCT.DataSource = null;
            var hdct = _hdctservice.getAllbyHoaDonId(hoadonId);
            dtg_HDCT.DataSource = hdct;
        }
        public void LoadProductbyPage(int page) // Load SP theo trang
        {
            tlp_SanPham.Controls.Clear();
            _sanPhams = _sanphamservice.GetAllSanPhams();
            _saleservice = new SaleService();
            var sales = _saleservice.GetActiveSales();
            //Join Table

            var saleProducts =
                from sanpham in _sanPhams
                join sale in sales
                on sanpham.SaleId equals sale.Id
                select new SaleProduct
                {
                    Id = sanpham.Id,
                    TenSanPham = sanpham.TenSanPham,
                    Gia = sanpham.Gia,
                    MoTa = sanpham.MoTa,
                    NhaCungCap = sanpham.NhaCungCap,
                    SoLuongTon = sanpham.SoLuongTon,
                    TrangThai = sanpham.TrangThai,
                    ImgURL = sanpham.ImgURL,
                    GiaSale = Convert.ToInt64(sanpham.Gia - (sanpham.Gia * sale.Percent / 100)),

                };
            if (page * 4 - 4 < saleProducts.ToList().Count)
            {
                Panel p1 = CreateSp(saleProducts.ToList()[page * 4 - 4]);
                tlp_SanPham.Controls.Add(p1, 0, 0);
            }
            if (page * 4 - 3 < saleProducts.ToList().Count)
            {
                Panel p2 = CreateSp(saleProducts.ToList()[page * 4 - 3]);
                tlp_SanPham.Controls.Add(p2, 0, 1);
            }
            if (page * 4 - 2 < saleProducts.ToList().Count)
            {
                Panel p3 = CreateSp(saleProducts.ToList()[page * 4 - 2]);
                tlp_SanPham.Controls.Add(p3, 1, 0);
            }
            if (page * 4 - 1 < saleProducts.ToList().Count)
            {
                Panel p4 = CreateSp(saleProducts.ToList()[page * 4 - 1]);
                tlp_SanPham.Controls.Add(p4, 1, 1);
            }
        }

        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            _hoadonservice = new HoaDonService();
            LoadProductbyPage(1);
            LoadDataHoadDon(_hoadonservice.GetHoaDonWait());
        }

        private void lb_Next_Click(object sender, EventArgs e)
        {
            var sanphams = _sanphamservice.GetAllSanPhams();
            int count = sanphams.Count;
            if (Convert.ToInt32(lb_Page.Text) < count / 4 && count % 4 == 0 ||
                Convert.ToInt32(lb_Page.Text) <= count / 4 && count % 4 != 0)
            {
                lb_Page.Text = Convert.ToInt32(lb_Page.Text) + 1 + "";
                LoadProductbyPage(Convert.ToInt32(lb_Page.Text));
            }
        }

        private void lb_Back_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_Page.Text) >= 2)
            {
                lb_Page.Text = Convert.ToInt32(lb_Page.Text) - 1 + "";
                LoadProductbyPage(Convert.ToInt32(lb_Page.Text));
            }
        }

        private void cbx_SDT_TextChanged(object sender, EventArgs e)
        {
            int index = cbx_SDT.SelectedIndex;
            txt_name.Text = _khachhangs[index].TenKH + "-" + _khachhangs[index].SoDienThoai;
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            cbx_SDT.Items.Clear();
            _khachhangservice = new KhachHangService();
            string timSdt = txt_sdt.Text;
            _khachhangs = _khachhangservice.GetBySDT(timSdt);
            foreach (var item in _khachhangs)
            {
                cbx_SDT.Items.Add(item.TenKH);
            }
        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            string accountId = "";
            var FormMain = this.Parent.Parent as Form;
            List<Label> labels = new List<Label>();
            foreach (var item in FormMain.Controls)
            {
                if (item is Label) labels.Add((Label)item);
                //Lay label trong Main
            }
            foreach (var label in labels)
            {
                if (label.Name == "lb_account")
                {
                    accountId = label.Text; break;
                }
            }

            _hoadonservice = new HoaDonService();
            _hoadonservice.TaoHoaDon(accountId, cbx_SDT.Text);
            LoadDataHoadDon(_hoadonservice.GetHoaDonWait());
        }

        public void LoadBill()
        {

            dtg_HoaDon.DataSource = null;
            _hoadonservice = new HoaDonService();
            var hoadon = _hoadonservice.GetHoaDonWait();
            dtg_HoaDon.DataSource = hoadon;
        }
        private void LoadDataHoadDon(dynamic data)
        {

            dtg_HoaDon.Rows.Clear();
            dtg_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int stt = 1;
            dtg_HoaDon.ColumnCount = 8;
            dtg_HoaDon.Columns[0].Name = "stt"; dtg_HoaDon.Columns[0].HeaderText = "STT";
            dtg_HoaDon.Columns[1].Name = "mahd"; dtg_HoaDon.Columns[1].HeaderText = "Mã HĐ";
            dtg_HoaDon.Columns[2].Name = "manv"; dtg_HoaDon.Columns[2].HeaderText = "Mã NV";
            dtg_HoaDon.Columns[3].Name = "manv"; dtg_HoaDon.Columns[3].HeaderText = "Mã KH";
            dtg_HoaDon.Columns[4].Name = "tongtien"; dtg_HoaDon.Columns[4].HeaderText = "Tổng Tiền";
            dtg_HoaDon.Columns[5].Name = "trangthai"; dtg_HoaDon.Columns[5].HeaderText = "Trạng Thái";
            dtg_HoaDon.Columns[6].Name = "ngaytao"; dtg_HoaDon.Columns[6].HeaderText = "Ngày Tạo";
            dtg_HoaDon.Columns[7].Name = "voucher"; dtg_HoaDon.Columns[7].HeaderText = "VoucherId";

            foreach (var item in data)
            {
                dtg_HoaDon.Rows.Add(stt++, item.Id, item.NhanVienId, item.DienThoaiKH, item.TongTien, item.TrangThai, item.NgayTao, item.VoucherId);

            }

        }
        private void LoadDataHDCT(dynamic data)
        {
            dtg_HDCT.Rows.Clear();
            dtg_HDCT.ColumnCount = 5;
        }
        private void dtg_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_HoaDon.Rows[e.RowIndex];
            lb_MaHD.Text = row.Cells[1].Value.ToString();
            txt_name.Text = row.Cells[3].Value.ToString();

            LoadHDCT(Guid.Parse(lb_MaHD.Text));
        }

        private void btn_xoahd_Click(object sender, EventArgs e)
        {
            Guid hoadonId = Guid.Parse(lb_MaHD.Text);

            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này ", "Xóa Hóa Đơn ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var deletehd = _hoadonservice.XoaHoaDon(hoadonId);
                    MessageBox.Show(deletehd);
                    LoadDataHoadDon(_hoadonservice.GetHoaDonWait());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_ThanhToan(object sender, EventArgs e)
        {
           
        }

        private void btn_TT_Click(object sender, EventArgs e)
        {
            Guid hoadonId = Guid.Parse(lb_MaHD.Text);

            try
            {
                DialogResult result = MessageBox.Show("Bạn muốn Thanh toán hóa đơn này chứ ", "Thanh Toán", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var thanhtoan = _hoadonservice.ThanhToan(hoadonId);
                    MessageBox.Show(thanhtoan);
                    LoadDataHoadDon(_hoadonservice.GetHoaDonWait());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
