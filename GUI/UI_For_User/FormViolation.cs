using System;
using System.Windows.Forms;

namespace qltv.GUI.UI_For_User
{
    public partial class FormViolation : Form
    {
        public FormViolation()
        {
            InitializeComponent();
            SetupForm();
            SetupDataGridViewColumns();
        }

        private void SetupForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.Text = "Danh sách vi phạm";
        }

        private void SetupDataGridViewColumns()
        {
            // Thêm các cột vào DataGridView
            dataGridView1.Columns.Add("MemberID", "Mã thành viên");
            dataGridView1.Columns.Add("MemberName", "Tên thành viên");
            dataGridView1.Columns.Add("DeviceID", "Mã thiết bị");
            dataGridView1.Columns.Add("DeviceName", "Tên thiết bị");
            dataGridView1.Columns.Add("ViolationContent", "Nội dung vi phạm");
            dataGridView1.Columns.Add("ViolationDate", "Ngày vi phạm");
            dataGridView1.Columns.Add("Status", "Trạng thái");

            // Cấu hình DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Xử lý tìm kiếm (chỉ UI, không có logic thực tế)
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Đang tìm kiếm: " + txtSearch.Text, "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormViolation_Load(object sender, EventArgs e)
        {

        }
    }
}