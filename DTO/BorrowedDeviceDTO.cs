using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.DTO
{
    internal class BorrowedDeviceDTO
    {
        public string borrowed_id {  get; set; }
        public string member_id {  get; set; }
        public string device_id {  get; set; }
        public DateTime borrow_date {  get; set; }
        public DateTime due_date { get; set; }

        public DateTime return_date {  get; set; }
        public string status {  get; set; }
        public BorrowedDeviceDTO() { }
        public BorrowedDeviceDTO(string borrowed_id, string member_id, string device_id, DateTime borrow_date, DateTime due_date , DateTime return_date, string status)
        {
            this.borrowed_id = borrowed_id;
            this.member_id = member_id;
            this.device_id = device_id;
            this.borrow_date = borrow_date;
            this.due_date = borrow_date;
            this.return_date = return_date;
            this.status = status;
        }
    }
}
