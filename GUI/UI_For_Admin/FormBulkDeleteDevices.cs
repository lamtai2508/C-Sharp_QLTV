using qltv.BUS;
using qltv.DTO;
using QLTV.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qltv.GUI.UI_For_Admin
{
    public partial class FormBulkDeleteDevices : Form
    {
        public FormBulkDeleteDevices()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Xóa nhiều thiết bị theo điều kiện";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Label
            Label lblTitle = new Label();
            lblTitle.Text = "XÓA NHIỀU THIẾT BỊ THEO ĐIỀU KIỆN";
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Size = new Size(550, 40);
            this.Controls.Add(lblTitle);

            // Điều kiện
            Label lblCondition = new Label();
            lblCondition.Text = "Chọn điều kiện xóa:";
            lblCondition.Font = new Font("Segoe UI", 12);
            lblCondition.Location = new Point(20, 80);
            lblCondition.Size = new Size(200, 30);
            this.Controls.Add(lblCondition);

            // ComboBox điều kiện
            ComboBox cmbCondition = new ComboBox();
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Font = new Font("Segoe UI", 12);
            cmbCondition.Location = new Point(230, 80);
            cmbCondition.Size = new Size(320, 30);
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.Items.AddRange(new object[] {
                "Xóa theo loại thiết bị",
                "Xóa theo trạng thái",
                "Xóa theo mã thiết bị (bắt đầu bằng)"
            });
            cmbCondition.SelectedIndex = 0;
            this.Controls.Add(cmbCondition);

            // Label giá trị
            Label lblValue = new Label();
            lblValue.Text = "Nhập giá trị:";
            lblValue.Font = new Font("Segoe UI", 12);
            lblValue.Location = new Point(20, 130);
            lblValue.Size = new Size(200, 30);
            this.Controls.Add(lblValue);

            // TextBox giá trị
            TextBox txtValue = new TextBox();
            txtValue.Name = "txtValue";
            txtValue.Font = new Font("Segoe UI", 12);
            txtValue.Location = new Point(230, 130);
            txtValue.Size = new Size(320, 30);
            this.Controls.Add(txtValue);

            // Panel thiết bị sẽ bị xóa
            Panel panel = new Panel();
            panel.Location = new Point(20, 180);
            panel.Size = new Size(540, 120);
            panel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panel);

            // DataGridView hiển thị thiết bị sẽ bị xóa
            DataGridView dgvDevices = new DataGridView();
            dgvDevices.Name = "dgvDevices";
            dgvDevices.Location = new Point(0, 0);
            dgvDevices.Size = new Size(538, 118);
            dgvDevices.ReadOnly = true;
            dgvDevices.AllowUserToAddRows = false;
            dgvDevices.AllowUserToDeleteRows = false;
            dgvDevices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDevices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            panel.Controls.Add(dgvDevices);

            // Button kiểm tra
            Button btnCheck = new Button();
            btnCheck.Name = "btnCheck";
            btnCheck.Text = "Kiểm tra";
            btnCheck.Font = new Font("Segoe UI", 12);
            btnCheck.Location = new Point(170, 310);
            btnCheck.Size = new Size(120, 40);
            btnCheck.BackColor = Color.LightGray;
            btnCheck.Click += (sender, e) =>
            {
                string condition = cmbCondition.SelectedItem.ToString();
                string value = txtValue.Text.Trim();

                if (string.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Vui lòng nhập giá trị điều kiện!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable devices = GetDevicesByCondition(condition, value);
                dgvDevices.DataSource = devices;

                if (devices.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thiết bị nào phù hợp với điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            this.Controls.Add(btnCheck);

            // Button xóa
            Button btnDelete = new Button();
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Xóa";
            btnDelete.Font = new Font("Segoe UI", 12);
            btnDelete.Location = new Point(310, 310);
            btnDelete.Size = new Size(120, 40);
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Click += (sender, e) =>
            {
                string condition = cmbCondition.SelectedItem.ToString();
                string value = txtValue.Text.Trim();

                if (string.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Vui lòng nhập giá trị điều kiện!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable devices = GetDevicesByCondition(condition, value);
                if (devices.Rows.Count == 0)
                {
                    MessageBox.Show("Không có thiết bị nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa {devices.Rows.Count} thiết bị theo điều kiện này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int successCount = 0;
                    foreach (DataRow row in devices.Rows)
                    {
                        string deviceId = row["device_id"].ToString();
                        if (DeviceBUS.DeleteDevice(deviceId))
                        {
                            successCount++;
                        }
                    }

                    MessageBox.Show(
                        $"Đã xóa thành công {successCount}/{devices.Rows.Count} thiết bị!",
                        "Kết quả xóa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            };
            this.Controls.Add(btnDelete);

            // Button hủy
            Button btnCancel = new Button();
            btnCancel.Name = "btnCancel";
            btnCancel.Text = "Hủy";
            btnCancel.Font = new Font("Segoe UI", 12);
            btnCancel.Location = new Point(450, 310);
            btnCancel.Size = new Size(120, 40);
            btnCancel.BackColor = Color.LightGray;
            btnCancel.Click += (sender, e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
            this.Controls.Add(btnCancel);
        }

        private DataTable GetDevicesByCondition(string condition, string value)
        {
            DataTable allDevices = DeviceBUS.GetAllDevices();
            DataTable filteredDevices = allDevices.Clone();

            foreach (DataRow row in allDevices.Rows)
            {
                bool match = false;

                switch (condition)
                {
                    case "Xóa theo loại thiết bị":
                        match = row["device_type"].ToString().Equals(value, StringComparison.OrdinalIgnoreCase);
                        break;

                    case "Xóa theo trạng thái":
                        match = row["status"].ToString().Equals(value, StringComparison.OrdinalIgnoreCase);
                        break;

                    case "Xóa theo mã thiết bị (bắt đầu bằng)":
                        match = row["device_id"].ToString().StartsWith(value, StringComparison.OrdinalIgnoreCase);
                        break;
                }

                if (match)
                {
                    filteredDevices.ImportRow(row);
                }
            }

            return filteredDevices;
        }
    }
}