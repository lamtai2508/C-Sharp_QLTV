using MySql.Data.MySqlClient;
using qltv.DTO;
using QLTV.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.DAO
{
    internal class RevervationDAO
    {
        public static DataTable GetALLReservation()
        {
            string query = "select * from reservations";
            return DatabaseHelper.GetData(query);
        }

        // Cập nhật trạng thái đơn đặt chỗ
        public static bool UpdateReservationStatus(string reservationId, string status)
        {
            string query = "UPDATE reservations SET status = @status WHERE reservation_id = @reservation_id";

            var parameters = new Dictionary<string, object>
            {
                { "@reservation_id", reservationId },
                { "@status", status }
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // Lấy thông tin đơn đặt chỗ theo mã
        public static ReservationDTO GetReservationById(string reservationId)
        {
            string query = "SELECT * FROM reservations WHERE reservation_id = @reservation_id";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@reservation_id", reservationId);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ReservationDTO
                        {
                            reservation_id = reader["reservation_id"].ToString(),
                            member_id = reader["member_id"].ToString(),
                            device_id = reader["device_id"].ToString(),
                            reservation_date = reader["reservation_date"].ToString(),
                            status = reader["status"].ToString()
                        };
                    }
                }
            }
            return null;
        }
    }
}