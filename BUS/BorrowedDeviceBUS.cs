using qltv.DTO;
using qltv_Winform.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv_Winform.BUS
{
    internal class BorrowedDeviceBUS
    {
        public static bool AddBorrowedDevice(BorrowedDeviceDTO borrowedDevice)
        {
            return BorrowedDeviceDAO.AddBorrowedDevice(borrowedDevice);
        }
    }
}
