using qltv.BUS;
using qltv.DAO;
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

namespace QLTV
{
    public partial class MemberList : Form
    {
        private DatabaseHelper dbHelper;
        public MemberList()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            dbHelper = new DatabaseHelper();
            this.Dock = DockStyle.Fill;
        }
        // Load data của bảng
        private void LoadData()
        {
            members_table.DataSource = MemberBUS.GetAllMenber();
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
            if(MemberBUS.Addmember(DTO))
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
    }
}
