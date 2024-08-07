using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aa_DAL.Models
{
    public class Nhanvien
    {
        [Key]
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int Vaitro {  get; set; }  

        public virtual List<HoaDon> HoaDons { get; set; }
    }
}
