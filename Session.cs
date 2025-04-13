using qltv.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv
{
    public static class Session
    {
        // Dùng để lấy tài khoản của người đăng nhập
        public static MemberDTO CurrentMember { get; set; }
    }
}
