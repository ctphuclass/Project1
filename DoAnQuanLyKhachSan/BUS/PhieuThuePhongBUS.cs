using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class PhieuThuePhongBUS
    {
        public static bool ThemMaPhieuTheoKH(string makh)
        {
            return PhieuThuePhongDAO.ThemMaPhieuTheoKH(makh);
        }
        public static int MaxPhieuThue()
        {
            return PhieuThuePhongDAO.MaxPhieuThue();
        }
    }
}
