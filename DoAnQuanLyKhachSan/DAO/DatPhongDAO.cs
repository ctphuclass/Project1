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
        public static bool ThemMaPhieuTheoKH(string makh)
        {
            try
            {
                string sQuery = string.Format("usp_ThemKHvaophieudat @makh ={0}", makh);


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
                string sQuery = "execute usp_maxPhieuDat ";
                DataTable dt = DataProvider.ExecuteQuery(sQuery);
                int i = Int32.Parse(dt.Rows[0][0].ToString());
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public static int kiemtratinhtrang(string maphong)
        //{
            //try
            //{
            //    string sQuery = string.Format("usp_MaChiPhi @maphong ={0}", maphong);

            //    DataTable dt = DataProvider.ExecuteQuery(sQuery);



            //    if (dt.Rows.Count > 0)
            //    {
                   
            //        cphiphu.machiphi = Int32.Parse(dt.Rows[0][0].ToString());
            //        return cphiphu.machiphi;
            //    }
            //    else
            //        return -1;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        //}
    }
}
