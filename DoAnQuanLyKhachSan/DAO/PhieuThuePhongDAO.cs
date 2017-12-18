using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuThuePhongDAO
    {
        public static bool ThemMaPhieuTheoKH(string makh)
        {
            try
            {
                string sQuery = string.Format("usp_ThemKHvaophieu @makh ={0}",makh);


                var u = DataProvider.ExecuteNonQuery(sQuery);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int MaxPhieuThue()
        {
            try
            {
                string sQuery = "execute usp_maxPhieuThue ";
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
