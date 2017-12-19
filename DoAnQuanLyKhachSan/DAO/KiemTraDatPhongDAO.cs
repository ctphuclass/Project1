using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class KiemTraDatPhongDAO
    {
        public static List<KiemTraDatPhongDTO> KiemTraDatPhong()
        {
            string query = "usp_xemphieudat";

            DataTable table = DataProvider.ExecuteQuery(query);

            List<KiemTraDatPhongDTO> lspd = new List<KiemTraDatPhongDTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                KiemTraDatPhongDTO pd = new KiemTraDatPhongDTO();
                pd.Maphong = table.Rows[i]["MaPhong"].ToString();
                pd.TinhTrang = (table.Rows[i]["TinhTrang"].ToString());
                pd.Makhachhang = table.Rows[i]["MaKhachHang"].ToString();
                pd.NgayDat = table.Rows[i]["NgayDat"].ToString();
                pd.NgayNhan = (table.Rows[i]["NgayNhan"].ToString());
                pd.NgayTraDuKien = table.Rows[i]["NgayTraDuKien"].ToString();
                pd.NgayTraThucTe = (table.Rows[i]["NgayTraThucTe"].ToString());

                lspd.Add(pd);
            }
            return lspd;
        }
        //public static List<KiemTraDatPhongDTO> LocPhongDat()
        //{
        //    KiemTraDatPhongDTO pd = new KiemTraDatPhongDTO();
        //    string query = string.Format("usp_xemvalocPhieuDat @maphong = {0}",pd.Maphong);

        //    DataTable table = DataProvider.ExecuteQuery(query);

        //    List<KiemTraDatPhongDTO> lspd = new List<KiemTraDatPhongDTO>();
        //    for (int i = 0; i < table.Rows.Count; i++)
        //    {
               
        //        pd.Maphong = table.Rows[i]["MaPhong"].ToString();
        //        pd.TinhTrang = (table.Rows[i]["TinhTrang"].ToString());
        //        pd.Makhachhang = table.Rows[i]["MaKhachHang"].ToString();
        //        pd.NgayDat = table.Rows[i]["NgayDat"].ToString();
        //        pd.NgayNhan = (table.Rows[i]["NgayNhan"].ToString());
        //        pd.NgayTraDuKien = table.Rows[i]["NgayTraDuKien"].ToString();
        //        pd.NgayTraThucTe = (table.Rows[i]["NgayTraThucTe"].ToString());

        //        lspd.Add(pd);
        //    }
        //    return lspd;
        //}
    }
}
