using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.DTO
{
    public class PresentMemberDTO
    {
        public string member_id { get; set; }
        public string full_name { get; set; }
        public DateTime appear_time { get; set; }
        public DateTime leave_time { get; set; }

        public PresentMemberDTO(string member_id, string full_name, DateTime appear_time, DateTime leave_time) { 
            this.member_id = member_id;
            this.full_name = full_name;
            this.appear_time = appear_time;
            this.leave_time = leave_time;
        }

    }
}
