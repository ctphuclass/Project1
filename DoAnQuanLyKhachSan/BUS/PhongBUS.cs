using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class PhongBUS
    {
        public static int tablewidth = 80;
        public static int tableheight = 80;
        public static List<PhongDTO> LsP()
        {
            return PhongDAO.LsP();
        }
        public static ResultMessage_DTO SuaPhong(PhongDTO p)
        {
            return PhongDAO.SuaP(p);
        }
        public static bool ThemPhong(PhongDTO p)
        {
            return PhongDAO.ThemP(p);
        }

        public static void TraPhong(string maphong)
        {
            PhongDAO.TraPhong(maphong);
        }
        public static void NhanPhong(string maphong)
        {
            PhongDAO.thuephong(maphong);
        }
        public static List<PhongDTO> KiemTraThuePhong()
        {
            return PhongDAO.LoadListPhong();
        }
        public static void DatPhong(string maphong)
        {
            PhongDAO.DatPhong(maphong);
        }
        public static void NhanPhong1(string maphong)
        {
            PhongDAO.NhanPhong1(maphong);
        }
        public static void NhanPhong2(string maphong)
        {
            PhongDAO.NhanPhong2(maphong);
        }
        public static void HuyPhong(string maphong)
        {
            PhongDAO.HuyPhong(maphong);
        }
    }
}
