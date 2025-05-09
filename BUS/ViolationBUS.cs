using qltv.DAO;
using qltv.DTO;
using QLTV.Resources;
using System;
using System.Data;
using System.Windows.Forms;

namespace qltv.BUS
{
    internal class ViolationBUS
    {
        public static DataTable GetAllViolation()
        {
            ViolationDAO.AutoUnblock(); // Kiểm tra và tự động mở khóa
            return ViolationDAO.GetAllViolation();
        }

        public static bool AddViolation(ViolationDTO violation)
        {
            if (!ViolationDAO.IsEmptyInput(violation))
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string condition = "violation_id = @violation_id";
            var parameters = new Dictionary<string, object>
            {
                { "@violation_id", violation.violation_id }
            };

            if (DatabaseHelper.CheckIfExists("violations", condition, parameters))
            {
                MessageBox.Show("Mã vi phạm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra xem member_id đã có vi phạm chưa
            string memberCondition = "member_id = @member_id";
            var memberParams = new Dictionary<string, object>
            {
                { "@member_id", violation.member_id }
            };

            if (DatabaseHelper.CheckIfExists("violations", memberCondition, memberParams))
            {
                // Gộp vi phạm cho member_id đã tồn tại
                string existingViolationId = ViolationDAO.GetViolationByIdForMember(violation.member_id)?.violation_id;
                if (!string.IsNullOrEmpty(existingViolationId))
                {
                    // Lấy thông tin vi phạm hiện tại
                    ViolationDTO existingViolation = ViolationDAO.GetViolationById(existingViolationId);

                    // Gộp violation_type và penalty
                    string newViolationType = $"{existingViolation.violation_type}; {violation.violation_type}";
                    string newPenalty = $"{existingViolation.penalty}; {violation.penalty}";

                    // Tăng warning_count thêm 1
                    int newWarningCount = existingViolation.warning_count + 1;

                    // Xác định trạng thái và ngày khóa/mở khóa dựa trên warning_count
                    string status;
                    string blockDate = existingViolation.block_date;
                    string unblockDate = existingViolation.unblock_date;

                    if (newWarningCount >= 3)
                    {
                        status = "Khóa vĩnh viễn";
                        blockDate = DateTime.Now.ToString("yyyy-MM-dd");
                        unblockDate = null; // Không có ngày mở khóa khi khóa vĩnh viễn
                    }
                    else if (newWarningCount == 2)
                    {
                        status = "Khóa tạm thời";
                        blockDate = DateTime.Now.ToString("yyyy-MM-dd");
                        unblockDate = DateTime.Now.AddDays(3).ToString("yyyy-MM-dd"); // Mặc định khóa 3 ngày
                    }
                    else
                    {
                        status = existingViolation.status;
                    }

                    // Yêu cầu đền bù nếu hư hỏng hoặc mất thiết bị
                    if (violation.violation_type.Contains("Hư hỏng") || violation.violation_type.Contains("Mất thiết bị"))
                    {
                        newPenalty += " (Yêu cầu đền bù)";
                    }

                    // Cập nhật bản ghi hiện tại
                    ViolationDTO updatedViolation = new ViolationDTO
                    {
                        violation_id = existingViolationId,
                        member_id = violation.member_id,
                        violation_date = violation.violation_date,
                        violation_type = newViolationType,
                        penalty = newPenalty,
                        status = status,
                        block_date = blockDate,
                        unblock_date = unblockDate,
                        warning_count = newWarningCount
                    };

                    return ViolationDAO.UpdateViolation(updatedViolation);
                }
            }
            else
            {
                // Thêm vi phạm mới nếu member_id chưa tồn tại
                int warningCount = 1; // Bắt đầu với 1 cảnh cáo cho vi phạm đầu tiên
                string status = "Đang hoạt động";
                string blockDate = null;
                string unblockDate = null;

                // Yêu cầu đền bù nếu hư hỏng hoặc mất thiết bị
                if (violation.violation_type.Contains("Hư hỏng") || violation.violation_type.Contains("Mất thiết bị"))
                {
                    violation.penalty += " (Yêu cầu đền bù)";
                }

                violation.warning_count = warningCount;
                violation.status = status;
                violation.block_date = blockDate;
                violation.unblock_date = unblockDate;

                return ViolationDAO.AddViolation(violation);
            }

            return false;
        }

        public static bool UpdateViolation(ViolationDTO violation)
        {
            if (!ViolationDAO.IsEmptyInput(violation))
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Lấy thông tin vi phạm hiện tại
            ViolationDTO existingViolation = ViolationDAO.GetViolationById(violation.violation_id);
            if (existingViolation != null)
            {
                // So sánh trạng thái hiện tại và trạng thái mới để điều chỉnh warning_count
                int newWarningCount = violation.warning_count;

                // Xử lý thay đổi trạng thái và điều chỉnh warning_count
                if (existingViolation.status == "Khóa vĩnh viễn" && violation.status == "Khóa tạm thời")
                {
                    newWarningCount = Math.Max(0, newWarningCount - 1); // Giảm warning_count đi 1
                    violation.block_date = string.IsNullOrEmpty(violation.block_date) ? DateTime.Now.ToString("yyyy-MM-dd") : violation.block_date;
                    violation.unblock_date = string.IsNullOrEmpty(violation.unblock_date) ? DateTime.Now.AddDays(3).ToString("yyyy-MM-dd") : violation.unblock_date;
                }
                else if (existingViolation.status == "Khóa vĩnh viễn" && violation.status == "Đang hoạt động")
                {
                    newWarningCount = Math.Max(0, newWarningCount - 2); // Giảm warning_count đi 2
                    violation.block_date = null;
                    violation.unblock_date = null;
                }
                else if (existingViolation.status == "Khóa tạm thời" && violation.status == "Đang hoạt động")
                {
                    newWarningCount = Math.Max(0, newWarningCount - 1); // Giảm warning_count đi 1
                    violation.block_date = null;
                    violation.unblock_date = null;
                }
                else if (existingViolation.status == "Đang hoạt động" && violation.status == "Khóa tạm thời")
                {
                    newWarningCount += 1; // Tăng warning_count thêm 1
                    violation.block_date = string.IsNullOrEmpty(violation.block_date) ? DateTime.Now.ToString("yyyy-MM-dd") : violation.block_date;
                    violation.unblock_date = string.IsNullOrEmpty(violation.unblock_date) ? DateTime.Now.AddDays(3).ToString("yyyy-MM-dd") : violation.unblock_date;
                }
                else if (existingViolation.status == "Đang hoạt động" && violation.status == "Khóa vĩnh viễn")
                {
                    newWarningCount += 2; // Tăng warning_count thêm 2
                    violation.block_date = string.IsNullOrEmpty(violation.block_date) ? DateTime.Now.ToString("yyyy-MM-dd") : violation.block_date;
                    violation.unblock_date = null;
                }
                else if (existingViolation.status == "Khóa tạm thời" && violation.status == "Khóa vĩnh viễn")
                {
                    newWarningCount += 1; // Tăng warning_count thêm 1
                    violation.block_date = string.IsNullOrEmpty(violation.block_date) ? DateTime.Now.ToString("yyyy-MM-dd") : violation.block_date;
                    violation.unblock_date = null;
                }
                else
                {
                    // Cập nhật trạng thái dựa trên warning_count nếu không có thay đổi trạng thái đặc biệt
                    if (newWarningCount >= 3)
                    {
                        violation.status = "Khóa vĩnh viễn";
                        violation.block_date = string.IsNullOrEmpty(violation.block_date) ? DateTime.Now.ToString("yyyy-MM-dd") : violation.block_date;
                        violation.unblock_date = null;
                    }
                    else if (newWarningCount == 2)
                    {
                        violation.status = "Khóa tạm thời";
                        violation.block_date = string.IsNullOrEmpty(violation.block_date) ? DateTime.Now.ToString("yyyy-MM-dd") : violation.block_date;
                        violation.unblock_date = string.IsNullOrEmpty(violation.unblock_date) ? DateTime.Now.AddDays(3).ToString("yyyy-MM-dd") : violation.unblock_date;
                    }
                    else
                    {
                        violation.status = "Đang hoạt động";
                        violation.block_date = null;
                        violation.unblock_date = null;
                    }
                }

                violation.warning_count = newWarningCount;
            }

            return ViolationDAO.UpdateViolation(violation);
        }

        public static bool DeleteViolation(string violation_id)
        {
            return ViolationDAO.DeleteViolation(violation_id);
        }

        public static DataTable SearchViolation(string keyword)
        {
            return ViolationDAO.SearchViolation(keyword);
        }
    }
}