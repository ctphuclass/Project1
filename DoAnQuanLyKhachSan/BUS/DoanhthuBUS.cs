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
    public class DoanhthuBUS
    {
        public static List<DoanhThuDTO> LoadDT()
        {
            return DoanhThuDAO.LoadDT();
        }
        public static DataTable DoanhThuTheoPhong(string maphong)
        {
            return DoanhThuDAO.DoanhThuTheoPhong(maphong);
        }
        public static List<TongTienDTO> LoadTongDoanhThu()
        {
            return DoanhThuDAO.LoadTongDoanhThu();
        }
        public static List<TongTienDTO> LoadTongTienTheoPhong(string maphong)
        {
            return DoanhThuDAO.LoadTongTienTheoPhong(maphong);
        }
    }
}
