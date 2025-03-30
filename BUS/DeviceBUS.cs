using qltv.DAO;
using qltv.DTO;
using System;
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
    }
}