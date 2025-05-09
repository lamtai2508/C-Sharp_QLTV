﻿using MySql.Data.MySqlClient;
using qltv.DTO;
using QLTV.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace qltv.DAO
{
    internal class ViolationDAO
    {
        public static DataTable GetAllViolation()
        {
            string query = "SELECT * FROM violations";
            return DatabaseHelper.GetData(query);
        }

        public static ViolationDTO GetViolationById(string violation_id)
        {
            string query = "SELECT * FROM violations WHERE violation_id = @violation_id";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@violation_id", violation_id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ViolationDTO
                        {
                            violation_id = reader["violation_id"].ToString(),
                            member_id = reader["member_id"].ToString(),
                            violation_date = reader["violation_date"].ToString(),
                            violation_type = reader["violation_type"].ToString(),
                            penalty = reader["penalty"].ToString(),
                            status = reader["status"].ToString(),
                            block_date = reader["block_date"] != DBNull.Value ? reader["block_date"].ToString() : null,
                            unblock_date = reader["unblock_date"] != DBNull.Value ? reader["unblock_date"].ToString() : null,
                            warning_count = Convert.ToInt32(reader["warning_count"])
                        };
                    }
                }
            }
            return null;
        }

        public static ViolationDTO GetViolationByIdForMember(string member_id)
        {
            string query = "SELECT violation_id FROM violations WHERE member_id = @member_id LIMIT 1";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@member_id", member_id);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return GetViolationById(result.ToString());
                }
            }
            return null;
        }

        public static string GetMaxViolationId()
        {
            string query = "SELECT MAX(violation_id) FROM violations";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? result.ToString() : null;
            }
        }

        public static bool IsEmptyInput(ViolationDTO violation)
        {
            if (string.IsNullOrEmpty(violation.violation_id) ||
                string.IsNullOrEmpty(violation.member_id) ||
                string.IsNullOrEmpty(violation.violation_date) ||
                string.IsNullOrEmpty(violation.violation_type) ||
                string.IsNullOrEmpty(violation.penalty) ||
                string.IsNullOrEmpty(violation.status))
            {
                return false;
            }
            return true;
        }

        public static bool ValidateInputViolation(ViolationDTO violation, out string errorMessage)
        {
            if (!string.IsNullOrEmpty(violation.violation_date) &&
                !DateTime.TryParseExact(violation.violation_date, "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out _))
            {
                errorMessage = "Ngày vi phạm không đúng định dạng yyyy-MM-dd";
                return false;
            }

            string[] validStatuses = { "Đang hoạt động", "Khóa tạm thời", "Khóa vĩnh viễn" };
            if (!validStatuses.Contains(violation.status))
            {
                errorMessage = "Trạng thái phải là 'Đang hoạt động', 'Khóa tạm thời', hoặc 'Khóa vĩnh viễn'";
                return false;
            }

            if (violation.status == "Khóa tạm thời" && string.IsNullOrEmpty(violation.unblock_date))
            {
                errorMessage = "Khóa tạm thời phải có ngày mở khóa";
                return false;
            }

            if (!string.IsNullOrEmpty(violation.block_date) &&
                !DateTime.TryParseExact(violation.block_date, "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out _))
            {
                errorMessage = "Ngày khóa không đúng định dạng yyyy-MM-dd";
                return false;
            }

            if (!string.IsNullOrEmpty(violation.unblock_date) &&
                !DateTime.TryParseExact(violation.unblock_date, "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out _))
            {
                errorMessage = "Ngày mở khóa không đúng định dạng yyyy-MM-dd";
                return false;
            }

            errorMessage = null;
            return true;
        }

        public static bool AddViolation(ViolationDTO violation)
        {
            if (ValidateInputViolation(violation, out string errorMessage))
            {
                string query = "INSERT INTO violations (violation_id, member_id, violation_date, violation_type, penalty, status, block_date, unblock_date, warning_count) " +
                               "VALUES (@violation_id, @member_id, @violation_date, @violation_type, @penalty, @status, @block_date, @unblock_date, @warning_count)";
                var parameters = new Dictionary<string, object>
                {
                    { "@violation_id", violation.violation_id },
                    { "@member_id", violation.member_id },
                    { "@violation_date", violation.violation_date },
                    { "@violation_type", violation.violation_type },
                    { "@penalty", violation.penalty },
                    { "@status", violation.status },
                    { "@block_date", violation.block_date ?? (object)DBNull.Value },
                    { "@unblock_date", violation.unblock_date ?? (object)DBNull.Value },
                    { "@warning_count", violation.warning_count }
                };
                return DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            else
            {
                MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool UpdateViolation(ViolationDTO violation)
        {
            if (ValidateInputViolation(violation, out string errorMessage))
            {
                string query = "UPDATE violations SET member_id = @member_id, violation_date = @violation_date, " +
                               "violation_type = @violation_type, penalty = @penalty, status = @status, " +
                               "block_date = @block_date, unblock_date = @unblock_date, warning_count = @warning_count " +
                               "WHERE violation_id = @violation_id";
                var parameters = new Dictionary<string, object>
                {
                    { "@violation_id", violation.violation_id },
                    { "@member_id", violation.member_id },
                    { "@violation_date", violation.violation_date },
                    { "@violation_type", violation.violation_type },
                    { "@penalty", violation.penalty },
                    { "@status", violation.status },
                    { "@block_date", violation.block_date ?? (object)DBNull.Value },
                    { "@unblock_date", violation.unblock_date ?? (object)DBNull.Value },
                    { "@warning_count", violation.warning_count }
                };
                return DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            else
            {
                MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool DeleteViolation(string violation_id)
        {
            string query = "DELETE FROM violations WHERE violation_id = @violation_id";
            var parameters = new Dictionary<string, object>
            {
                { "@violation_id", violation_id }
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public static DataTable SearchViolation(string keyword)
        {
            string query = "SELECT * FROM violations WHERE violation_id LIKE @keyword OR member_id LIKE @keyword OR violation_type LIKE @keyword OR penalty LIKE @keyword OR status LIKE @keyword";
            var parameters = new Dictionary<string, object>
            {
                { "@keyword", "%" + keyword + "%" }
            };
            return DatabaseHelper.GetData(query, parameters);
        }

        public static int GetWarningCount(string member_id)
        {
            string query = "SELECT SUM(warning_count) FROM violations WHERE member_id = @member_id";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@member_id", member_id);
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }

        public static void AutoUnblock()
        {
            string query = "UPDATE violations SET status = 'Đang hoạt động', unblock_date = NULL, block_date = NULL " +
                           "WHERE status = 'Khóa tạm thời' AND unblock_date <= @today";
            var parameters = new Dictionary<string, object>
            {
                { "@today", DateTime.Now.ToString("yyyy-MM-dd") }
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}