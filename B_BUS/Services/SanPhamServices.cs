using Aa_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class SanPhamServices
    {
        AppDBContext _context;
        public SanPhamServices()
        {
            _context = new AppDBContext();
        }
        public List<SanPham> GetAllSanPhams() 
        {
            return _context.SanPhams.ToList();
        }
        public string TaoSanPham(SanPham sanPham)
        {
            try
            {
                _context.SanPhams.Add(sanPham);
                _context.SaveChanges();
                return "Thêm sản phẩm thành công";
            }
            catch (Exception ex)
            {
                return "Them That Bai" + ex.Message;
            }
        }
        public List<SanPham> TimTheoTen(string tensanpham)
        {
            return _context.SanPhams.Where
                (p=> p.TenSanPham.ToLower().Contains(tensanpham.ToLower())).ToList();

        }
        public string KhoaSP(Guid id)
        {
            var sanpham = _context.SanPhams.Find(id);
            if (sanpham.TrangThai == 0) return "Sản Phẩm Không bị Khóa ,Không thể mở khóa";
            else
            {
                sanpham.TrangThai  = 0;
                _context.SaveChanges();
                return "Khoa San Pham Thanh Cong";
            }
        }
        public string MoKhoaSanPham(Guid id)
        {
            var sanpham = _context.SanPhams.Find(id);
            if (sanpham.TrangThai != 0) return "Sản Phẩm Không bị Khóa ,Không thể mở khóa";
            else
            {
                sanpham.TrangThai = 1; 
                _context.SaveChanges();
                return "Khoa San Pham Thanh Cong";
            }
        }
        public string UpdateSanPham(SanPham sanpham)
        {
            var updateSanPham = _context.SanPhams.Find(sanpham.Id);
            updateSanPham.TenSanPham = sanpham.TenSanPham;
            updateSanPham.ImgURL = sanpham.ImgURL;
            updateSanPham.TrangThai = sanpham.TrangThai;
            updateSanPham.Gia = sanpham.Gia;
            updateSanPham.SoLuongTon = sanpham.SoLuongTon;
            updateSanPham.NhaCungCap = sanpham.NhaCungCap;

            _context.SanPhams.Update(updateSanPham);
            _context.SaveChanges();
            return "Sua Thanh Cong";
        }
       
    }
}
