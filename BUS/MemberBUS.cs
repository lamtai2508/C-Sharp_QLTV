using qltv.DAO;
using qltv.DTO;
using QLTV.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.BUS
{
    internal class MemberBUS
    {
        // Lấy toàn bộ dữ liêu bảng member
        public static DataTable GetAllMenber()
        {
            return MemberDAO.GetALLMember();
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
        // Hàm thêm thành viên nếu thành viên ko tồn tại!
        public static bool Addmember(MemberDTO member)
        {
            //Kiểm tra xem các dữ liệu có để trống không
            if (IsEmptyInput(member))
            {
                //kiểm tra xem thành viên có tồn tại hay chưa
                string condition = "member_id = @member_id";
                var parameters = new Dictionary<string, object>
                {
                    { "@member_id", member.member_id }
                };
                //nếu tồn tại, thông báo lỗi
                if (DatabaseHelper.CheckIfExists("members", condition, parameters))
                {
                    MessageBox.Show("Thành viên đã tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return MemberDAO.AddMember(member);
            }
            MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}
