using MySql.Data.MySqlClient;
using qltv.DTO;
using QLTV.Resources;
using System;
using System.Collections.Generic;

namespace qltv.DAO
{
    public class StatisticsDAO
    {
        private static string connectionString = "Server=127.0.0.1;Database=qltv;Uid=root;Pwd=;"; // Update password as needed

        public List<StatisticsMemberVisitDTO> GetMemberVisitStatistics(DateTime startDate, DateTime endDate)
        {
            List<StatisticsMemberVisitDTO> result = new List<StatisticsMemberVisitDTO>();
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        DATE(p.appeartime) AS visit_date,
                        m.status,
                        COUNT(DISTINCT p.member_id) AS member_count
                    FROM presentmembers p
                    JOIN members m ON p.member_id = m.member_id
                    WHERE p.appeartime BETWEEN @StartDate AND @EndDate
                    GROUP BY DATE(p.appeartime), m.status
                    ORDER BY visit_date, m.status";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new StatisticsMemberVisitDTO
                            {
                                VisitDate = reader.GetDateTime("visit_date"),
                                Status = reader.GetString("status"),
                                MemberCount = reader.GetInt32("member_count")
                            });
                        }
                    }
                }
            }
            return result;
        }

        public List<StatisticsDeviceBorrowingDTO> GetDeviceBorrowingStatistics(DateTime startDate, DateTime endDate)
        {
            List<StatisticsDeviceBorrowingDTO> result = new List<StatisticsDeviceBorrowingDTO>();
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        r.borrowed_date,
                        d.device_name,
                        COUNT(r.reservation_id) AS borrow_count
                    FROM reservations r
                    JOIN devices d ON r.device_id = d.device_id
                    WHERE r.borrowed_date BETWEEN @StartDate AND @EndDate
                        AND r.status = 'Chấp nhận'
                    GROUP BY r.borrowed_date, d.device_name
                    ORDER BY r.borrowed_date, d.device_name";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new StatisticsDeviceBorrowingDTO
                            {
                                BorrowedDate = reader.GetDateTime("borrowed_date"),
                                DeviceName = reader.GetString("device_name"),
                                BorrowCount = reader.GetInt32("borrow_count")
                            });
                        }
                    }
                }
            }
            return result;
        }

        public List<StatisticsBorrowedDeviceDTO> GetCurrentBorrowedDevices(DateTime startDate, DateTime endDate)
        {
            List<StatisticsBorrowedDeviceDTO> result = new List<StatisticsBorrowedDeviceDTO>();
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        bd.borrow_date AS borrowed_date,
                        d.device_name,
                        bd.member_id,
                        bd.status
                    FROM borroweddevices bd
                    JOIN devices d ON bd.device_id = d.device_id
                    WHERE bd.borrow_date BETWEEN @StartDate AND @EndDate
                        AND bd.status = 'Đang mượn'
                    ORDER BY bd.borrow_date, d.device_name";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new StatisticsBorrowedDeviceDTO
                            {
                                BorrowedDate = reader.GetDateTime("borrowed_date"),
                                DeviceName = reader.GetString("device_name"),
                                MemberId = reader.GetString("member_id"),
                                Status = reader.GetString("status")
                            });
                        }
                    }
                }
            }
            return result;
        }

        public List<StatisticsViolationDTO> GetViolationStatistics()
        {
            List<StatisticsViolationDTO> result = new List<StatisticsViolationDTO>();
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        v.violation_id,
                        v.member_id,
                        v.violation_date,
                        v.status,
                        v.penalty
                    FROM violations v
                    ORDER BY v.violation_date DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string penalty = reader.GetString("penalty");
                            double compensation = 0;
                            if (penalty.StartsWith("Phạt:"))
                            {
                                string amountStr = penalty.Replace("Phạt: ", "").Replace("$", "").Trim();
                                if (double.TryParse(amountStr, out double amount))
                                {
                                    compensation = amount * 25000; // Convert USD to VND (1 USD = 25,000 VND)
                                }
                            }

                            string status = reader.GetString("status");
                            string mappedStatus = (status == "Khóa tạm thời" || status == "Khóa vĩnh viễn") ? "Handled" : "InProgress";

                            result.Add(new StatisticsViolationDTO
                            {
                                ViolationId = reader.GetString("violation_id"),
                                MemberId = reader.GetString("member_id"),
                                ViolationDate = reader.GetDateTime("violation_date"),
                                Status = mappedStatus,
                                CompensationAmount = compensation
                            });
                        }
                    }
                }
            }
            return result;
        }

        public List<StatisticsActiveMemberDTO> GetActiveMemberStatistics()
        {
            List<StatisticsActiveMemberDTO> result = new List<StatisticsActiveMemberDTO>();
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        p.member_id,
                        p.full_name,
                        p.appeartime
                    FROM presentmembers p
                    WHERE p.leavetime IS NULL 
                        OR p.leavetime > NOW()
                    ORDER BY p.appeartime";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new StatisticsActiveMemberDTO
                            {
                                MemberId = reader.GetString("member_id"),
                                FullName = reader.GetString("full_name"),
                                AppearTime = reader.GetDateTime("appeartime")
                            });
                        }
                    }
                }
            }
            return result;
        }

        public bool IsAdmin(string accountId, string password)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT role FROM account WHERE account_id = @AccountId AND password = @Password";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", accountId);
                    cmd.Parameters.AddWithValue("@Password", password);
                    object result = cmd.ExecuteScalar();
                    return result != null && Convert.ToInt32(result) == 0;
                }
            }
        }
    }
}