using qltv.BUS;
using qltv.DTO;
using QLTV.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

            // Thêm các nút mới và sự kiện
            this.btnImportExcel.Click += new EventHandler(this.btnImportExcel_Click);
            this.btnBulkDelete.Click += new EventHandler(this.btnBulkDelete_Click);
        }

        private void FormDevice_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu thiết bị khi form được tải
            LoadDevices();

            // Thiết lập dropdown trạng thái
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Có sẵn");
            cmbStatus.Items.Add("Được đặt chỗ");
            cmbStatus.Items.Add("Đang được mượn");
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
            if (string.IsNullOrEmpty(txtDeviceId.Text) || string.IsNullOrEmpty(txtDeviceName.Text) || string.IsNullOrEmpty(txtDeviceType.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin thiết bị!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                MessageBox.Show("Thêm thiết bị thất bại! Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (dgvDevices.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thiết bị nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

                string status = row.Cells["status"].Value.ToString();
                for (int i = 0; i < cmbStatus.Items.Count; i++)
                {
                    if (cmbStatus.Items[i].ToString() == status)
                    {
                        cmbStatus.SelectedIndex = i;
                        break;
                    }
                }

                // Vô hiệu hóa chỉnh sửa ID thiết bị khi chọn thiết bị đã tồn tại
                txtDeviceId.Enabled = false;
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.csv";
                    openFileDialog.Title = "Chọn file Excel chứa danh sách thiết bị";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        // Hiển thị form nhập Excel
                        using (ImportExcelForm importForm = new ImportExcelForm(filePath))
                        {
                            if (importForm.ShowDialog() == DialogResult.OK)
                            {
                                // Nếu nhập thành công, làm mới danh sách thiết bị
                                LoadDevices();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nhập thiết bị từ Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức xóa nhiều thiết bị theo điều kiện
        private void btnBulkDelete_Click(object sender, EventArgs e)
        {
            using (FormBulkDeleteDevices bulkDeleteForm = new FormBulkDeleteDevices())
            {
                if (bulkDeleteForm.ShowDialog() == DialogResult.OK)
                {
                    // Nếu xóa thành công, làm mới danh sách
                    LoadDevices();
                }
            }
        }
    }
}