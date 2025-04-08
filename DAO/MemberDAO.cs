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
    internal class MemberDAO
    {
        // lấy tất cả dữ liệu của bảng member
        public static DataTable GetALLMember() 
        {
            string query = "select * from members";
            return DatabaseHelper.GetData(query);
        }
        // Thêm mới 1 thành viên
        public static bool AddMember(MemberDTO member) 
        {
                string query = "insert into members (member_id, full_name, gender, number_phone, dob, email)" +
                    "values(@member_id, @full_name, @gender, @number_phone, @dob, @email)";
                var parameters = new Dictionary<string, object>
                {
                    { "@member_id", member.member_id },
                    { "@full_name", member.full_name },
                    { "@gender", member.gender },
                    { "@number_phone", member.number_phone },
                    { "@dob", member.dob.ToString("yyyy-MM-dd")},
                    { "@email", member.email }
                };
                return DatabaseHelper.ExecuteQuery(query, parameters);
        }
    }
}
