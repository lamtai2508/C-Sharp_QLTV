using System;

namespace qltv.DTO
{
    internal class ViolationDTO
    {
        public string violation_id { get; set; }
        public string member_id { get; set; }
        public string violation_date { get; set; }
        public string violation_type { get; set; }
        public string penalty { get; set; }
        public string status { get; set; }
        public string block_date { get; set; }
        public string unblock_date { get; set; }
        public int warning_count { get; set; } // Theo dõi số lần cảnh cáo

        public ViolationDTO() { }

        public ViolationDTO(string violation_id, string member_id, string violation_date, string violation_type, 
            string penalty, string status, string block_date, string unblock_date, int warning_count)
        {
            this.violation_id = violation_id;
            this.member_id = member_id;
            this.violation_date = violation_date;
            this.violation_type = violation_type;
            this.penalty = penalty;
            this.status = status;
            this.block_date = block_date;
            this.unblock_date = unblock_date;
            this.warning_count = warning_count;
        }
    }
}