using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.DTO
{
    internal class accountDTO
    {
        public string account_id { get; set; }
        public string password { get; set; }
        public int role { get; set; }

        public accountDTO() { }

        public accountDTO(string account_id, string password, int role)
        {
            account_id = account_id;
            password = password;
            role = role;
        }
    } 
}
