using Aa_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class KhachHangService
    {
        AppDBContext _context;
        public KhachHangService()
        {
            _context = new AppDBContext();
        }
        public List<KhachHang> GetKhachHangs()
        {
            return _context.KhachHangs.ToList();
        }
        public List<KhachHang> GetBySDT(string sodienthoai)
        {
            
            return _context.KhachHangs.Where(p => p.SoDienThoai.Contains(sodienthoai)).ToList();
        }
        public void themKH(string sodienthoai, string name, int point = 0  )
        {
            
                KhachHang khachhang = new KhachHang()
                {
                    SoDienThoai = sodienthoai,
                    TenKH = name,
                    Diem  = point

                };
                _context.KhachHangs.Add(khachhang);
                _context.SaveChanges();
            
            
        }
        public string suaKH(string sodienthoai, string name, int point)
        {
            var suaKH = _context.KhachHangs.Find(sodienthoai);
            suaKH.SoDienThoai = sodienthoai;
            suaKH.TenKH = name;
            suaKH.Diem=point;

            try
            {
                _context.KhachHangs.Update(suaKH);
                _context.SaveChanges();
                return "Cập nhật khách hàng thành công";
            }
            catch (Exception ex)
            {

                return "Sửa thất bại";
            }
        } 
        public string xoaKH(string sodienthoai)
        {
            var deleteKh = _context.KhachHangs.Find(sodienthoai);
            try
            {
                _context.KhachHangs.Remove(deleteKh);
                _context.SaveChanges();
                return "Xoa KH Thanh Cong";
            }
            catch (Exception ex)
            {

                return "Xoa That Bai" ;
            }
        }
    }
}
