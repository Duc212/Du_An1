using Aa_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class VoucherService
    {
        AppDBContext _context;
        public VoucherService()
        {
            _context = new AppDBContext();
        }
        public List<Voucher> GetAllVouchers()
        {
            return _context.Vouchers.ToList();
        }
        public string CreateVoucher(Voucher voucher)
        {
            if (voucher.NgayBatDau < DateTime.Now || voucher.NgayBatDau > voucher.NgayKetThuc)
            {
                return "Kiểm tra lại thời hạn chương trình khuyến mãi";
            }
            else if (voucher.TienGiam < 0)
            {
                return "Kiểm tra lại tiền giảm";
            }
            else
            {
                _context.Vouchers.Add(voucher);
                _context.SaveChanges();
                return "Tạo Mới Khuyến Mãi thành công";
            }
        }

        public List<Voucher> GetActiveVoucher()
        {
            return _context.Vouchers.Where(p => p.NgayBatDau <= DateTime.Now && p.NgayKetThuc > DateTime.Now
             && p.TrangThai == 0).ToList();
        }
    }
}
