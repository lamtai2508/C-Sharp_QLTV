using qltv.DAO;
using qltv.DTO;
using System;
using System.Data;
using System.Collections.Generic;

namespace qltv.BUS
{
    public static class StatisticsBUS
    {
        private static readonly StatisticsDAO dao = new StatisticsDAO();

        public static DataTable GetMemberVisitStatistics(DateTime startDate, DateTime endDate)
        {
            List<StatisticsMemberVisitDTO> data = dao.GetMemberVisitStatistics(startDate, endDate);
            DataTable dt = new DataTable();
            dt.Columns.Add("visit_date", typeof(DateTime));
            dt.Columns.Add("status", typeof(string));
            dt.Columns.Add("member_count", typeof(int));

            foreach (var item in data)
            {
                dt.Rows.Add(item.VisitDate, item.Status, item.MemberCount);
            }
            return dt;
        }

        public static DataTable GetDeviceBorrowingStatistics(DateTime startDate, DateTime endDate)
        {
            List<StatisticsDeviceBorrowingDTO> data = dao.GetDeviceBorrowingStatistics(startDate, endDate);
            DataTable dt = new DataTable();
            dt.Columns.Add("borrowed_date", typeof(DateTime));
            dt.Columns.Add("device_name", typeof(string));
            dt.Columns.Add("borrow_count", typeof(int));

            foreach (var item in data)
            {
                dt.Rows.Add(item.BorrowedDate, item.DeviceName, item.BorrowCount);
            }
            return dt;
        }

        public static DataTable GetCurrentBorrowedDevices(DateTime startDate, DateTime endDate)
        {
            List<StatisticsBorrowedDeviceDTO> data = dao.GetCurrentBorrowedDevices(startDate, endDate);
            DataTable dt = new DataTable();
            dt.Columns.Add("borrowed_date", typeof(DateTime));
            dt.Columns.Add("device_name", typeof(string));
            dt.Columns.Add("member_id", typeof(string));
            dt.Columns.Add("status", typeof(string));

            foreach (var item in data)
            {
                dt.Rows.Add(item.BorrowedDate, item.DeviceName, item.MemberId, item.Status);
            }
            return dt;
        }

        public static DataTable GetViolationStatistics()
        {
            List<StatisticsViolationDTO> data = dao.GetViolationStatistics();
            DataTable dt = new DataTable();
            dt.Columns.Add("violation_id", typeof(string));
            dt.Columns.Add("member_id", typeof(string));
            dt.Columns.Add("violation_date", typeof(DateTime));
            dt.Columns.Add("status", typeof(string));
            dt.Columns.Add("compensation_amount", typeof(double));

            foreach (var item in data)
            {
                dt.Rows.Add(item.ViolationId, item.MemberId, item.ViolationDate, item.Status, item.CompensationAmount);
            }
            return dt;
        }

        public static DataTable GetActiveMemberStatistics()
        {
            List<StatisticsActiveMemberDTO> data = dao.GetActiveMemberStatistics();
            DataTable dt = new DataTable();
            dt.Columns.Add("member_id", typeof(string));
            dt.Columns.Add("full_name", typeof(string));
            dt.Columns.Add("appear_time", typeof(DateTime));

            foreach (var item in data)
            {
                dt.Rows.Add(item.MemberId, item.FullName, item.AppearTime);
            }
            return dt;
        }
    }
}