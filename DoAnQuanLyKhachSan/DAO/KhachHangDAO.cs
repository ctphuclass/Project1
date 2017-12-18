using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class KhachHangDAO
    {
        static SqlConnection con;
        static DataTable table;
        //public static List<KhachHangDTO> LoadKH()
        //{
        //    string query = string.Format("usp_loadkh");

        //    DataTable table = DataProvider.ExecuteQuery(query);

        //    List<KhachHangDTO> lsKH = new List<KhachHangDTO>();
        //    for (int i = 0; i < table.Rows.Count; i++)
        //    {
        //        KhachHangDTO kh = new KhachHangDTO();
        //        kh.makh = table.Rows[i]["MaKhachHang"].ToString();
        //        kh.tenkh = table.Rows[i]["TenKhachHang"].ToString();

        //        kh.gioitinh = table.Rows[i]["GioiTinh"].ToString();
        //        kh.sdt = table.Rows[i]["DienThoai"].ToString();
        //        kh.diachi = table.Rows[i]["DiaChi"].ToString();
        //        kh.CMND = table.Rows[i]["SoCMND"].ToString();
        //        kh.quoctinh = table.Rows[i]["QuocTich"].ToString();
        //        lsKH.Add(kh);
        //    }
        //    return lsKH;
        //}
        public static DataTable Loadkh()
        {
            string query = "usp_loadkh";
            con = DataProvider.HamKetNoi();
            table = DataProvider.Load(query, con);
            DataProvider.DongKetNoi(con);
            return table;
        }


        public static bool AddKH(KhachHangDTO kh)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("usp_AddKH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKhachHang", kh.makh);
                cmd.Parameters.AddWithValue("@TenKhachHang", kh.tenkh);
                cmd.Parameters.AddWithValue("@GioiTinh", kh.gioitinh);
                cmd.Parameters.AddWithValue("@QuocTich", kh.quoctinh);
                cmd.Parameters.AddWithValue("@DiaChi", kh.diachi);
                cmd.Parameters.AddWithValue("@DienThoai", kh.sdt);
                cmd.Parameters.AddWithValue("@SoCMND", kh.CMND);
                var i =cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
               
                throw ex;
            }
        }
        public static bool ThemKH(KhachHangDTO kh)
        {
            try
            {
                con = DataProvider.HamKetNoi();
                SqlCommand cmd = new SqlCommand("usp_AddKH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKhachHang", kh.makh);
                cmd.Parameters.AddWithValue("@TenKhachHang", kh.tenkh);
                cmd.Parameters.AddWithValue("@GioiTinh", kh.gioitinh);
                cmd.Parameters.AddWithValue("@QuocTich", kh.quoctinh);
                cmd.Parameters.AddWithValue("@DiaChi", kh.diachi);
                cmd.Parameters.AddWithValue("@DienThoai", kh.sdt);
                cmd.Parameters.AddWithValue("@SoCMND", kh.CMND);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
               
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
        public static ResultMessage_DTO SuaKH(KhachHangDTO kh)
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_UpdateKH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKhachHang", kh.makh);
                cmd.Parameters.AddWithValue("@TenKhachHang", kh.tenkh);
                cmd.Parameters.AddWithValue("@GioiTinh", kh.gioitinh);
                cmd.Parameters.AddWithValue("@QuocTich", kh.quoctinh);
                cmd.Parameters.AddWithValue("@DiaChi", kh.diachi);
                cmd.Parameters.AddWithValue("@DienThoai", kh.sdt);
                cmd.Parameters.AddWithValue("@SoCMND", kh.CMND);
                cmd.Parameters.AddWithValue("@pResultCode_KH", result.ResultCode_KH);
                cmd.Parameters.AddWithValue("@pResultMessage_KH", result.ResultMessage_KH);
                cmd.Parameters["@pResultCode_KH"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_KH"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_KH"].Size = 200;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode_KH = cmd.Parameters["@pResultCode_KH"].Value.ToString();
                result.ResultMessage_KH = cmd.Parameters["@pResultMessage_KH"].Value.ToString();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                result.ResultCode_KH = "";
                result.ResultMessage_KH = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
        public static DataTable XoaKhachHang(KhachHangDTO kh)
        {
            try
            {
                con = DataProvider.HamKetNoi();
                SqlCommand cmd = new SqlCommand("usp_DeleteKH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKhachHang", kh.makh);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
                return table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public static DataTable TimKH(string tk)
        {
            string query = string.Format("usp_timkh @tk ={0}", tk);
            con = DataProvider.HamKetNoi();
            table = DataProvider.Load(query, con);
            DataProvider.DongKetNoi(con);
            return table;

        }
    }
}
