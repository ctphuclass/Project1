using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DTO;
namespace QuanLyKhacSan_DAO
{
    public class Phong_DAO
    {
        private static Phong_DAO instance;
        private  Phong_DAO() { }
        static SqlConnection conn;
        public static int Phong_DAOWidth = 90;
        public static int Phong_DAOHeight = 90;

        public static Phong_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Phong_DAO();
                }
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public  List<Phong_DTO> LoadPhong()
        {
            List<Phong_DTO> phong = new List<Phong_DTO>();
            conn = DataPrivder_NhanVien.Hamketnoi();
            DataTable data = DataPrivder_NhanVien.Load("usp_LoadPhong",conn);
            foreach (DataRow item in data.Rows)
            {
                Phong_DTO phong_dto = new Phong_DTO(item);
                phong.Add(phong_dto);
            }
            DataPrivder_NhanVien.Dongketnoi(conn);
            return phong;
        }
    }
}
