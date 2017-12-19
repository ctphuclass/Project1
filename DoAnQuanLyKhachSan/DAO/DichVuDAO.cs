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
    public class DichVuDAO
    {
        static SqlConnection con;
        static DataTable table;
       
        public static List<DichVuDTO> LoadDV()
        {
            string query = string.Format("usp_menudv1");

            DataTable table = DataProvider.ExecuteQuery(query);

            List<DichVuDTO> lsDV = new List<DichVuDTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DichVuDTO DV = new DichVuDTO();
                DV.madichvu = table.Rows[i]["Mã Dịch Vụ"].ToString();
                DV.tenloai = table.Rows[i]["Loại"].ToString();
                DV.loai = table.Rows[i]["MaLoaiDichVu"].ToString();
                DV.tendichvu = table.Rows[i]["Tên"].ToString();
                DV.gia = table.Rows[i]["Giá"].ToString();
                lsDV.Add(DV);
            }
            return lsDV;
        }

        public static bool ThemDichVu(DichVuDTO dv)
        {
            try
            {
                con = DataProvider.HamKetNoi();
                SqlCommand cmd = new SqlCommand("usp_Themdv", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@madv", dv.madichvu);
                cmd.Parameters.AddWithValue("@tendv", dv.tendichvu);
                cmd.Parameters.AddWithValue("@g", dv.gia);
                cmd.Parameters.AddWithValue("@l", dv.loai);
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
        public static ResultMessage_DTO SuaDV(DichVuDTO dv)
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_UpdateDV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Madv", dv.madichvu);
                cmd.Parameters.AddWithValue("@tendv", dv.tendichvu);
                cmd.Parameters.AddWithValue("@g", dv.gia);
                cmd.Parameters.AddWithValue("@l", dv.loai);
                cmd.Parameters.AddWithValue("@pResultCode_DV", result.ResultCode_DV);
                cmd.Parameters.AddWithValue("@pResultMessage_DV", result.ResultMessage_DV);
                cmd.Parameters["@pResultCode_DV"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_DV"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_DV"].Size = 200;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode_DV = cmd.Parameters["@pResultCode_DV"].Value.ToString();
                result.ResultMessage_DV = cmd.Parameters["@pResultMessage_DV"].Value.ToString();
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
        public static bool XoaDV(DichVuDTO dv)
        {
            try
            {
                con = DataProvider.HamKetNoi();
                SqlCommand cmd = new SqlCommand("usp_XoaDV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@madv", dv.madichvu);
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
    }

}
