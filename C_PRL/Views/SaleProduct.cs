using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PRL.Views
{
    public class SaleProduct // Chua san pham sau khi sale
    {
        public Guid Id { get; set; }
        public string TenSanPham { get; set; }    
        public string MoTa { get; set; }  
        public string ImgURL { get; set; }  
        public string NhaCungCap { get; set; }  
        public long Gia { get; set; }   
        public int SoLuongTon { get; set; } 
        public int TrangThai { get; set; }  
        public long GiaSale { get; set; } // Gia ban thuc te

        

    }
}
