using System;
using qltv.BUS;
using qltv.DAO;
using qltv.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qltv_Winform.DAO;

namespace qltv_Winform.GUI.UI_For_Admin
{
    public partial class FormLearnSpace : Form
    {


        public FormLearnSpace()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        // Load data của bảng
        public void LoadData()
        {
            presentmember_table.DataSource = PresentMemberDAO.GetALLPresentMember();
            // Đổi tên header
            presentmember_table.Columns["member_id"].HeaderText = "Mã thành viên";
            presentmember_table.Columns["full_name"].HeaderText = "Tên thành viên";
            presentmember_table.Columns["appeartime"].HeaderText = "Thời gian đến";
            presentmember_table.Columns["leavetime"].HeaderText = "Thời gian đi";
        }

        public void clearInput()
        {
            member_idtb.Text = "";
            member_idtb.Enabled = true;
        }

        private void FormLearnSpace_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btCheckin_Click(object sender, EventArgs e)
        {
            var member_id = member_idtb.Text;
            var member = MemberDAO.GetMemberById(member_id);

            if (member != null)
            {
                // Get current time
                DateTime currentTime = DateTime.Now;
                // Create a new PresentMemberDTO object
                PresentMemberDTO presentMember = new PresentMemberDTO
                {
                    member_id = member_id,
                    full_name = member.full_name,
                    appear_time = currentTime,
                    // Set leave_time to null for check-in
                };
                // Add the present member to the database
                if (PresentMemberBUS.AddPresentMember(presentMember))
                {
                    MessageBox.Show("Check-in thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Check-in thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mã thành viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            var member_id = member_idtb.Text;

            // Use MemberDAO to check if the member_id exists
            var member = MemberDAO.GetMemberById(member_id);

            if (member != null)
            {
                // Show a dialog if the member_id is valid
                MessageBox.Show("Hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Show a dialog if the member_id is invalid
                MessageBox.Show("Mã thành viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCheckout_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (presentmember_table.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = presentmember_table.SelectedRows[0];

                // Safely retrieve the member_id value
                if (selectedRow.Cells["member_id"]?.Value is string memberId && !string.IsNullOrEmpty(memberId))
                {
                    // Fill the member_idtb with the selected member_id
                    member_idtb.Text = memberId;

                    // Get current time
                    DateTime currentTime = DateTime.Now;

                    // Update the leave time for the selected member
                    if (PresentMemberBUS.UpdateLeaveTime(memberId, currentTime))
                    {
                        MessageBox.Show("Check-out thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        clearInput();
                    }
                    else
                    {
                        MessageBox.Show("Check-out thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mã thành viên không hợp lệ hoặc không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thành viên để check-out!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
