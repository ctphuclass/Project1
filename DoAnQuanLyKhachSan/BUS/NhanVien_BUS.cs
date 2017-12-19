using QuanLyKhachSan_DTO;
using QuanLyKhacSan_DAO;
using System.Data;

namespace QuanLyKhacSan_BUS
{
    public class NhanVien_BUS
    {
        public static DataTable LoadNhanVien()
        {
            return NhanVien.LoadNV();
        }
        public static bool EditNhanVien(NhanVien_DTO nhanvien)
        {
            return NhanVien.EditNV(nhanvien);
        }
        public static bool AddNhanVien(NhanVien_DTO nhanvien)
        {
            return NhanVien.AddNV(nhanvien);
        }
        public static bool DeleteNhanVien(NhanVien_DTO nhanvien)
        {
            return NhanVien.DeleteNV(nhanvien);
        }
    }
}
