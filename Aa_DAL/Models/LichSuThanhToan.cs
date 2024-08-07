using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aa_DAL.Models
{
    public class LichSuThanhToan
    {
        public Guid Id { get; set; }
        public Guid HoaDonId {  get; set; }
        public Guid HinhThucThanhToanId {  get; set; }
        public long SoTien { get; set; }
        public string GhiChu { get; set; }

        public virtual HinhThucThanhToan HinhThucThanhToanh { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}
