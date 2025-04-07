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
            string condition = $"member_id = @member_id";
            if(IsEmptyInput(member) == true)
            {
                if (DatabaseHelper.CheckIfExists("member", condition))
                {
                    MessageBox.Show("Thành viên đã tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    bool isAdd = MemberDAO.AddMember(member);
                    if (isAdd)
                    {
                        MessageBox.Show("Thêm thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    return isAdd;
                }
            }
            MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}
