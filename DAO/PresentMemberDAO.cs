using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using qltv.DTO;
using QLTV.Resources;

namespace qltv_Winform.DAO
{
    internal class PresentMemberDAO
    {

        // lấy tất cả dữ liệu của bảng presentmembers
        public static DataTable GetALLPresentMember()
        {
            string query = "select * from presentmembers";
            return DatabaseHelper.GetData(query);
        }

        // add leavetime to presentmember by member_id
        public static bool AddLeaveTimeToPresentMember(string member_id, DateTime leave_time)
        {
            string query = "update presentmembers set leavetime = @leave_time where member_id = @member_id";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@member_id", member_id);
                    cmd.Parameters.AddWithValue("@leave_time", leave_time);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // thêm thành viên vào bảng presentmembers
        public static bool AddPresentMemberExceptLeaveTime(PresentMemberDTO presentMember)
        {
            string query = "insert into presentmembers(member_id, full_name, appeartime) values(@member_id, @full_name, @appear_time)";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@member_id", presentMember.member_id);
                    cmd.Parameters.AddWithValue("@full_name", presentMember.full_name);
                    cmd.Parameters.AddWithValue("@appear_time", presentMember.appear_time);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public static bool IsMemberInGroupWithNullLeaveTime(string member_id)
        {
            string query = "SELECT COUNT(*) FROM presentmembers WHERE leavetime IS NULL AND member_id = @member_id";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@member_id", member_id);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Return true if the member exists in the group
                }
            }
        }

        // check if member_id exists in violation
        public static bool IsMemberInViolation(string member_id)
        {
            string query = "SELECT COUNT(*) FROM violations WHERE member_id = @member_id";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@member_id", member_id);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Return true if the member exists in the group
                }
            }
        }


        // Delete a present member by multiple conditions
        public static bool DeletePresentMemberByConditions(string? member_id, DateTime? appear_time)
        {
            string query = "DELETE FROM presentmembers WHERE member_id = @member_id AND appeartime = @appear_time";

            // Add an additional condition for leave_time if it's provided


            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@member_id", member_id);
                    cmd.Parameters.AddWithValue("@appear_time", appear_time);


                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if at least one row was deleted
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }



    }
}
