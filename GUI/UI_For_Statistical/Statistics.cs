using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // Load dữ liệu thống kê khi form được tải
            LoadStatisticsData();
        }

        private void LoadStatisticsData()
        {
            // Đây là nơi bạn sẽ load dữ liệu thống kê từ database
            // Ví dụ:
            lblTotalMembers.Text = "20";
            lblTotalDevices.Text = "32";
            lblTotalBorrows.Text = "15";
            lblTotalViolations.Text = "5";
            
            // Đặt ngày mặc định
            dtpFromDate.Value = DateTime.Now.AddDays(-30); // 30 ngày trước
            dtpToDate.Value = DateTime.Now; // Hôm nay
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Xử lý lọc dữ liệu theo ngày
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;
            
            // Gọi hàm load dữ liệu với ngày đã chọn
            // LoadFilteredStatistics(fromDate, toDate);
        }
    }
}