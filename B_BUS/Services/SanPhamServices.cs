using Aa_DAL.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            if(sanPham.TenSanPham.Trim() == "" || sanPham.MoTa.Trim() == ""|| sanPham.NhaCungCap.Trim() == "")
            {
                return "Hãy kiểm tra lại dữ liệu không được để trống";
            }else if(sanPham.Gia < 0 || sanPham.SoLuongTon < 0)
            {
                return "Giá sản phẩm và số lượng sai ";
            }else if (string.IsNullOrEmpty(sanPham.ImgURL))
            {
                return "Thieu Anh ";
            }
            else
            {
                try
                {
                    _context.SanPhams.Add(sanPham);
                    _context.SaveChanges();
                    return "Thêm sản phẩm thành công";
                }
                catch (Exception ex)
                {
                    return "Them That Bai" + ex.Message +ex.InnerException ;
                }
            }
           
        }
        public string XoaSanPham(Guid id)
        {
            var deleteSp = _context.SanPhams.Find(id);
            try
            {
                _context.SanPhams.Remove(deleteSp);
                _context.SaveChanges();
                return "Xóa Thành Công";
            }
            catch (Exception ex)
            {
                return ex.Message;
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
        public string UpdateSanPham(Guid id,string tenSanPham,string moTa,string imgURL,int trangthai,long gia,int soluongton,string ncc,Guid saleId )
        {
            
            var updateSanPham = _context.SanPhams.Find(id);
            if (updateSanPham == null)
            {
                return "Không tìm thấy sản phẩm  cần sửa";
            }
            else
            {
                updateSanPham.TenSanPham = tenSanPham;
                updateSanPham.MoTa = moTa;
                updateSanPham.ImgURL = imgURL;
                updateSanPham.TrangThai = trangthai;
                updateSanPham.Gia = gia;
                updateSanPham.SoLuongTon = soluongton;
                updateSanPham.NhaCungCap = ncc;
                updateSanPham.SaleId = saleId;
                try
                    {
                        _context.SanPhams.Update(updateSanPham);
                        _context.SaveChanges();
                        return "Sua Thanh Cong";
                    }
                    catch (Exception ex)
                    {

                        return "Sua That Bai" + ex.Message +ex.InnerException;
                    }
            }
            
         
        }
       
    }
}
