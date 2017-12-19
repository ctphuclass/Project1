using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        public static string connect = @"Data Source=HOANGBAO\SQLEXPRESS;Initial Catalog=QuanLyKhachSan010;Integrated Security=True";


        public static DataTable ExecuteQuery(string query)
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            con.Close();
            return table;
        }
        public static bool ExecuteNonQuery(string query)
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public static SqlConnection HamKetNoi()
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            return con;
        }
        public static void DongKetNoi(SqlConnection con)
        {
            con.Close();
        }
        public static DataTable Load(string squery, SqlConnection con)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(squery, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

    }
}
