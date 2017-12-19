using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongDAO
    {
        static SqlConnection con;
        static DataTable table;

        public static List<PhongDTO> LsP()
        {

            try
            {
                string sQuery = "select * from Phong ";

                table = DataProvider.ExecuteQuery(sQuery);

                List<PhongDTO> LsP = new List<PhongDTO>();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    PhongDTO phong = new PhongDTO();
                    phong.maphong = table.Rows[i]["Maphong"].ToString();
                    phong.tinhtrang = table.Rows[i]["TinhTrang"].ToString();
                    
                    phong.maloaiphong = table.Rows[i]["MaLoaiPhong"].ToString();
                    LsP.Add(phong);
                }

                return LsP;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable loadphong(PhongDTO p)
        {
            try
            {          
            string query = "usp_loadp";
            con = DataProvider.HamKetNoi();
            table = DataProvider.Load(query, con);
            DataProvider.DongKetNoi(con);
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
        public static ResultMessage_DTO SuaP(PhongDTO p)
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
              
                SqlCommand cmd = new SqlCommand("usp_SuaP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@map", p.maphong);
                cmd.Parameters.AddWithValue("@gia", p.gia);
                cmd.Parameters.AddWithValue("@s", p.succhua);
                cmd.Parameters.AddWithValue("@l", p.loaiphong);
                cmd.Parameters.AddWithValue("@g", p.ghichu);
                cmd.Parameters.AddWithValue("@pResultCode_P", result.ResultCode_DV);
                cmd.Parameters.AddWithValue("@pResultMessage_P", result.ResultMessage_DV);
                cmd.Parameters["@pResultCode_P"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_P"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_P"].Size = 200;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode_P = cmd.Parameters["@ResultCode_P"].Value.ToString();
                result.ResultMessage_P = cmd.Parameters["@ResultMessage_P"].Value.ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                result.ResultCode_DV = "";
                result.ResultMessage_DV = ex.Message;
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
        public static DataTable XoaP(PhongDTO p)
        {
            con = DataProvider.HamKetNoi();
            SqlCommand cmd = new SqlCommand("usp_xoap", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@map", p.maphong);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            return table;
        }
        public static bool ThemP(PhongDTO p)
        {
            try
            {
                con = DataProvider.HamKetNoi();
                SqlCommand cmd = new SqlCommand("usp_ThemP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@map", p.maphong);
                cmd.Parameters.AddWithValue("@gia", p.gia);
                cmd.Parameters.AddWithValue("@s", p.succhua);
                cmd.Parameters.AddWithValue("@l", p.loaiphong);
                cmd.Parameters.AddWithValue("@g", p.ghichu);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
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
        public static void TraPhong(string maphong)
        {
            string query = string.Format("usp_traphong @map ={0}",maphong);
             var u = DataProvider.ExecuteNonQuery(query);
        }
        public static List<PhongDTO> LoadListPhong()
        {
            string query = "usp_KiemTraPhongDat";

            DataTable table = DataProvider.ExecuteQuery(query);

            List<PhongDTO> lsDT = new List<PhongDTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                PhongDTO p = new PhongDTO();
                p.maphong = table.Rows[i]["MaPhong"].ToString();
               p.maloaiphong =(table.Rows[i]["MaLoaiPhong"].ToString());
                p.succhua = table.Rows[i]["SucChua"].ToString();
               p.gia = table.Rows[i]["DonGia"].ToString();
               p.loaiphong =(table.Rows[i]["TenLoaiPhong"].ToString());
                p.tinhtrang = table.Rows[i]["TinhTrang"].ToString();

                lsDT.Add(p);
            }
            return lsDT;
        }
        public static void thuephong(string maphong)
        {
            string query = string.Format("usp_thuephongmoi @map ={0}", maphong);
            var u = DataProvider.ExecuteNonQuery(query);
        }
    }
}
