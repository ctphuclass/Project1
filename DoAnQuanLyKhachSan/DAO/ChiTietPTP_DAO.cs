using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietPTP_DAO
    {
        public static bool ThemCTphieu(int maphieu, string maphong, string ngaytra)
        {
            try
            {
                string sQuery = string.Format("usp_ThemMaPhongVaoPhieuThue @map =N'{0}', @ngaytra = N'{1}',@maphieuthue = N'{2}'", maphong, ngaytra, maphieu);


                var u = DataProvider.ExecuteNonQuery(sQuery);
                return true;
            }
            catch (Exception ex)
            {   
                
                throw ex;
            }

        }
    }
}
