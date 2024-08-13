using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aa_DAL.Models
{
    public class Voucher
    {
        [Key]
        public string Id { get; set; }  
        public string TenVoucher {  get; set; }
        public string Mota { get; set; }    
        public long TienGiam { get; set; }  
        public DateTime NgayBatDau { get; set; }    
        public DateTime NgayKetThuc {  get; set; }
        public int TrangThai { get; set; }  
        public virtual List<HoaDon> HoaDons {  get; set; }   

    }
}
