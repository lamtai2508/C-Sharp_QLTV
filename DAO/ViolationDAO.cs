using MySql.Data.MySqlClient;
using qltv.DTO;
using QLTV.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace qltv.DAO
{
    internal class ViolationDAO
    {
        public static DataTable GetALlViolation()
        {
            string query = "SELECT * FROM violations";
            return DatabaseHelper.GetData(query);
        }

        // Lấy thông tin vi phạm dựa theo mã vi phạm
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
                            status = reader["status"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        // Lấy mã vi phạm lớn nhất
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

        // Kiểm tra xem dữ liệu có để trống hay không
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

        // Kiểm tra định dạng của vi phạm trước khi lưu
        public static bool ValidateInputViolation(ViolationDTO violation, out string errorMessage)
        {
            // Kiểm tra ngày vi phạm
            if (!DateTime.TryParseExact(violation.violation_date, "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out _))
            {
                errorMessage = "Ngày vi phạm không đúng định dạng yyyy-MM-dd";
                return false;
            }

            // Kiểm tra trạng thái
            string[] validStatuses = { "Đang hoạt động", "Khóa tạm thời", "Khóa vĩnh viễn" };
            if (!validStatuses.Contains(violation.status))
            {
                errorMessage = "Trạng thái phải là 'Đang hoạt động', 'Khóa tạm thời', hoặc 'Khóa vĩnh viễn'";
                return false;
            }

            errorMessage = null;
            return true;
        }

        // Thêm mới một vi phạm
        public static bool AddViolation(ViolationDTO violation)
        {
            if (ValidateInputViolation(violation, out string errorMessage))
            {
                string query = "INSERT INTO violations (violation_id, member_id, violation_date, violation_type, penalty, status) " +
                               "VALUES (@violation_id, @member_id, @violation_date, @violation_type, @penalty, @status)";
                var parameters = new Dictionary<string, object>
                {
                    { "@violation_id", violation.violation_id },
                    { "@member_id", violation.member_id },
                    { "@violation_date", violation.violation_date },
                    { "@violation_type", violation.violation_type },
                    { "@penalty", violation.penalty },
                    { "@status", violation.status }
                };
                return DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            else
            {
                MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Sửa thông tin vi phạm
        public static bool UpdateViolation(ViolationDTO violation)
        {
            if (ValidateInputViolation(violation, out string errorMessage))
            {
                string query = "UPDATE violations SET member_id = @member_id, violation_date = @violation_date, " +
                               "violation_type = @violation_type, penalty = @penalty, status = @status " +
                               "WHERE violation_id = @violation_id";
                var parameters = new Dictionary<string, object>
                {
                    { "@violation_id", violation.violation_id },
                    { "@member_id", violation.member_id },
                    { "@violation_date", violation.violation_date },
                    { "@violation_type", violation.violation_type },
                    { "@penalty", violation.penalty },
                    { "@status", violation.status }
                };
                return DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            else
            {
                MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Xóa thông tin vi phạm
        public static bool DeleteViolation(string violation_id)
        {
            string query = "DELETE FROM violations WHERE violation_id = @violation_id";
            var parameters = new Dictionary<string, object>
            {
                { "@violation_id", violation_id }
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // Tìm kiếm vi phạm theo từ khóa
        public static DataTable SearchViolation(string keyword)
        {
            string query = "SELECT * FROM violations WHERE violation_id LIKE @keyword OR member_id LIKE @keyword OR violation_type LIKE @keyword OR penalty LIKE @keyword OR status LIKE @keyword";
            var parameters = new Dictionary<string, object>
            {
                { "@keyword", "%" + keyword + "%" }
            };
            return DatabaseHelper.GetData(query, parameters);
        }
    }
}