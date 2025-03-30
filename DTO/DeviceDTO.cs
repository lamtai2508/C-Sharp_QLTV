using System;

namespace qltv.DTO
{
    internal class DeviceDTO
    {
        public string device_id { get; set; }
        public string device_name { get; set; }
        public string device_type { get; set; }
        public string status { get; set; }

        public DeviceDTO() { }

        public DeviceDTO(string device_id, string device_name, string device_type, string status)
        {
            this.device_id = device_id;
            this.device_name = device_name;
            this.device_type = device_type;
            this.status = status;
        }
    }
}