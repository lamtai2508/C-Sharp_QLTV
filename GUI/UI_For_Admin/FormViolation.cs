using qltv.BUS;
using qltv.DAO;
using qltv.DTO;
using System;
using System.Text.RegularExpressions;
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
            SetupComboBox();
            ClearInput();
            LoadData();
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
            if (dataGridView1.Columns["violation_id"] != null)
                dataGridView1.Columns["violation_id"].HeaderText = "Mã vi phạm";
            if (dataGridView1.Columns["member_id"] != null)
                dataGridView1.Columns["member_id"].HeaderText = "Mã thành viên";
            if (dataGridView1.Columns["violation_date"] != null)
                dataGridView1.Columns["violation_date"].HeaderText = "Ngày vi phạm";
            if (dataGridView1.Columns["violation_type"] != null)
                dataGridView1.Columns["violation_type"].HeaderText = "Mô tả";
            if (dataGridView1.Columns["penalty"] != null)
                dataGridView1.Columns["penalty"].HeaderText = "Xử phạt";
            if (dataGridView1.Columns["status"] != null)
                dataGridView1.Columns["status"].HeaderText = "Trạng thái";
            if (dataGridView1.Columns["block_date"] != null)
                dataGridView1.Columns["block_date"].HeaderText = "Ngày khóa";
            if (dataGridView1.Columns["unblock_date"] != null)
                dataGridView1.Columns["unblock_date"].HeaderText = "Ngày mở khóa";
            if (dataGridView1.Columns["warning_count"] != null)
                dataGridView1.Columns["warning_count"].HeaderText = "Số lần cảnh cáo";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void SetupComboBox()
        {
            cbStatus.Items.Clear(); // Xóa các mục hiện có để tránh lặp
            cbStatus.Items.AddRange(new object[] { "Đang hoạt động", "Khóa tạm thời", "Khóa vĩnh viễn" });
            cbStatus.SelectedIndex = 0;
        }

        private string GenerateNextViolationId()
        {
            string maxId = ViolationDAO.GetMaxViolationId();
            if (string.IsNullOrEmpty(maxId))
            {
                return "V001";
            }

            string numericPart = Regex.Match(maxId, @"\d+").Value;
            int number = int.Parse(numericPart) + 1;
            return $"V{number:D3}";
        }

        private void LoadData()
        {
            dataGridView1.DataSource = ViolationBUS.GetAllViolation();
        }

        private void ClearInput()
        {
            tbViolationId.Text = GenerateNextViolationId();
            tbMemberId.Text = "";
            tbViolationDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            tbViolationType.Text = "";
            tbPenalty.Text = "";
            cbStatus.SelectedIndex = 0;
            tbBlockDate.Text = "";
            tbUnblockDate.Text = "";
            tbViolationId.Enabled = false;
            tbMemberId.Enabled = true;
            tbViolationDate.Enabled = false;
            tbBlockDate.Enabled = false;
            tbUnblockDate.Enabled = cbStatus.SelectedItem?.ToString() == "Khóa tạm thời";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(tbViolationDate.Text, out DateTime violationDateValue))
            {
                MessageBox.Show("Ngày vi phạm không hợp lệ! Vui lòng nhập đúng định dạng yyyy-MM-dd.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string blockDate = string.IsNullOrEmpty(tbBlockDate.Text) ? null : DateTime.Parse(tbBlockDate.Text).ToString("yyyy-MM-dd");
            string unblockDate = string.IsNullOrEmpty(tbUnblockDate.Text) ? null : DateTime.Parse(tbUnblockDate.Text).ToString("yyyy-MM-dd");

            ViolationDTO dto = new ViolationDTO
            {
                violation_id = tbViolationId.Text,
                member_id = tbMemberId.Text,
                violation_date = violationDateValue.ToString("yyyy-MM-dd"),
                violation_type = tbViolationType.Text,
                penalty = tbPenalty.Text,
                status = cbStatus.SelectedItem?.ToString() ?? "Đang hoạt động",
                block_date = blockDate,
                unblock_date = unblockDate,
                warning_count = 0
            };

            if (ViolationBUS.AddViolation(dto))
            {
                MessageBox.Show("Thêm vi phạm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInput();
            }
            else
            {
                MessageBox.Show("Thêm vi phạm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(tbViolationDate.Text, out DateTime violationDateValue))
            {
                MessageBox.Show("Ngày vi phạm không hợp lệ! Vui lòng nhập đúng định dạng yyyy-MM-dd.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string blockDate = string.IsNullOrEmpty(tbBlockDate.Text) ? null : DateTime.Parse(tbBlockDate.Text).ToString("yyyy-MM-dd");
            string unblockDate = string.IsNullOrEmpty(tbUnblockDate.Text) ? null : DateTime.Parse(tbUnblockDate.Text).ToString("yyyy-MM-dd");

            ViolationDTO dto = new ViolationDTO
            {
                violation_id = tbViolationId.Text,
                member_id = tbMemberId.Text,
                violation_date = violationDateValue.ToString("yyyy-MM-dd"),
                violation_type = tbViolationType.Text,
                penalty = tbPenalty.Text,
                status = cbStatus.SelectedItem?.ToString() ?? "Đang hoạt động",
                block_date = blockDate,
                unblock_date = unblockDate,
                warning_count = ViolationDAO.GetWarningCount(tbMemberId.Text) // Giữ nguyên warning_count hiện tại
            };

            if (ViolationBUS.UpdateViolation(dto))
            {
                MessageBox.Show("Sửa thông tin vi phạm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInput();
            }
            else
            {
                MessageBox.Show("Sửa thông tin vi phạm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string violation_id = tbViolationId.Text;

            if (string.IsNullOrEmpty(violation_id))
            {
                MessageBox.Show("Vui lòng chọn vi phạm muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa vi phạm này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (ViolationBUS.DeleteViolation(violation_id))
                {
                    MessageBox.Show("Xóa vi phạm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Xóa vi phạm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                dataGridView1.DataSource = ViolationBUS.SearchViolation(keyword);
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy vi phạm nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                LoadData();
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearInput();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbViolationId.Text = row.Cells["violation_id"]?.Value?.ToString() ?? "";
                tbMemberId.Text = row.Cells["member_id"]?.Value?.ToString() ?? "";
                tbViolationDate.Text = row.Cells["violation_date"]?.Value?.ToString() ?? "";
                tbViolationType.Text = row.Cells["violation_type"]?.Value?.ToString() ?? "";
                tbPenalty.Text = row.Cells["penalty"]?.Value?.ToString() ?? "";
                cbStatus.SelectedItem = row.Cells["status"]?.Value?.ToString() ?? "Đang hoạt động";
                tbBlockDate.Text = row.Cells["block_date"]?.Value?.ToString() ?? "";
                tbUnblockDate.Text = row.Cells["unblock_date"]?.Value?.ToString() ?? "";
                tbViolationId.Enabled = false;
                tbMemberId.Enabled = false;
                tbViolationDate.Enabled = false;
                tbBlockDate.Enabled = false;
                tbUnblockDate.Enabled = cbStatus.SelectedItem?.ToString() == "Khóa tạm thời";
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbUnblockDate.Enabled = cbStatus.SelectedItem?.ToString() == "Khóa tạm thời";
            if (cbStatus.SelectedItem?.ToString() == "Khóa tạm thời" && string.IsNullOrEmpty(tbUnblockDate.Text))
            {
                tbUnblockDate.Text = DateTime.Now.AddDays(3).ToString("yyyy-MM-dd");
            }
            else if (cbStatus.SelectedItem?.ToString() != "Khóa tạm thời")
            {
                tbUnblockDate.Text = "";
            }
        }

        private void FormViolation_Load(object sender, EventArgs e)
        {
            ClearInput();
            LoadData();
        }
    }
}