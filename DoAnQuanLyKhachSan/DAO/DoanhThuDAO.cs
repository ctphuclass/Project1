using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DoanhThuDAO
    {
        static SqlConnection con;
        static DataTable table;

        public static List<DoanhThuDTO> LoadDT()
        {
            string query ="usp_doanhthu";

            DataTable table = DataProvider.ExecuteQuery(query);

            List<DoanhThuDTO> lsDT = new List<DoanhThuDTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DoanhThuDTO DT = new DoanhThuDTO();
                DT.maphong = table.Rows[i]["MaPhong"].ToString();
                DT.machitiet = int.Parse(table.Rows[i]["Mã Hóa Đơn"].ToString());
                DT.ngaylap= table.Rows[i]["NgayLap"].ToString();
                DT.tinhtrang = table.Rows[i]["Thanh Toán Dịch Vụ"].ToString();
                DT.tienchiphi = int.Parse(table.Rows[i]["Tiền Chi Phí Phát Sinh"].ToString());
                DT.giaphong = int.Parse(table.Rows[i]["Giá Phòng"].ToString());
                DT.Tổng_Tiền_HD = int.Parse(table.Rows[i]["Tổng Tiền Hóa Đơn"].ToString());
                lsDT.Add(DT);
            }
            return lsDT;
        }
        public static DataTable DoanhThuTheoPhong(string maphong)
        {
            string query = string.Format("usp_doanhthutheophong @maphong =N'%{0}%'", maphong);
            con = DataProvider.HamKetNoi();
            table = DataProvider.Load(query, con);
            DataProvider.DongKetNoi(con);
            return table;

        }
        public static List<TongTienDTO> LoadTongDoanhThu()
        {
            string query = "usp_tdoanhthu";

            DataTable table = DataProvider.ExecuteQuery(query);

            List<TongTienDTO> lsTDT = new List<TongTienDTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                TongTienDTO TT = new TongTienDTO();

                TT.TongTien = (float)Convert.ToDouble(table.Rows[i]["tongdoanhthu"].ToString());
                lsTDT.Add(TT);
            }
            return lsTDT;
        }
        public static List<TongTienDTO> LoadTongTienTheoPhong(string maphong)
        {
            string query = string.Format("usp_tdoanhthutheophong @maphong =N'%{0}%'", maphong);

            DataTable table = DataProvider.ExecuteQuery(query);

            List<TongTienDTO> lsTDT1 = new List<TongTienDTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                TongTienDTO TT = new TongTienDTO();

                TT.TongTien = (float)Convert.ToDouble(table.Rows[i]["tongdoanhthu"].ToString());
                lsTDT1.Add(TT);
            }
            return lsTDT1;
        }
    }
}
