using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.DTO
{
    internal class MemberHistoryDTO
    {
        public string member_id {  get; set; }
        public string device_id { get; set; }
        public string violation_id { get; set; }
        public string reservation_id { get; set; }
        public MemberHistoryDTO() { }
        public MemberHistoryDTO(string member_id, string device_id, string violation_id, string reservation_id)
        {
            this.member_id = member_id;
            this.device_id = device_id;
            this.violation_id = violation_id;
            this.reservation_id = reservation_id;
        }
    }
}