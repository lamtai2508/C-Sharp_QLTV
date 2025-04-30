using MySql.Data.MySqlClient;
using qltv.DTO;
using QLTV.Resources;
using System;
using System.Collections.Generic;
using System.Data;

namespace qltv.DAO
{
    internal class DeviceDAO
    {
        // Lấy tất cả thiết bị
        public static DataTable GetAllDevices()
        {
            string query = "SELECT * FROM devices";
            return DatabaseHelper.GetData(query);
        }

        // Lấy thiết bị theo ID
        public static DeviceDTO GetDeviceById(string deviceId)
        {
            string query = "SELECT * FROM devices WHERE device_id = @device_id";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@device_id", deviceId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new DeviceDTO
                    {
                        device_id = reader["device_id"].ToString(),
                        device_name = reader["device_name"].ToString(),
                        device_type = reader["device_type"].ToString(),
                        status = reader["status"].ToString()
                    };
                }
            }
            return null;
        }

        // Thêm thiết bị mới
        public static bool AddDevice(DeviceDTO device)
        {
            string query = "INSERT INTO devices (device_id, device_name, device_type, status) " +
                          "VALUES (@device_id, @device_name, @device_type, @status)";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@device_id", device.device_id);
                    cmd.Parameters.AddWithValue("@device_name", device.device_name);
                    cmd.Parameters.AddWithValue("@device_type", device.device_type);
                    cmd.Parameters.AddWithValue("@status", device.status);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // Cập nhật thiết bị
        public static bool UpdateDevice(DeviceDTO device)
        {
            string query = "UPDATE devices SET device_name = @device_name, device_type = @device_type, " +
                          "status = @status WHERE device_id = @device_id";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@device_id", device.device_id);
                    cmd.Parameters.AddWithValue("@device_name", device.device_name);
                    cmd.Parameters.AddWithValue("@device_type", device.device_type);
                    cmd.Parameters.AddWithValue("@status", device.status);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // Xóa thiết bị
        public static bool DeleteDevice(string deviceId)
        {
            string query = "DELETE FROM devices WHERE device_id = @device_id";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@device_id", deviceId);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // Tìm kiếm thiết bị
        public static DataTable SearchDevices(string keyword)
        {
            string query = "SELECT * FROM devices WHERE device_id LIKE @keyword " +
                          "OR device_name LIKE @keyword OR device_type LIKE @keyword";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                return dt;
            }
        }

        // Xóa nhiều thiết bị theo điều kiện
        public static int DeleteDevicesByCondition(string conditionType, string value)
        {
            string query = "";

            switch (conditionType)
            {
                case "Xóa theo loại thiết bị":
                    query = "DELETE FROM devices WHERE device_type = @value";
                    break;
                case "Xóa theo trạng thái":
                    query = "DELETE FROM devices WHERE status = @value";
                    break;
                case "Xóa theo mã thiết bị (bắt đầu bằng)":
                    query = "DELETE FROM devices WHERE device_id LIKE @value";
                    value = value + "%";
                    break;
                default:
                    return 0;
            }

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@value", value);

                    return cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }
    }
}