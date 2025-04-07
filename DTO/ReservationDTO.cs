using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.DTO
{
    internal class ReservationDTO
    {
        public string reservation_id {  get; set; }
        public string member_id { get; set; }
        public string device_id { get; set; }
        public string reservation_date { get; set; }
        public string status { get; set; }
        public ReservationDTO() { }
        public ReservationDTO(string reservation_id, string member_id, string device_id, string reservation_date,string status)
        {
            this.reservation_id = reservation_id;
            this.member_id = member_id;
            this.device_id = device_id;
            this.reservation_date = reservation_date;
            this.status = status;
        }
    }
}
