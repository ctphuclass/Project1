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
    public class PhieuChiTietBUS
    {
        public static List<PhieuChiTietDTO> CPP(string maphong, int machiphi)
        {
            return PhieuChiTietDAO.CPP(maphong, machiphi);
        }
        public static List<PhieuChiTietDTO> List_CPP(int machiphi)
        {
            return PhieuChiTietDAO.ListCTCPP(machiphi);
        }
        public static bool UpdateChiTietChiPhi(int machiphi, string madv, int SL)
        {
            return PhieuChiTietDAO.UpdateChiTietChiPhi(machiphi, madv, SL);
        }

    }
}
