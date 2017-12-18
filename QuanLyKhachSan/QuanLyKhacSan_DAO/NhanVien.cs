using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyKhachSan_DTO;

namespace QuanLyKhacSan_DAO
{
    public class NhanVien
    {
        static SqlConnection conn;
        /// <summary>
        /// load danh sách nhân viên
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadNV()
        {
            string query = "[usp_LoadNV]";
            conn = DataPrivder_NhanVien.Hamketnoi();
            DataTable data = DataPrivder_NhanVien.Load(query, conn);
            DataPrivder_NhanVien.Dongketnoi(conn);
            return data;
        }
        /// <summary>
        /// chỉnh sửa nhân viên
        /// </summary>
        /// <param name="nhanvien"></param>
        /// <returns></returns>
        public static bool EditNV(NhanVien_DTO nhanvien)
        {
            try
            {
                conn = DataPrivder_NhanVien.Hamketnoi();
                string query = "usp_EditNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MA_NHAN_VIEN", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@TEN_NHAN_VIEN", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@NAM_SINH", SqlDbType.DateTime);
                cmd.Parameters.Add("@CHUC_VU", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@GIOI_TINH", SqlDbType.NVarChar, 5);

                cmd.Parameters["@MA_NHAN_VIEN"].Value = nhanvien.manhanvien;
                cmd.Parameters["@TEN_NHAN_VIEN"].Value = nhanvien.hoten;
                cmd.Parameters["@NAM_SINH"].Value = nhanvien.namsinh;
                cmd.Parameters["@CHUC_VU"].Value = nhanvien.chucvu;
                cmd.Parameters["@GIOI_TINH"].Value = nhanvien.gioitinh;
                cmd.ExecuteNonQuery();
                DataPrivder_NhanVien.Dongketnoi(conn);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// thêm nhân viên
        /// </summary>
        /// <param name="nhanvien"></param>
        /// <returns></returns>
        public static bool AddNV(NhanVien_DTO nhanvien)
        {
            try
            {
                conn = DataPrivder_NhanVien.Hamketnoi();
                string query = "usp_AddNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MA_NHAN_VIEN" , SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@TEN_NHAN_VIEN", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@NAM_SINH", SqlDbType.DateTime);
                cmd.Parameters.Add("@CHUC_VU", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@GIOI_TINH", SqlDbType.NVarChar, 5);

                cmd.Parameters["@MA_NHAN_VIEN"].Value = nhanvien.manhanvien;
                cmd.Parameters["@TEN_NHAN_VIEN"].Value = nhanvien.hoten;
                cmd.Parameters["@NAM_SINH"].Value = nhanvien.namsinh;
                cmd.Parameters["@CHUC_VU"].Value = nhanvien.chucvu;
                cmd.Parameters["@GIOI_TINH"].Value = nhanvien.gioitinh;
                cmd.ExecuteNonQuery();
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
        /// xóa nhân viên
        /// </summary>
        /// <param name="nhanvien"></param>
        /// <returns></returns>
        public static bool DeleteNV(NhanVien_DTO nhanvien)
        {
            try
            {
                conn = DataPrivder_NhanVien.Hamketnoi();
                string query = "usp_DeleteNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MA_NHAN_VIEN", SqlDbType.VarChar, 50);

                cmd.Parameters["@MA_NHAN_VIEN"].Value = nhanvien.manhanvien;
                cmd.ExecuteNonQuery();
                DataPrivder_NhanVien.Dongketnoi(conn);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
