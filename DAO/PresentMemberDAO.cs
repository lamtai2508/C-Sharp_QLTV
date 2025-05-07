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
            // Lấy tất cả trừ admin ra
            string query = "select * from presentmembers";
            return DatabaseHelper.GetData(query);
        }

        

        // thêm thành viên vào bảng presentmembers
        public static bool AddPresentMember(PresentMemberDTO presentMember)
        {
            string query = "insert into presentmembers(member_id, full_name, appear_time, leave_time) values(@member_id, @full_name, @appear_time, @leave_time)";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@member_id", presentMember.member_id);
                    cmd.Parameters.AddWithValue("@full_name", presentMember.full_name);
                    cmd.Parameters.AddWithValue("@appear_time", presentMember.appear_time);
                    cmd.Parameters.AddWithValue("@leave_time", presentMember.leave_time);
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


    }
}
