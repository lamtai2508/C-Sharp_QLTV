using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Resources
{
    class DatabaseHelper
    {
        private static String ConnectionString = "server=localhost;user=root;password='';database=qltv;port=3306";
        // Hàm kết nối database
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
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
        public static bool ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Thêm parameters vào để dễ sử dụng
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.ToString());
                    return false;
                }
            }
        }
        // Hàm kiểm tra xem phần từ có tồn tại không. 
        public static bool CheckIfExists(string tablename, string condition, Dictionary<string, object> parameters = null)
        {
            string query = $"select Count(*) From {tablename} where {condition}";
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                            }
                        }
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.ToString());
                    return false;
                }
            }
        }
    }
}
