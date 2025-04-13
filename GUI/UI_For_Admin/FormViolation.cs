using qltv.BUS;
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
            dataGridView1.DataSource = ViolationBUS.GetAllViolation();
            // Đổi tên header 
            dataGridView1.Columns["violation_id"].HeaderText = "Mã vi phạm";
            dataGridView1.Columns["member_id"].HeaderText = "Mã thành viên";
            //dataGridView1.Columns["full_name"].HeaderText = "Tên thành viên";
            dataGridView1.Columns["violation_type"].HeaderText = "Mô tả";
            dataGridView1.Columns["penalty"].HeaderText = "Xử phạt";
            dataGridView1.Columns["violation_date"].HeaderText = "Ngày vi phạm";
            dataGridView1.Columns["block_date"].HeaderText = "Ngày khóa";
            dataGridView1.Columns["unblock_date"].HeaderText = "Ngày mở";
            dataGridView1.Columns["status"].HeaderText = "Trạng thái";
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