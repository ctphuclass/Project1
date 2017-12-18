using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DichVuBUS
    {
        
        public static List<DichVuDTO> LoadDV()
        {
            return DichVuDAO.LoadDV();
        }
        public static bool ThemDichVu(DichVuDTO dv)
        {
            return DichVuDAO.ThemDichVu(dv);
        }
        public static ResultMessage_DTO SuaDV(DichVuDTO dv)
        {
            return DichVuDAO.SuaDV(dv);
        }
        public static bool XoaDV(DichVuDTO dv)
        {
            return DichVuDAO.XoaDV(dv);
        }
    }
}
