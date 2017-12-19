using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class DatPhongBUS
    {
        public  static bool insertPhieuDatPhong(string maphong)
        {
            return DatPhongDAO.insertPhieuDatPhong(maphong);
        }
        public static int MaxPhieuDat()
        {
            return DatPhongDAO.MaxPhieuDat();
        }
    }
}
