using qltv.DAO;
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

namespace qltv.GUI.UI_For_User
{
    public partial class InfoMember : Form
    {
        public InfoMember()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public void LoadData()
        {
            //Lấy thông tin của thành viên sau khi đăng nhập thành công.
            //Session.CurrentMember = MemberDAO.GetMemberById(Session.CurrentMember.member_id);
            //txtMemberid.Text = Session.CurrentMember.member_id;
            //txtFullName.Text = Session.CurrentMember.full_name;
            //txtGender.Text = Session.CurrentMember.gender;
            //txtNumberPhone.Text = Session.CurrentMember.number_phone;
            //txtDob.Text = Session.CurrentMember.dob.ToString("yyyy-MM-dd");
            //txtEmail.Text = Session.CurrentMember.email;
            //txtStatus.Text = Session.CurrentMember.status;

        }

        private void InfoMember_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
