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
    public  class DataPrivder_NhanVien
    {
        /// <summary>
        /// tạo hàm mở kết nối SQL
        /// </summary>
        /// <returns>hàm kết nối</returns>
        public static SqlConnection Hamketnoi()
        {
            string connect = @"Data Source=HOANGBAO\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            return conn;
        }
        /// <summary>
        /// tạo hàm đóng kết nối
        /// </summary>
        /// <param name="conn"></param>
        public static void Dongketnoi(SqlConnection conn)
        {
            conn.Close();
        }
        /// <summary>
        /// truy vấn trả về danh sách 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static DataTable Load(string query, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
        /// <summary>
        /// truy vấn không trả về danh sách
        /// </summary>
        /// <param name="query"></param>
        /// <param name="conn"></param>
        public static void ExcuteNonQuery(string query, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.ExecuteNonQuery();
        }
    }
}
