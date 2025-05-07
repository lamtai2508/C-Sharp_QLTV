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
            // Thêm thời gian check out vào bảng presentmembers
            return PresentMemberDAO.AddLeaveTimeToPresentMember(member_id, leave_time);
        }
    }
}
