using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aa_DAL.Models
{
    public class HoaDon
    {
        [Key]
        public Guid Id { get; set; }
        public string NhanVienId { get; set; }
        public string DienThoaiKH {  get; set; }    
        public long TongTien { get; set; }   
        public int TrangThai { get; set; }  
        public DateTime NgayTao { get; set; }
        public string? VoucherId { get; set; }   

        public virtual Nhanvien Nhanvien { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual List<HDCT> HDCTs { get; set; }
        public virtual List<LichSuThanhToan> LichSuThanhToans { get; set; }
    }
}
