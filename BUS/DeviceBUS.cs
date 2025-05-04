using qltv.DAO;
using qltv.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace qltv.BUS
{
    internal class DeviceBUS
    {
        // Lấy tất cả thiết bị
        public static DataTable GetAllDevices()
        {
            return DeviceDAO.GetAllDevices();
        }

        // Lấy thiết bị theo ID
        public static DeviceDTO GetDeviceById(string deviceId)
        {
            return DeviceDAO.GetDeviceById(deviceId);
        }

        // Thêm thiết bị mới
        public static bool AddDevice(DeviceDTO device)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(device.device_id) ||
                string.IsNullOrEmpty(device.device_name) ||
                string.IsNullOrEmpty(device.device_type))
            {
                return false;
            }

            // Kiểm tra xem thiết bị đã tồn tại chưa
            DeviceDTO existingDevice = DeviceDAO.GetDeviceById(device.device_id);
            if (existingDevice != null)
            {
                return false; // Thiết bị đã tồn tại
            }

            return DeviceDAO.AddDevice(device);
        }

        // Cập nhật thiết bị
        public static bool UpdateDevice(DeviceDTO device)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(device.device_id) ||
                string.IsNullOrEmpty(device.device_name) ||
                string.IsNullOrEmpty(device.device_type))
            {
                return false;
            }

            return DeviceDAO.UpdateDevice(device);
        }

        // Xóa thiết bị
        public static bool DeleteDevice(string deviceId)
        {
            if (string.IsNullOrEmpty(deviceId))
            {
                return false;
            }

            return DeviceDAO.DeleteDevice(deviceId);
        }

        // Tìm kiếm thiết bị
        public static DataTable SearchDevices(string keyword)
        {
            return DeviceDAO.SearchDevices(keyword);
        }

        // Lấy danh sách các loại thiết bị
        public static List<string> GetDeviceTypes()
        {
            List<string> deviceTypes = new List<string>();
            DataTable dt = DeviceDAO.GetAllDevices();

            foreach (DataRow row in dt.Rows)
            {
                string deviceType = row["device_type"].ToString();
                if (!deviceTypes.Contains(deviceType))
                {
                    deviceTypes.Add(deviceType);
                }
            }

            return deviceTypes;
        }

        // Lấy danh sách trạng thái thiết bị
        public static List<string> GetDeviceStatuses()
        {
            List<string> statuses = new List<string>();
            statuses.Add("Có sẵn");
            statuses.Add("Được đặt chỗ");
            statuses.Add("Đang được mượn");
            return statuses;
        }

        // Xóa nhiều thiết bị theo điều kiện
        public static int DeleteDevicesByCondition(string condition, string value)
        {
            return DeviceDAO.DeleteDevicesByCondition(condition, value);
        }
    }
}