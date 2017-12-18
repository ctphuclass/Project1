using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DTO;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyKhacSan_DAO
{
    public class KhachHang_DAO
    {
        static SqlConnection conn;
        /// <summary>
        /// trả danh sách khách hàng
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadKH()
        {
            conn = DataPrivder_NhanVien.Hamketnoi();
            DataTable KH = DataPrivder_NhanVien.Load("usp_LoadKH",conn);
            DataPrivder_NhanVien.Dongketnoi(conn);
            return KH;
        }
        /// <summary>
        /// xóa khách hàng
        /// </summary>
        /// <param name="khachhang"></param>
        /// <returns></returns>
        public static bool DeleteKH(KhachHang_DTO khachhang)
        {
            try
            {
                conn = DataPrivder_NhanVien.Hamketnoi();
                string query = "usp_DeleteKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKhachHang", SqlDbType.VarChar, 50);
                cmd.Parameters["MaKhachhang"].Value = khachhang.makhachhang;
                DataPrivder_NhanVien.Dongketnoi(conn);
                return true;
            }
            catch(Exception ex)
            {
                return false;
                throw ex;
            }
        }
        /// <summary>
        /// thêm khách hàng
        /// </summary>
        /// <param name="khachhang"></param>
        /// <returns></returns>
        public static bool AddKH(KhachHang_DTO khachhang)
        {
            try
            {
                conn = DataPrivder_NhanVien.Hamketnoi();
                string query = "[usp_AddKH]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaKhachHang", SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@SoCMND", SqlDbType.Int);
                cmd.Parameters.Add("@DienThoai", SqlDbType.Int);
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@QuocTich", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 5);
                cmd.Parameters.Add("@NgayNhanPhong", SqlDbType.Date);
                cmd.Parameters.Add("@NgayTraPhong", SqlDbType.Date);

                cmd.Parameters["@MaKhachHang"].Value = khachhang.makhachhang;
                cmd.Parameters["@TenKhachHang"].Value = khachhang.tenkhachang;
                cmd.Parameters["@SoCMND"].Value = khachhang.soCMND;
                cmd.Parameters["@DienThoai"].Value = khachhang.soDT;
                cmd.Parameters["@DiaChi"].Value = khachhang.diachi;
                cmd.Parameters["@QuocTich"].Value = khachhang.quoctich;
                cmd.Parameters["@GioiTinh"].Value = khachhang.gioitinh;
                cmd.Parameters["@NgayNhanPhong"].Value = khachhang.ngaynhanphong;
                cmd.Parameters["@NgayTraPhong"].Value = khachhang.ngaytraphong;
                cmd.ExecuteNonQuery();
                DataPrivder_NhanVien.Dongketnoi(conn);
                return true;
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }
    }
}
