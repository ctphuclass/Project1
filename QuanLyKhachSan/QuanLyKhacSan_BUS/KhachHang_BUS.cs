using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DTO;
using QuanLyKhacSan_DAO;
using System.Data;

namespace QuanLyKhacSan_BUS
{
    public class KhachHang_BUS
    {
        public static bool DeleteKH(KhachHang_DTO khachhang)
        {
            return KhachHang_DAO.DeleteKH(khachhang);
        }
        public static bool AddKH(KhachHang_DTO khachhang)
        {
            return KhachHang_DAO.AddKH(khachhang);
        }
    }
}
