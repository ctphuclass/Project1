using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietPDP_DAO
    {
        public static bool insertPhieuDatPhongChiTiet(int maphieu, string makhachhang,string ngaynhan,string ngaytradukien,string ngaytrathucte)
        {
            try
            {
                string sQuery = string.Format("usp_insertPhieuDatPhongChiTiet @maphieu =N'{0}', @makh = N'{1}',@ngaynhan = N'{2}',@ngaytradukien=N'{3}',@ngaytrathucte=N'{4}'", maphieu, makhachhang, ngaynhan, ngaytradukien, ngaytrathucte);
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
