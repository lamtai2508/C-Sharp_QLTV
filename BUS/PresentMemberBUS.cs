using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qltv.DAO;
using qltv.DTO;
using qltv_Winform.DAO;

namespace qltv.BUS
{
    internal class PresentMemberBUS
    {
        public static bool AddPresentMember(PresentMemberDTO presentMember)
        {
            // Thêm thành viên check in vào bảng presentmembers
            return PresentMemberDAO.AddPresentMemberExceptLeaveTime(presentMember);
        }

        public static bool UpdateLeaveTime(string member_id, DateTime leave_time)
        {
            // Kiểm tra nếu member co mat
            if (PresentMemberDAO.IsMemberInGroupWithNullLeaveTime(member_id))
            {
                return PresentMemberDAO.AddLeaveTimeToPresentMember(member_id, leave_time);
            }
            return false;
        }

        public static bool IsMemberInViolation (string member_id)
        {
            // Kiểm tra nếu member co mat
            if (PresentMemberDAO.IsMemberInGroupWithNullLeaveTime(member_id))
            {
                return PresentMemberDAO.IsMemberInViolation(member_id);
            }
            return false;
        }

        public static bool DeletePresentMemberByConditions(string member_id, DateTime appear_time)
        {
            // Xóa thành viên khỏi bảng presentmembers
            if (PresentMemberDAO.IsMemberInGroupWithNullLeaveTime(member_id))
            {
                return false;
            }
            return PresentMemberDAO.DeletePresentMemberByConditions(member_id, appear_time);
        }
    }
}
