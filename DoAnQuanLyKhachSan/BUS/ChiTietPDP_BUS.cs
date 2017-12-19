using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class ChiTietPDP_BUS
    {
        public static bool insertPhieuDatPhongChiTiet(int maphieu, string makhachhang, string ngaynhan, string ngaytradukien, string ngaytrathucte)
        {
            return ChiTietPDP_DAO.insertPhieuDatPhongChiTiet(maphieu, makhachhang, ngaynhan, ngaytradukien, ngaytrathucte);
        }
    }
}
