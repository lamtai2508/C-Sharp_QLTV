using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.DTO
{
    internal class ViolationDTO
    {
        public string violation_id {  get; set; }
        public string member_id { get; set; }
        public string violation_date {  get; set; }
        public string violation_type {  get; set; }
        public string penalty {  get; set; }
        public string status {  get; set; }
        public ViolationDTO() { }

        public ViolationDTO (string violation_id, string member_id, string violation_date, string violation_type, string penalty, string status)
        {
            this.violation_id = violation_id;
            this.member_id = member_id;
            this.violation_date = violation_date;
            this.violation_type = violation_type;
            this.penalty = penalty;
            this.status = status;
        }
    }
}
