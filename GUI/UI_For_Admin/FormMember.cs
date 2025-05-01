using qltv.BUS;
using qltv.DAO;
using qltv.DTO;
using qltv.GUI.UI_For_Admin;
using QLTV.Resources;
using qltv_Winform.GUI.UI_For_Admin;
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
    public partial class FormMember : Form
    {
        private DatabaseHelper dbHelper;
        public FormMember()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            dbHelper = new DatabaseHelper();
            this.Dock = DockStyle.Fill;
        }
        // Load data của bảng
        private void LoadData()
        {
            members_table.DataSource = MemberBUS.GetAllMember();
            // Đổi tên header 
            members_table.Columns["member_id"].HeaderText = "Mã thành viên";
            members_table.Columns["full_name"].HeaderText = "Tên thành viên";
            members_table.Columns["gender"].HeaderText = "Giới tính";
            members_table.Columns["number_phone"].HeaderText = "Số điện thoại";
            members_table.Columns["dob"].HeaderText = "Ngày sinh";
            members_table.Columns["email"].HeaderText = "Email";
            members_table.Columns["status"].HeaderText = "Trạng thái";

        }
        // Xoa tất cả các textbox input
        private void ClearInput()
        {
            tbMaTV.Text = "";
            tbFullname.Text = "";
            tbGender.Text = "";
            tbNumberphone.Text = "";
            tbDob.Text = "";
            tbEmail.Text = "";
            tbMaTV.Enabled = true;
        }
        private void MemberList_Load(object sender, EventArgs e)
        {
            ClearInput();
            LoadData();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra định dạng ngày sinh có nhập đúng ko
            if (!DateTime.TryParse(tbDob.Text, out DateTime dobValue))
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MemberDTO DTO = new MemberDTO()
            {
                member_id = tbMaTV.Text,
                full_name = tbFullname.Text,
                gender = tbGender.Text,
                number_phone = tbNumberphone.Text,
                dob = dobValue,
                email = tbEmail.Text
            };
            if (MemberBUS.Addmember(DTO))
            {
                MessageBox.Show("Thêm thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInput();
            }
            else
            {
                MessageBox.Show("Thêm thành viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_loaddata_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearInput();
        }
        // Event button thêm 1 thành viên
        private void members_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = members_table.Rows[e.RowIndex];
                tbMaTV.Text = row.Cells["member_id"].Value.ToString();
                tbFullname.Text = row.Cells["full_name"].Value.ToString();
                tbGender.Text = row.Cells["gender"].Value.ToString();
                tbNumberphone.Text = row.Cells["number_phone"].Value.ToString();
                tbDob.Text = row.Cells["dob"].Value.ToString();
                tbEmail.Text = row.Cells["email"].Value.ToString();

                tbMaTV.Enabled = false;
            }
        }
        // Event button sửa thông tin thành viên
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(tbDob.Text, out DateTime dobValue))
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MemberDTO DTO = new MemberDTO()
            {
                member_id = tbMaTV.Text,
                full_name = tbFullname.Text,
                gender = tbGender.Text,
                number_phone = tbNumberphone.Text,
                dob = dobValue,
                email = tbEmail.Text
            };
            if (MemberBUS.UpdateMember(DTO))
            {
                MessageBox.Show("Sửa thông tin thành viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInput();
            }
            else
            {
                MessageBox.Show("Sửa thông tin thành viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Event xóa 1 thành viên
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string member_id = tbMaTV.Text;

            if (member_id == null)
            {
                MessageBox.Show("Vui lòng cho thành viên muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Xác nhận lại xem có thật sự muốn xóa hay ko
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thành viên này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                MemberBUS.DeleteMember(member_id);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInput();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // event tìm kiếm thành viên
        private void btSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearch.Text))
            {
                members_table.DataSource = MemberBUS.SearchMembers(tbSearch.Text);
                if (members_table.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thành viên nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                LoadData();
            }
        }
        //
        private void btDeleteMuti_Click(object sender, EventArgs e)
        {
            using (FormBulkDeleteMembers bulkMemberForm = new FormBulkDeleteMembers())
            {
                if (bulkMemberForm.ShowDialog() == DialogResult.OK)
                {
                    // Nếu xóa thành công, làm mới danh sách
                    LoadData();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.csv";
                    openFileDialog.Title = "Chọn file Excel chứa danh sách thành viên";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        // Hiển thị form nhập Excel
                        using (FormImportMemberExcel importForm = new FormImportMemberExcel(filePath))
                        {
                            if (importForm.ShowDialog() == DialogResult.OK)
                            {
                                // Nếu nhập thành công, làm mới danh sách thành viên
                                LoadData();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nhập thành viên từ Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
