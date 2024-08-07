using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aa_DAL.Models
{
    public class KhachHang
    {
        [Key]
        public string SoDienThoai { get; set; }
        public string TenKH {  get; set; }
        public int Diem {  get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
    }
}
