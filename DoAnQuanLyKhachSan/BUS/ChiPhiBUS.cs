using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiPhiBUS
    {
        public static int kiemtrachiphi(string maphong)
        {
            return ChiPhiDAO.kiemtrachiphi(maphong);
        }
        public static bool ThemVaoChiPhi(string maphong)
        {
            return ChiPhiDAO.InsertChiPhi(maphong);
        }
        public static void TinhTien(int machiphi)
        {
             ChiPhiDAO.CapNhatChiPhi(machiphi);
        }
        public static int MaxChiTiet()
        {
            return ChiPhiDAO.MaxChiTiet();
        }
    }
}
