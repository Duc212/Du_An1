using Aa_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class HoaDonService
    {
        AppDBContext _context;
        public HoaDonService()
        {
            _context = new AppDBContext();
        }
        public List<HoaDon> GetAllHoaDons() 
        {
            return _context.HoaDons.ToList();
        }
        public List<HoaDon> GetHoaDonWait()
        {
            return _context.HoaDons.Where(p => p.TrangThai == 0).ToList();
        }

        public string TaoHoaDon(string nhanvienId, string khachhangId)
        {
                HoaDon hoadon = new HoaDon()
                {
                    Id = Guid.NewGuid(),
                    TrangThai = 0,
                    TongTien = 0,
                    NhanVienId = nhanvienId,
                    DienThoaiKH = khachhangId,
                    NgayTao = DateTime.Now,
                };
                _context.HoaDons.Add(hoadon);
                _context.SaveChanges();
            return "Tao Thanh Cong";
           
           
        }
        public string XoaHoaDon(Guid id)
        {
            var deleteHd = _context.HoaDons.Find(id);
            if (deleteHd == null)
            {
                return "Không thấy hóa đơn cần xóa";
            }
            else
            {
                try
                {
                    deleteHd.TrangThai = 2;
                    _context.HoaDons.Remove(deleteHd);
                    _context.SaveChanges();
                    return "Bạn đã xóa hóa đơn thành công";
                }
                catch (Exception)
                {

                    return "Xóa thất bại";
                }
            }
           
        }

        public void getTongTientoHD( Guid hoadonId,long tongTien)
        {
            var timhoadon = _context.HoaDons.Find(hoadonId);
            timhoadon.TongTien =tongTien;
            try
            {
                _context.HoaDons.Update(timhoadon);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ThanhToan(Guid hoadonId)
        {
            var thanhtoan = _context.HoaDons.Find(hoadonId);

            if( thanhtoan == null)
            {
                return "Không tìm thấy hóa đơn cần thanh toán ";
            }
            else
            {
                thanhtoan.TrangThai = 1;
                try
                {
                    _context.HoaDons.Update(thanhtoan);
                    _context.SaveChanges();
                    return "Thanh Toán Thành Công";

                }
                catch (Exception)
                {

                    return "Thanh Toán Thất Bại";
                }
            }
        }
    }
}
