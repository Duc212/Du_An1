using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aa_DAL.Models
{
    public class HinhThucThanhToan
    {
        [Key]
        public Guid Id { get; set; }    
        public string TenHinhThuc {  get; set; }    
        public int TrangThai { get; set; }  

        public virtual List<LichSuThanhToan> LichSuThanhToans { get; set; }

    }
}
