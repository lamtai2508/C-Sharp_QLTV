using qltv.DAO;
using qltv.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.BUS
{
    internal class ReservationBUS
    {
        public static DataTable GetAllReservation()
        {
            return RevervationDAO.GetALLReservation();
        }

        // Cập nhật trạng thái đơn đặt chỗ
        public static bool UpdateReservationStatus(string reservationId, string status)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(reservationId) || string.IsNullOrEmpty(status))
            {
                return false;
            }

            // Kiểm tra trạng thái hợp lệ
            if (status != "Chấp nhận" && status != "Từ chối" && status != "Chờ duyệt")
            {
                return false;
            }

            // Lấy thông tin đơn đặt chỗ hiện tại
            ReservationDTO reservation = RevervationDAO.GetReservationById(reservationId);
            if (reservation == null || reservation.status != "Chờ duyệt")
            {
                // Chỉ cập nhật đơn đang ở trạng thái "Chờ duyệt"
                return false;
            }

            return RevervationDAO.UpdateReservationStatus(reservationId, status);
        }

        // Lấy thông tin đơn đặt chỗ theo mã
        public static ReservationDTO GetReservationById(string reservationId)
        {
            return RevervationDAO.GetReservationById(reservationId);
        }
    }
}