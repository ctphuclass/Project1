using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class KiemTraDatPhongBUS
    {
        public static List<KiemTraDatPhongDTO> KiemTraDatPhong()
        {
            return KiemTraDatPhongDAO.KiemTraDatPhong();
        }
        //public static List<KiemTraDatPhongDTO> LocPhongDat()
    }
}
