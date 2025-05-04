using MySql.Data.MySqlClient;
using qltv.DTO;
using QLTV.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace qltv_Winform.DAO
{
    internal class BorrowedDeviceDAO
    {
        public static bool AddBorrowedDevice(BorrowedDeviceDTO borrowedDevice)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO borroweddevices (member_id, device_id, borrow_date,due_date, return_date, status) " +
                    "VALUES (@member_id, @device_id, @borrow_date,@due_date, @return_date, @status)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@member_id", borrowedDevice.member_id);
                cmd.Parameters.AddWithValue("@device_id", borrowedDevice.device_id);
                cmd.Parameters.AddWithValue("@borrow_date", borrowedDevice.borrow_date);
                cmd.Parameters.AddWithValue("@due_date", borrowedDevice.borrow_date);
                cmd.Parameters.AddWithValue("@return_date", borrowedDevice.return_date);
                cmd.Parameters.AddWithValue("@status", borrowedDevice.status);

                int rowsEffect = cmd.ExecuteNonQuery();
                return rowsEffect > 0;
            }
        }
    }
}
