using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiPhiDAO
    {
        public static int kiemtrachiphi(string maphong)
        {
            try
            {
                string sQuery = string.Format("usp_MaChiPhi @maphong ={0}", maphong);

                DataTable dt = DataProvider.ExecuteQuery(sQuery);

                

                if (dt.Rows.Count > 0)
                {
                    ChiPhiDTO cphiphu = new ChiPhiDTO();
                    cphiphu.machiphi = Int32.Parse(dt.Rows[0][0].ToString());
                    return cphiphu.machiphi;
                }
                else
                    return -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool InsertChiPhi(string maphong)
        {
            try
            {
                string query = string.Format("usp_insertChiPhi @maphong={0}", maphong);
                var u = DataProvider.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        public static void CapNhatChiPhi(int machiphi)
        {
            string query = string.Format("usp_updatechiphi @machiphi={0}", machiphi);
            var u = DataProvider.ExecuteNonQuery(query);
        }
        public static int MaxChiTiet()
        {
            try
            {
                string sQuery = "usp_maxchiphi ";
                DataTable dt = DataProvider.ExecuteQuery(sQuery);
                int i = Int32.Parse(dt.Rows[0][0].ToString());
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
