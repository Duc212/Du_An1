using Aa_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class NhanVienService
    {
        AppDBContext _context;

        public NhanVienService()
        {
            _context = new AppDBContext();
        }
        public string Login(string taikhoan, string matkhau)
        {
            var nhanvien = _context.Nhanviens.FirstOrDefault(p=> p.TaiKhoan == taikhoan && p.MatKhau == matkhau );
            if( nhanvien == null )
            {
                return "";
            }else
            {
                return nhanvien.Vaitro  + ":" + nhanvien.TaiKhoan;
            }
        }
        public string CreateNV(string taikhoan, string matkhau, int vaitro)
        {
            Nhanvien nhanvien = new Nhanvien()
            {
                Vaitro = vaitro,
                TaiKhoan = taikhoan,
                MatKhau = matkhau,
            };
            try
            {
                _context.Nhanviens.Add(nhanvien);
                _context.SaveChanges();
                return "Tạo Thành Công";
            }
            catch (Exception ex)
            {
                return ex.Message + ex.InnerException; 
                
            }
            
        }
        public List<Nhanvien> GetNhanViens()
        {
            return _context.Nhanviens.ToList();
        }
        public string XoaNV(string taikhoan)
        {
            var deleteItem = _context.Nhanviens.Find(taikhoan);

            try
            {
                _context.Nhanviens.Remove(deleteItem);
                _context.SaveChanges();
                return "Xóa Thành Công";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string KhoaNV(string taikhoan)
        {
            var nhanvien = _context.Nhanviens.Find(taikhoan);
            if(nhanvien.Vaitro == 1)
            {
                return "Không được khóa tài khoản admin";
            }
            else if(nhanvien.Vaitro == 0)
            {
                return "Tài Khoản đã bị Khóa ";
            }
            nhanvien.Vaitro = 0;

            try
            {
                _context.Nhanviens.Update(nhanvien);
                _context.SaveChanges(); return "Tài Khoản đã bị khóa " + taikhoan;
            }
            catch (Exception ex)
            {

                return "Khóa Thất Bại" + ex.Message + ex.InnerException;
            }
           
        }
        public string MoKhoaNV(string taikhoan)
        {
            var nhanvien = _context.Nhanviens.Find(taikhoan);
            
            if(nhanvien.Vaitro != 0)
            {
                return "Tài Khoản đang hoạt động";
            }
            nhanvien.Vaitro = 2;
            try
            {
                _context.Nhanviens.Update(nhanvien);
                _context.SaveChanges(); return "Đã Mở Khóa Tài Khoản  " + taikhoan;
            }
            catch (Exception ex)
            {

                return "Mở Khóa Thất Bại" + ex.Message + ex.InnerException;
            }

        }

        public string UpdateNV(string taikhoan, string matkhau, int vaitro)
        {
            var nhanvien = _context.Nhanviens.Find(taikhoan);
            if(nhanvien == null) 
            {
                return "Không tìm thấy tài khoản cần sửa ";
            }else
            {
                nhanvien.MatKhau = matkhau;
                nhanvien.Vaitro = vaitro;
                try
                {
                    _context.Nhanviens.Update(nhanvien);
                    _context.SaveChanges();
                    return "Sửa Thành Công";
                }
                catch (Exception ex)
                {

                    return "Sửa Thất Bại"+ ex.Message + ex.InnerException;
                }
            }
        }
    }
}
