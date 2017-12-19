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
    public class UserDAO
    {
        static SqlConnection con;
        public ResultMessage_DTO AddUserDetails(UserDTO ObjDTO) // passing Bussiness object Here
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                /* Because We will put all out values from our (UserRegistration.aspx)
				To in Bussiness object and then Pass it to Bussiness logic and then to
				DataAcess
				this way the flow carry on*/
                con = DataProvider.HamKetNoi();
                SqlCommand cmd = new SqlCommand("usp_User_CreateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@psUsername", ObjDTO.TaiKhoan);
                cmd.Parameters.AddWithValue("@psPassword", ObjDTO.MatKhau);
                cmd.Parameters.AddWithValue("@pResultCode", result.ResultCode);
                cmd.Parameters.AddWithValue("@pResultMessage", result.ResultMessage);
                cmd.Parameters["@pResultCode"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage"].Size = 50;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode = (int)cmd.Parameters["@pResultCode"].Value;
                result.ResultMessage = cmd.Parameters["@pResultMessage"].Value.ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                result.ResultCode = -1;
                result.ResultMessage = ex.Message;
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
        public ResultMessage_DTO CheckUserLogin(UserDTO ObjDTO) // passing Bussiness object Here
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                /* Because We will put all out values from our (UserRegistration.aspx)
				To in Bussiness object and then Pass it to Bussiness logic and then to
				DataAcess
				this way the flow carry on*/
                con = DataProvider.HamKetNoi();
                SqlCommand cmd = new SqlCommand("usp_User_CheckUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@psUsername", ObjDTO.TaiKhoan);
                cmd.Parameters.AddWithValue("@psPassword", ObjDTO.MatKhau);
                cmd.Parameters.AddWithValue("@pResultCode", result.ResultCode);
                cmd.Parameters.AddWithValue("@pResultMessage", result.ResultMessage);
                cmd.Parameters["@pResultCode"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage"].Size = 50;
                cmd.ExecuteNonQuery();
                result.ResultCode = (int)cmd.Parameters["@pResultCode"].Value;
                result.ResultMessage = cmd.Parameters["@pResultMessage"].Value.ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                result.ResultCode = -1;
                result.ResultMessage = ex.Message;
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
        public static bool CheckPermission(UserDTO user)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("usp_USER_GetUserListPermision", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", user.TaiKhoan);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    user.ChucVu = dt.Rows[i]["ChucVu"].ToString();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
