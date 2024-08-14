using Aa_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class HDCTServices
    {
        AppDBContext _context;
        public HDCTServices()
        {
            _context = new AppDBContext();
        }

        public List<HDCT> getAllbyHoaDonId(Guid hoadonId)
        {
            return _context.HDCTs.Where(p => p.HoaDonId == hoadonId).ToList();
        }
        public string AddToHoaDon(Guid hoadonId, Guid sanphamId, long gia,int soluong )
        {
            var check = _context.HDCTs.FirstOrDefault(p => p.HoaDonId == hoadonId && p.SanPhamId == sanphamId);
            if(check == null )
            {
                HDCT hdcts = new HDCT()
                {
                    Id = Guid.NewGuid(),
                    HoaDonId = hoadonId,
                    SanPhamId = sanphamId,  
                    Gia = gia,
                    SoLuong = soluong,
                };
                _context.HDCTs.Add(hdcts);
                _context.SaveChanges();
                var sanpham = _context.SanPhams.Find(sanphamId);
                sanpham.SoLuongTon = sanpham.SoLuongTon - soluong;
                _context.SanPhams.Update(sanpham);
                _context.SaveChanges();
                return "Them Thanh Cong vao Hoa Don";
            }
            else
            {
                check.SoLuong = check.SoLuong +  soluong; // Update so luong trong bill Details
                _context.HDCTs.Update(check);
                _context.SaveChanges();
                //update so luong san pham trong kho
                var sanpham = _context.SanPhams.Find(sanphamId);
                sanpham.SoLuongTon = sanpham.SoLuongTon - soluong;
                _context.SanPhams.Update(sanpham);
                _context.SaveChanges();
                return "Thêm mới và cộng dồn thành công";
            }


        }
        public long TinhTongTien(Guid hoadonId)
        {
            var hdct = _context.HDCTs.Where(p => p.HoaDonId == hoadonId).ToList();
            long tongTien = 0;

            foreach(var sp in hdct)
            {
                tongTien = sp.Gia * sp.SoLuong;
            }
            return tongTien;
        }

    }
}
