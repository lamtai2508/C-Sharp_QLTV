using qltv.BUS;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;

namespace qltv.GUI.UI_For_Admin
{
    public partial class FormStatistical : Form
    {
        private readonly string _accountId;
        private readonly string _password;

        public FormStatistical(string accountId, string password)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            _accountId = accountId;
            _password = password;
        }

        private void FormStatistical_Load(object sender, EventArgs e)
        {
            try
            {
                
                LoadMemberStatistics();
                LoadDeviceBorrowingStatistics();
                LoadCurrentBorrowedDevices();
                LoadViolationStatistics();
                LoadActiveMemberStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMemberStatistics()
        {
            try
            {
                DataTable memberStats = StatisticsBUS.GetMemberVisitStatistics(dateTimePickerStart.Value, dateTimePickerEnd.Value);
                table_MemberStats.DataSource = memberStats;
                table_MemberStats.Columns["visit_date"].HeaderText = "Ngày";
                table_MemberStats.Columns["status"].HeaderText = "Trạng thái";
                table_MemberStats.Columns["member_count"].HeaderText = "Số lượng thành viên";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDeviceBorrowingStatistics()
        {
            try
            {
                DataTable deviceStats = StatisticsBUS.GetDeviceBorrowingStatistics(dateTimePickerStart.Value, dateTimePickerEnd.Value);
                table_DeviceBorrowing.DataSource = deviceStats;
                table_DeviceBorrowing.Columns["borrowed_date"].HeaderText = "Ngày mượn";
                table_DeviceBorrowing.Columns["device_name"].HeaderText = "Tên thiết bị";
                table_DeviceBorrowing.Columns["borrow_count"].HeaderText = "Số lượt mượn";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCurrentBorrowedDevices()
        {
            try
            {
                DataTable currentDevices = StatisticsBUS.GetCurrentBorrowedDevices(dateTimePickerStart.Value, dateTimePickerEnd.Value);
                table_CurrentBorrowed.DataSource = currentDevices;
                table_CurrentBorrowed.Columns["borrowed_date"].HeaderText = "Ngày mượn";
                table_CurrentBorrowed.Columns["device_name"].HeaderText = "Tên thiết bị";
                table_CurrentBorrowed.Columns["member_id"].HeaderText = "Mã thành viên";
                table_CurrentBorrowed.Columns["status"].HeaderText = "Trạng thái";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadViolationStatistics()
        {
            try
            {
                DataTable violationStats = StatisticsBUS.GetViolationStatistics();
                table_Violations.DataSource = violationStats;
                table_Violations.Columns["violation_id"].HeaderText = "Mã vi phạm";
                table_Violations.Columns["member_id"].HeaderText = "Mã thành viên";
                table_Violations.Columns["violation_date"].HeaderText = "Ngày vi phạm";
                table_Violations.Columns["status"].HeaderText = "Trạng thái";
                table_Violations.Columns["compensation_amount"].HeaderText = "Tiền bồi thường";

                double totalCompensation = violationStats.AsEnumerable()
                    .Where(row => row.Field<string>("status") == "Handled")
                    .Sum(row => row.Field<double>("compensation_amount"));
                lbl_TotalCompensation.Text = $"Tổng tiền bồi thường: {totalCompensation.ToString("C", CultureInfo.GetCultureInfo("vi-VN"))}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadActiveMemberStatistics()
        {
            try
            {
                DataTable activeMembers = StatisticsBUS.GetActiveMemberStatistics();
                table_ActiveMembers.DataSource = activeMembers;
                table_ActiveMembers.Columns["member_id"].HeaderText = "Mã thành viên";
                table_ActiveMembers.Columns["full_name"].HeaderText = "Họ tên";
                table_ActiveMembers.Columns["appear_time"].HeaderText = "Thời gian xuất hiện";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            LoadMemberStatistics();
            LoadDeviceBorrowingStatistics();
            LoadCurrentBorrowedDevices();
        }
    }
}