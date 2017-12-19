using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DatPhongDAO
    {
        public static bool insertPhieuDatPhong(string maphong)
        {
            try
            {
                string sQuery = string.Format("usp_insertPhieuDatPhong @maphong ={0}", maphong);


                var u = DataProvider.ExecuteNonQuery(sQuery);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int MaxPhieuDat()
        {
            try
            {
                string sQuery = "usp_LayMaxPhieuDatPhong";
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
