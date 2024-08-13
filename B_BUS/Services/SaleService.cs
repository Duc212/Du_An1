using Aa_DAL.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class SaleService
    {
        AppDBContext _context;
        public SaleService()
        {
            _context = new AppDBContext();
        }
        public List<Sale> GetAllSales() 
        {
            return _context.Sales.ToList();
        }
        public string CreateSales(Sale sale)
        {
            if ( sale.EndDate < DateTime.Now || sale.StartDate > sale.EndDate)
            {
                return "Kiểm tra lại thời hạn chương trình khuyến mãi";
            }
            else if (sale.Percent > 100 || sale.Percent < 0)
            {
                return "Kiểm tra lại phần trăm giảm";
            }
            else
            {
                _context.Sales.Add(sale);
                _context.SaveChanges();
                return "Tạo Mới Khuyến Mãi thành công";
            }
        }

        public List<Sale> GetActiveSales() 
        {
            return _context.Sales.Where(p => p.StartDate <= DateTime.Now && p.EndDate >DateTime.Now
             && p.Status == 0).ToList();
        }
    }
}
