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
    public class PhieuChiTietDAO
    {
        static SqlConnection con;
        public static List<PhieuChiTietDTO> CPP(string maphong, int machiphi)
        {
            string query = string.Format("usp_lsvDV @maphong={0},@MaChiPhi={1}", maphong, machiphi);

            DataTable table = DataProvider.ExecuteQuery(query);

            List<PhieuChiTietDTO> LsP = new List<PhieuChiTietDTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                PhieuChiTietDTO CP = new PhieuChiTietDTO();
                CP.machiphi = Int32.Parse(table.Rows[i]["MaChiPhi"].ToString());
                CP.madv=table.Rows[i]["MaDichVu"].ToString();
                CP.TenDichVu = table.Rows[i]["TenDichVu"].ToString();

                CP.dongia = (float)Convert.ToDouble(table.Rows[i]["DonGia"].ToString());
                CP.soluong = Int32.Parse(table.Rows[i]["SoLuong"].ToString());
                CP.TongTien = (float)Convert.ToDouble(table.Rows[i]["ThanhTien"].ToString());

                LsP.Add(CP);
            }
            return LsP;
        }
        public static List<PhieuChiTietDTO> ListCTCPP(int machiphi)
        {
            string query = string.Format("usp_ListCPP", machiphi);
            DataTable table = DataProvider.ExecuteQuery(query);

            List<PhieuChiTietDTO> LsPhieu = new List<PhieuChiTietDTO>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                PhieuChiTietDTO CP = new PhieuChiTietDTO();

                CP.madv = table.Rows[i]["MaDV"].ToString();

                CP.soluong = Int32.Parse(table.Rows[i]["SoLuong"].ToString());

                LsPhieu.Add(CP);
            }
            return LsPhieu;
        }
        public static bool UpdateChiTietChiPhi(int machiphi, string madv, int SL)
        {
            try
            {
                string sQuery = string.Format(" usp_insert @MaChiPhi={0}, @MaDV='{1}',@SL = N'{2}'", machiphi, madv, SL);

                var u = DataProvider.ExecuteNonQuery(sQuery);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        

    }
}
