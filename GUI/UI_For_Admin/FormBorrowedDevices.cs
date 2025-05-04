using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class FormBorrowedDevices : Form
    {
        private string selectedReservationId;

        public FormBorrowedDevices()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            SetupUI();
        }

        private void SetupUI()
        {
            // Thêm các nút xác nhận và từ chối
            btnAccept = new Button();
            btnAccept.Text = "Xác nhận";
            btnAccept.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccept.BackColor = Color.FromArgb(128, 255, 128);
            btnAccept.Location = new Point(50, 80);
            btnAccept.Size = new Size(150, 40);
            btnAccept.Click += btnAccept_Click;
            this.Controls.Add(btnAccept);

            btnReject = new Button();
            btnReject.Text = "Từ chối";
            btnReject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReject.BackColor = Color.FromArgb(255, 128, 128);
            btnReject.Location = new Point(220, 80);
            btnReject.Size = new Size(150, 40);
            btnReject.Click += btnReject_Click;
            this.Controls.Add(btnReject);

            btnRefresh = new Button();
            btnRefresh.Text = "Làm mới";
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.BackColor = Color.FromArgb(192, 192, 255);
            btnRefresh.Location = new Point(390, 80);
            btnRefresh.Size = new Size(150, 40);
            btnRefresh.Click += btnRefresh_Click;
            this.Controls.Add(btnRefresh);

            // Thêm label hiển thị thông tin chi tiết
            lblStatus = new Label();
            lblStatus.Text = "Chọn một đơn đặt chỗ để xử lý";
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(560, 80);
            lblStatus.Size = new Size(400, 40);
            lblStatus.ForeColor = Color.Navy;
            this.Controls.Add(lblStatus);

            // Cấu hình DataGridView
            table_BDL.CellClick += table_BDL_CellClick;
            table_BDL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_BDL.MultiSelect = false;
        }

        public void load_data()
        {
            table_BDL.DataSource = ReservationBUS.GetAllReservation();

            table_BDL.Columns["reservation_id"].HeaderText = "Mã đặt chỗ";
            table_BDL.Columns["member_id"].HeaderText = "Mã thành viên";
            table_BDL.Columns["device_id"].HeaderText = "Mã thiết bị";
            table_BDL.Columns["reservation_date"].HeaderText = "Ngày đặt chỗ";
            table_BDL.Columns["borrowed_date"].HeaderText = "Ngày mượn";
            table_BDL.Columns["returned_date"].HeaderText = "Ngày trả";
            table_BDL.Columns["status"].HeaderText = "Trạng thái";

            // Reset selection
            selectedReservationId = null;
            UpdateStatusLabel();
        }

        private void UpdateStatusLabel()
        {
            if (string.IsNullOrEmpty(selectedReservationId))
            {
                lblStatus.Text = "Chọn một đơn đặt chỗ để xử lý";
                btnAccept.Enabled = false;
                btnReject.Enabled = false;
            }
            else
            {
                DataGridViewRow selectedRow = FindRowByReservationId(selectedReservationId);
                if (selectedRow != null)
                {
                    string status = selectedRow.Cells["status"].Value.ToString();
                    string memberId = selectedRow.Cells["member_id"].Value.ToString();
                    string deviceId = selectedRow.Cells["device_id"].Value.ToString();

                    if (status == "Chờ duyệt")
                    {
                        lblStatus.Text = $"Đơn {selectedReservationId} - Thành viên {memberId} - Thiết bị {deviceId}";
                        btnAccept.Enabled = true;
                        btnReject.Enabled = true;
                    }
                    else
                    {
                        lblStatus.Text = $"Đơn {selectedReservationId} đã được xử lý ({status})";
                        btnAccept.Enabled = false;
                        btnReject.Enabled = false;
                    }
                }
            }
        }

        private DataGridViewRow FindRowByReservationId(string reservationId)
        {
            foreach (DataGridViewRow row in table_BDL.Rows)
            {
                if (row.Cells["reservation_id"].Value != null &&
                    row.Cells["reservation_id"].Value.ToString() == reservationId)
                {
                    return row;
                }
            }
            return null;
        }

        private void table_BDL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedReservationId = table_BDL.Rows[e.RowIndex].Cells["reservation_id"].Value.ToString();
                UpdateStatusLabel();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedReservationId))
            {
                MessageBox.Show("Vui lòng chọn một đơn đặt chỗ để xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xác nhận đơn đặt chỗ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ReservationBUS.UpdateReservationStatus(selectedReservationId, "Chấp nhận"))
                {
                    MessageBox.Show("Xác nhận đơn đặt chỗ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật trạng thái thiết bị thành "Được đặt chỗ"
                    DataGridViewRow selectedRow = FindRowByReservationId(selectedReservationId);
                    if (selectedRow != null)
                    {
                        string deviceId = selectedRow.Cells["device_id"].Value.ToString();
                        DeviceDTO device = DeviceBUS.GetDeviceById(deviceId);
                        if (device != null)
                        {
                            device.status = "Đang được mượn";
                            DeviceBUS.UpdateDevice(device);
                        }
                    }

                    load_data();
                }
                else
                {
                    MessageBox.Show("Xác nhận đơn đặt chỗ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedReservationId))
            {
                MessageBox.Show("Vui lòng chọn một đơn đặt chỗ để từ chối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn từ chối đơn đặt chỗ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ReservationBUS.UpdateReservationStatus(selectedReservationId, "Từ chối"))
                {
                    MessageBox.Show("Từ chối đơn đặt chỗ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRow selectedRow = FindRowByReservationId(selectedReservationId);
                    if (selectedRow != null)
                    {
                        string deviceId = selectedRow.Cells["device_id"].Value.ToString();
                        DeviceDTO device = DeviceBUS.GetDeviceById(deviceId);
                        if (device != null)
                        {
                            device.status = "Có sẵn";
                            DeviceBUS.UpdateDevice(device);
                        }
                    }
                    load_data();
                }
                else
                {
                    MessageBox.Show("Từ chối đơn đặt chỗ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void FormBorrewedDevices_Load(object sender, EventArgs e)
        {
            load_data();
        }
    }
}