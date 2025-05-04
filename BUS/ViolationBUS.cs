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

                    // Tính lại warning_count
                    int newWarningCount = existingViolation.warning_count;
                    if (violation.violation_type.Contains("Trả muộn") || violation.violation_type.Contains("Hư hỏng") || violation.violation_type.Contains("Mất thiết bị"))
                    {
                        newWarningCount += 1; // Tăng warning_count thêm 1 cho vi phạm mới

                        if (newWarningCount >= 1)
                        {
                            string memberStatus = "Đang bị cảnh cáo";
                            MemberDTO memberDTO = new MemberDTO
                            {
                                member_id = violation.member_id,
                                status = memberStatus
                            };

                            MemberDAO.UpdateStatusMember(memberDTO);
                        }
                    }

                    // Xác định trạng thái và ngày khóa/mở khóa
                    string blockDate = newWarningCount >= 2 ? DateTime.Now.ToString("yyyy-MM-dd") : existingViolation.block_date;
                    string unblockDate = newWarningCount == 2 ? DateTime.Now.AddDays(3).ToString("yyyy-MM-dd") : existingViolation.unblock_date;
                    string status;
                    if (newWarningCount >= 3)
                    {
                        status = "Khóa vĩnh viễn";
                        unblockDate = null; // Không có ngày mở khóa khi khóa vĩnh viễn

                        string memberStatus = "Khóa vĩnh viễn";
                        MemberDTO memberDTO = new MemberDTO
                        {
                            member_id = violation.member_id,
                            status = memberStatus
                        };
                        MemberDAO.UpdateStatusMember(memberDTO);
                    }
                    else if (newWarningCount == 2 || violation.violation_type.Contains("Hư hỏng") || violation.violation_type.Contains("Mất thiết bị"))
                    {
                        status = "Khóa tạm thời";
                        string memberStatus = "Đang bị tạm khóa";
                        MemberDTO memberDTO = new MemberDTO
                        {
                            member_id = violation.member_id,
                            status = memberStatus
                        };
                        MemberDAO.UpdateStatusMember(memberDTO);
                        
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
                int warningCount = 0;
                if (violation.violation_type.Contains("Trả muộn") || violation.violation_type.Contains("Hư hỏng") || violation.violation_type.Contains("Mất thiết bị"))
                {
                    warningCount = 1;
                    if (violation.violation_type.Contains("Hư hỏng") || violation.violation_type.Contains("Mất thiết bị"))
                    {
                        violation.penalty += " (Yêu cầu đền bù)";
                    }
                }

                string status = warningCount >= 2 || violation.violation_type.Contains("Hư hỏng") || violation.violation_type.Contains("Mất thiết bị") ? "Khóa tạm thời" : "Đang hoạt động";
                string blockDate = status == "Khóa tạm thời" ? DateTime.Now.ToString("yyyy-MM-dd") : null;
                string unblockDate = status == "Khóa tạm thời" ? DateTime.Now.AddDays(3).ToString("yyyy-MM-dd") : null;
               
                if (warningCount >= 3)
                {
                    status = "Khóa vĩnh viễn";
                    blockDate = DateTime.Now.ToString("yyyy-MM-dd");
                    unblockDate = null;
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

            // Cập nhật block_date và unblock_date khi chuyển trạng thái
            ViolationDTO existingViolation = ViolationDAO.GetViolationById(violation.violation_id);
            if (existingViolation != null && existingViolation.status == "Cảnh cáo" && violation.status == "Khóa tạm thời")
            {
                violation.block_date = DateTime.Now.ToString("yyyy-MM-dd");
                violation.unblock_date = string.IsNullOrEmpty(violation.unblock_date) ? DateTime.Now.AddDays(3).ToString("yyyy-MM-dd") : violation.unblock_date;
            }
            else if (violation.status == "Khóa vĩnh viễn")
            {
                violation.block_date = string.IsNullOrEmpty(violation.block_date) ? DateTime.Now.ToString("yyyy-MM-dd") : violation.block_date;
                violation.unblock_date = null;
            }
            else if (violation.status == "Cảnh cáo")
            {
                violation.block_date = null;
                violation.unblock_date = null;
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