using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.DTO
{
    public class MemberDTO
    {
        public string member_id { get; set; }
        public string full_name { get; set; }
        public string gender { get; set; }

        public string number_phone { get; set; }

        public DateTime dob { get; set; }

        public string email { get; set; }

        public string status { get; set; }

        public MemberDTO() { }

        public MemberDTO(string member_id, string full_name, string gender, string number_phone, DateTime dob, string email , string status)
        {
            this.member_id = member_id;
            this.full_name = full_name;
            this.gender = gender;
            this.number_phone = number_phone;
            this.dob = dob;
            this.email = email;
            this.status = status;
        }
    }
}
