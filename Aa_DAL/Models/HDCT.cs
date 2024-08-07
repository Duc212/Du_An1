using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aa_DAL.Models
{
    public class HDCT
    {
        [Key]
        public Guid Id { get; set; }
        public Guid HoaDonId {  get; set; } 
        public Guid SanPhamId { get; set; } 
        public long Gia {  get; set; }  
        public int SoLuong { get; set; }    

        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham { get; set; }


    }
}
