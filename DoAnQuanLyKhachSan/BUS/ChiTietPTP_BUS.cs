using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class ChiTietPTP_BUS
    {
        public static bool ThemCTphieu(int maphieu, string maphong, string ngaytra)
        {
            return ChiTietPTP_DAO.ThemCTphieu(maphieu,maphong,ngaytra);
        }
    }
}
