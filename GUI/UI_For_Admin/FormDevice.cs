using qltv.BUS;
using qltv.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace qltv.GUI.UI_For_Admin
{
    public partial class FormDevice : Form
    {
        public FormDevice()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            // Kết nối các sự kiện thủ công
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
            this.dgvDevices.CellClick += new DataGridViewCellEventHandler(this.dgvDevices_CellClick);
            this.Load += new EventHandler(this.FormDevice_Load);
        }

        private void FormDevice_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu thiết bị khi form được tải
            LoadDevices();

            // Thiết lập dropdown trạng thái
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Reserved");
            cmbStatus.Items.Add("Loaned");
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadDevices()
        {
            dgvDevices.DataSource = DeviceBUS.GetAllDevices();
            // Đổi tên header
            dgvDevices.Columns["device_id"].HeaderText = "Mã thiết bị";
            dgvDevices.Columns["device_name"].HeaderText = "Tên thiết bị";
            dgvDevices.Columns["device_type"].HeaderText = "Phân loại";
            dgvDevices.Columns["status"].HeaderText = "Trạng thái";
        }

        private void ClearInputs()
        {
            txtDeviceId.Text = "";
            txtDeviceName.Text = "";
            txtDeviceType.Text = "";
            cmbStatus.SelectedIndex = 0;
            txtDeviceId.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DeviceDTO device = new DeviceDTO
            {
                device_id = txtDeviceId.Text,
                device_name = txtDeviceName.Text,
                device_type = txtDeviceType.Text,
                status = cmbStatus.SelectedItem.ToString()
            };

            if (DeviceBUS.AddDevice(device))
            {
                MessageBox.Show("Thêm thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDevices();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Thêm thiết bị thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeviceId.Text))
            {
                MessageBox.Show("Vui lòng chọn thiết bị để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeviceDTO device = new DeviceDTO
            {
                device_id = txtDeviceId.Text,
                device_name = txtDeviceName.Text,
                device_type = txtDeviceType.Text,
                status = cmbStatus.SelectedItem.ToString()
            };

            if (DeviceBUS.UpdateDevice(device))
            {
                MessageBox.Show("Cập nhật thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDevices();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Cập nhật thiết bị thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeviceId.Text))
            {
                MessageBox.Show("Vui lòng chọn thiết bị để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DeviceBUS.DeleteDevice(txtDeviceId.Text))
                {
                    MessageBox.Show("Xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDevices();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa thiết bị thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDevices();
            ClearInputs();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                dgvDevices.DataSource = DeviceBUS.SearchDevices(txtSearch.Text);
            }
            else
            {
                LoadDevices();
            }
        }

        private void dgvDevices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDevices.Rows[e.RowIndex];
                txtDeviceId.Text = row.Cells["device_id"].Value.ToString();
                txtDeviceName.Text = row.Cells["device_name"].Value.ToString();
                txtDeviceType.Text = row.Cells["device_type"].Value.ToString();
                cmbStatus.SelectedItem = row.Cells["status"].Value.ToString();

                // Vô hiệu hóa chỉnh sửa ID thiết bị khi chọn thiết bị đã tồn tại
                txtDeviceId.Enabled = false;
            }
        }
    }
}