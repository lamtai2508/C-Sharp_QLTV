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


    }
}
