using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Resources
{
    class DatabaseHelep
    {
        private static String ConnectionString = "server=localhost;user=root;password=;database=qltv;port=3306";
        private static MySqlConnection conn;
        public static MySqlConnection GetConnection()
        {
            return conn = new MySqlConnection(ConnectionString);
        }
        // Hàm lấy dữ liệu từ bảng 
        public static DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
            return dt;
        }

        // Hàm thực thi INSERT, UPDATE, DELETE
        public bool ExecuteQuery(string query)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
