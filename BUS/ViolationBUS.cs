using qltv.DAO;
using qltv.DTO;
using QLTV.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qltv.BUS
{
    internal class ViolationBUS
    {
        public static DataTable GetAllViolation()
        {
            return ViolationDAO.GetALlViolation();
        }

        // Hàm thêm vi phạm nếu vi phạm không tồn tại
        public static bool AddViolation(ViolationDTO violation)
        {
            // Kiểm tra xem các dữ liệu có để trống không
            if (ViolationDAO.IsEmptyInput(violation))
            {
                // Kiểm tra xem vi phạm có tồn tại hay chưa
                string condition = "violation_id = @violation_id";
                var parameters = new Dictionary<string, object>
                {
                    { "@violation_id", violation.violation_id }
                };
                // Nếu tồn tại, thông báo lỗi
                if (DatabaseHelper.CheckIfExists("violations", condition, parameters))
                {
                    MessageBox.Show("Vi phạm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return ViolationDAO.AddViolation(violation);
            }
            MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        // Hàm sửa thông tin vi phạm
        public static bool UpdateViolation(ViolationDTO violation)
        {
            if (ViolationDAO.IsEmptyInput(violation))
            {
                return ViolationDAO.UpdateViolation(violation);
            }
            else
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // Hàm xóa thông tin vi phạm
        public static bool DeleteViolation(string violation_id)
        {
            return ViolationDAO.DeleteViolation(violation_id);
        }

        // Hàm tìm kiếm vi phạm theo từ khóa
        public static DataTable SearchViolation(string keyword)
        {
            return ViolationDAO.SearchViolation(keyword);
        }
    }
}