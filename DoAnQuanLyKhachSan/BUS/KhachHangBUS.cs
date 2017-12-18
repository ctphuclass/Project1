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
    public class KhachHangBUS
    {
        public static DataTable Loadkh()
        {
            return KhachHangDAO.Loadkh();
        }
        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            return KhachHangDAO.ThemKH(kh);
        }
        public static bool AddKH(KhachHangDTO kh)
        {
            return KhachHangDAO.AddKH(kh);
        }
        public static DataTable XoaKhachHang(KhachHangDTO kh)
        {
            return KhachHangDAO.XoaKhachHang(kh);
        }
        public static ResultMessage_DTO SuaKH(KhachHangDTO kh)
        {
            return KhachHangDAO.SuaKH(kh);
        }
        public static DataTable TimKH(string tk)
        {
            return KhachHangDAO.TimKH(tk);
        }
    }
}
