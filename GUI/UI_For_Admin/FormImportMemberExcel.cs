using qltv.BUS;
using qltv.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qltv_Winform.GUI.UI_For_Admin
{
    public partial class FormImportMemberExcel : Form
    {
        private string _filePath;
        private DataGridView dgvPreview;
        private Button btnImport;
        private Button btnCancel;
        private CheckBox chkFirstRowHeader;
        public FormImportMemberExcel(string filePath)
        {
            _filePath = filePath;
            SetupUI();
            LoadPreview();
        }
        private void SetupUI()
        {
            this.Text = "Nhập dữ liệu từ Excel";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Label
            Label lblTitle = new Label();
            lblTitle.Text = "XEM TRƯỚC DỮ LIỆU EXCEL";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(20, 20);
            lblTitle.Size = new System.Drawing.Size(550, 40);
            this.Controls.Add(lblTitle);

            // Checkbox
            chkFirstRowHeader = new CheckBox();
            chkFirstRowHeader.Text = "Dòng đầu tiên là tiêu đề";
            chkFirstRowHeader.Checked = true;
            chkFirstRowHeader.Font = new System.Drawing.Font("Segoe UI", 10);
            chkFirstRowHeader.Location = new System.Drawing.Point(20, 70);
            chkFirstRowHeader.Size = new System.Drawing.Size(200, 30);
            chkFirstRowHeader.CheckedChanged += (s, e) => LoadPreview();
            this.Controls.Add(chkFirstRowHeader);

            // Label file path
            Label lblFilePath = new Label();
            lblFilePath.Text = "File: " + Path.GetFileName(_filePath);
            lblFilePath.Font = new System.Drawing.Font("Segoe UI", 10);
            lblFilePath.Location = new System.Drawing.Point(240, 70);
            lblFilePath.Size = new System.Drawing.Size(540, 30);
            this.Controls.Add(lblFilePath);

            // DataGridView để xem trước
            dgvPreview = new DataGridView();
            dgvPreview.Location = new System.Drawing.Point(20, 110);
            dgvPreview.Size = new System.Drawing.Size(750, 400);
            dgvPreview.AllowUserToAddRows = false;
            dgvPreview.AllowUserToDeleteRows = false;
            dgvPreview.ReadOnly = true;
            dgvPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Controls.Add(dgvPreview);

            // Button nhập
            btnImport = new Button();
            btnImport.Text = "Nhập dữ liệu";
            btnImport.Font = new System.Drawing.Font("Segoe UI", 12);
            btnImport.Location = new System.Drawing.Point(540, 520);
            btnImport.Size = new System.Drawing.Size(120, 40);
            btnImport.Click += BtnImport_Click;
            this.Controls.Add(btnImport);

            // Button hủy
            btnCancel = new Button();
            btnCancel.Text = "Hủy";
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 12);
            btnCancel.Location = new System.Drawing.Point(670, 520);
            btnCancel.Size = new System.Drawing.Size(100, 40);
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            this.Controls.Add(btnCancel);
        }
        private void LoadPreview()
        {
            try
            {
                DataTable dt = new DataTable();
                bool hasHeader = chkFirstRowHeader.Checked;

                // Đọc file CSV
                if (_filePath.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
                {
                    string[] lines = File.ReadAllLines(_filePath);
                    if (lines.Length > 0)
                    {
                        string[] headers = lines[0].Split(',');

                        // Tạo cột
                        if (hasHeader)
                        {
                            foreach (string header in headers)
                            {
                                dt.Columns.Add(header.Trim('"'));
                            }

                            // Thêm dữ liệu từ dòng thứ 2
                            for (int i = 1; i < lines.Length; i++)
                            {
                                string[] fields = lines[i].Split(',');
                                DataRow row = dt.NewRow();
                                for (int j = 0; j < headers.Length && j < fields.Length; j++)
                                {
                                    row[j] = fields[j].Trim('"');
                                }
                                dt.Rows.Add(row);
                            }
                        }
                        else
                        {
                            // Tạo cột tự động
                            for (int i = 0; i < headers.Length; i++)
                            {
                                dt.Columns.Add("Column" + (i + 1));
                            }

                            // Thêm dữ liệu từ dòng đầu tiên
                            for (int i = 0; i < lines.Length; i++)
                            {
                                string[] fields = lines[i].Split(',');
                                DataRow row = dt.NewRow();
                                for (int j = 0; j < headers.Length && j < fields.Length; j++)
                                {
                                    row[j] = fields[j].Trim('"');
                                }
                                dt.Rows.Add(row);
                            }
                        }
                    }
                }
                else
                {
                    // Đọc file Excel - Sử dụng một giải pháp thay thế
                    MessageBox.Show("Chức năng đọc file Excel cần sử dụng thư viện bổ sung. Vui lòng sử dụng file CSV.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvPreview.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPreview.DataSource == null || !(dgvPreview.DataSource is DataTable dt) || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra cấu trúc dữ liệu
                bool validStructure = true;
                string[] requiredColumns = { "member_id", "full_name", "gender","number_phone","dob","email", "status" };
                List<string> missingColumns = new List<string>();

                foreach (string col in requiredColumns)
                {
                    bool found = false;
                    foreach (DataColumn column in dt.Columns)
                    {
                        if (column.ColumnName.Equals(col, StringComparison.OrdinalIgnoreCase))
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        missingColumns.Add(col);
                        validStructure = false;
                    }
                }

                if (!validStructure)
                {
                    MessageBox.Show($"Cấu trúc dữ liệu không hợp lệ! Thiếu các cột: {string.Join(", ", missingColumns)}",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tiến hành nhập dữ liệu
                int successCount = 0;
                int failCount = 0;
                List<string> failedMembers = new List<string>();

                foreach (DataRow row in dt.Rows)
                {
                    string memberId = row["member_id"].ToString();
                    string fullName = row["full_name"].ToString();
                    string gender = row["gender"].ToString();
                    DateTime dob = Convert.ToDateTime(row["dob"]);
                    string number_phone = row["number_phone"].ToString();
                    string email = row["email"].ToString();
                    string status = row["status"].ToString();

                    // Kiểm tra dữ liệu
                    if (string.IsNullOrEmpty(memberId) || 
                        string.IsNullOrEmpty(fullName) || 
                        string.IsNullOrEmpty(gender) ||
                        dob == DateTime.MinValue ||
                        string.IsNullOrEmpty(number_phone) ||
                        string.IsNullOrEmpty(email) ||
                        string.IsNullOrEmpty(status)
                        )
                    {
                        failCount++;
                        failedMembers.Add($"ID: {memberId} - Thiếu thông tin bắt buộc");
                        continue;
                    }

                    // Kiểm tra status hợp lệ
                    if (status != "Bình thường" && status != "Được đặt chỗ" && status != "Đang được mượn")
                    {
                        status = "Bình thường"; // Nếu không hợp lệ, gán giá trị mặc định
                    }

                    MemberDTO member = new MemberDTO
                    {
                        member_id = memberId,
                        full_name = fullName,
                        gender = gender,
                        dob = dob,
                        number_phone = number_phone,
                        email = email,
                        status = status,
                    };

                    if (MemberBUS.Addmember(member))
                    {
                        successCount++;
                    }
                    else
                    {
                        failCount++;
                        failedMembers.Add($"ID: {memberId} - Thêm thất bại (có thể đã tồn tại)");
                    }
                }

                // Hiển thị kết quả
                string message = $"Nhập thành viên từ Excel hoàn tất.\nThành công: {successCount}\nThất bại: {failCount}";

                if (failCount > 0)
                {
                    message += "\n\nDanh sách thành viên thất bại:\n" + string.Join("\n", failedMembers);
                }

                MessageBox.Show(message, "Kết quả nhập thành viên",
                    MessageBoxButtons.OK, failCount > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nhập dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
