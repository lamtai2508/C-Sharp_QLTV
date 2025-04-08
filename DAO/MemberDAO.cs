using MySql.Data.MySqlClient;
using qltv.DTO;
using QLTV.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        // Lấy thông tin thành viên dựa theo mã thành viên
        public static MemberDTO GetMemberById(string member_id)
        {
            string query = "Select * from members where member_id = @member_id";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@member_id", member_id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new MemberDTO
                        {
                            member_id = reader["member_id"].ToString(),
                            full_name = reader["full_name"].ToString(),
                            gender = reader["gender"].ToString(),
                            number_phone = reader["number_phone"].ToString(),
                            dob = Convert.ToDateTime(reader["dob"]),
                            email = reader["email"].ToString()
                        };
                    }
                }
            }
            return null;
        }
        // Hàm kiểm tra xem dữ liệu có để trống hay ko. 
        public static bool IsEmptyInput(MemberDTO member)
        {
            if (string.IsNullOrEmpty(member.member_id) ||
                string.IsNullOrEmpty(member.full_name) ||
                string.IsNullOrEmpty(member.gender) ||
                string.IsNullOrEmpty(member.number_phone) ||
                member.dob == DateTime.MinValue ||
                string.IsNullOrEmpty(member.email)
                )
            {
                return false;
            }
            return true;
        }
        // Hàm kiểm tra có dịnh dạng của member trước khi lưu
        public static bool VailidateInputMember(MemberDTO member, out string errorMessage)
        {
            // Kiểm tra ngày sinh
            if (!DateTime.TryParseExact(member.dob.ToString("yyyy-MM-dd"), "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out _))
            {
                errorMessage = "Ngày sinh không đúng định dạng yyyy-MM-dd ";
                return false;
            }
            //Kiểm tra email có kết thúc bằng @gmail.com không
            if (!member.email.EndsWith("@gmail.com"))
            {
                errorMessage = "Email phải kết thúc bằng @gmail.com ";
                return false;
            }
            // Kiểm tra giới tính
            if(member.gender.ToLower() != "nam" && member.gender.ToLower() != "nữ")
            {
                errorMessage = "Giới tính phải là Nam hoặc Nữ";
                return false;
            }
            // Kiểm tra số điện thoại có bắt đầu bằng số 0 hay ko
            if(!Regex.IsMatch(member.number_phone,@"^0"))
            {
                errorMessage = "Số điện thoại phải bắt đầu bằng số không!";
                return false;
            }
            // Kiếm tra số điện thoại có đúng 10 chữ số không
            if(!Regex.IsMatch(member.number_phone, @"\d{10}$"))
            {
                errorMessage = "Số điện thoại phải có đúng 10 số";
                return false;
            }
            errorMessage = null;
            return true;
        }
        // Thêm mới 1 thành viên
        public static bool AddMember(MemberDTO member) 
        {
            // Kiểm tra dữ liệu trước khi thêm mới
            if (VailidateInputMember(member, out string errorMessage))
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
                return DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            else
            {
                MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // Sửa thông tin thành viên
        public static bool UpdateMember(MemberDTO member)
        {
            if(VailidateInputMember(member, out string errorMessage))
            {
                string query = "update members set full_name = @full_name, gender = @gender, number_phone = @number_phone, dob = @dob, email = @email " +
               "where member_id = @member_id";
                var parameters = new Dictionary<string, object>
                {
                    { "@member_id", member.member_id },
                    { "@full_name", member.full_name },
                    { "@gender", member.gender },
                    { "@number_phone", member.number_phone },
                    { "@dob", member.dob.ToString("yyyy-MM-dd")},
                    { "@email", member.email }
                };
                return DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            else
            {
                MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool DeleteMember(string member_id)
        {
            string query = "Delete from members where member_id = @member_id";
            var parameters = new Dictionary<string, object>
                {
                    { "@member_id", member_id }
                };
            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
            
    }
}
