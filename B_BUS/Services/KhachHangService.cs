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
        public string themKH(KhachHang khachhang)
        {
            try
            {
                _context.KhachHangs.Add(khachhang);
                _context.SaveChanges();
                return "Thêm khach hang thành công";
            }
            catch (Exception ex)
            {

                return " Them That bai" + ex.Message;
            }
        }
        public string suaKH(KhachHang khachhang)
        {
            var suaKH = _context.KhachHangs.Find(khachhang.SoDienThoai);
            suaKH.SoDienThoai = khachhang.SoDienThoai;
            suaKH.TenKH = khachhang.TenKH;
            suaKH.Diem=khachhang.Diem;

            try
            {
                _context.KhachHangs.Update(suaKH);
                _context.SaveChanges();
                return "Cập nhật khách hàng thành công";
            }
            catch (Exception ex)
            {

                return "Sửa thất bại"+ ex.Message;
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

                return "Xoa That Bai" + ex.Message;
            }
        }
    }
}
