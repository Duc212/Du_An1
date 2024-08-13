using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aa_DAL.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {
            
        }

        public AppDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Nhanvien> Nhanviens { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HDCT> HDCTs { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<LichSuThanhToan> LichSuThanhToans { get; set; }
        public DbSet<HinhThucThanhToan> HinhThucThanhToans { get; set; }
        public DbSet<Sale> Sales { get; set; }  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DUYDUC;Database=QuanLyBanNuocCF;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
