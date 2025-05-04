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
        public static DataTable GetAllMember()
        {
            return MemberDAO.GetALLMember();
        }
        // Hàm thêm thành viên nếu thành viên ko tồn tại!
        public static bool Addmember(MemberDTO member)
        {
            //Kiểm tra xem các dữ liệu có để trống không
            if (MemberDAO.IsEmptyInput(member))
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
                else
                {
                    if (MemberDAO.AddMember(member)) 
                        return MemberDAO.AutoAddAccount(member.member_id);
                }
            }
            MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        // Hàm sửa thông tin thành viên
        public static bool UpdateMember(MemberDTO member)
        {
            if (MemberDAO.IsEmptyInput(member))
            {
                return MemberDAO.UpdateMember(member);
            }
            else
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        // Hàm xóa thông tin thành viên
        public static bool DeleteMember(string member_id)
        {
            return MemberDAO.DeleteMember(member_id);
        }
        // Hàm tìm kiếm thành viên
        public static DataTable SearchMembers(string keyword)
        {
            return MemberDAO.SearchMembers(keyword);
        }
        // Hàm xóa nhiều thành viên theo điều kiện
        public static int DeleteMembersByCondition(string condition, string value)
        {
            return MemberDAO.DeleteMembersByCondition(condition, value);
        }
    }
}
