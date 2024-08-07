using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aa_DAL.Models
{
    public class SanPham
    {
        [Key]
        public Guid Id { get; set; }
        public string TenSanPham {  get; set; } 
        public string MoTa {  get; set; }   
        public string ImgURL { get; set; }  
        public string NhaCungCap {  get; set; } 
        public long Gia {  get; set; }
        public int SoLuongTon { get; set; } 
        public int TrangThai {  get; set; } 
        public virtual List<HDCT> HDCTs { get; set; }
        
    }
}
