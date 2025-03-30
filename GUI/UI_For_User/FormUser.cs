using qltv.GUI.UI_For_Login;
using QLTV;
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
    public partial class FormUser : Form
    {
        bool memberExpand = false;
        bool menuExpand = false;
        bool historyExpand = false;

        public FormUser()
        {
            InitializeComponent();
        }
        // event khi bấm vào button thông tin thành viên
        private void ThanhVien_bt_Click(object sender, EventArgs e)
        {
            contentContainer.Controls.Clear();

            InfoMember infomember = new InfoMember();
            infomember.TopLevel = false;
            infomember.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(infomember);

            infomember.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        // Hàm Transition cho button member

        //Hàm Transition cho menu
        private void menuTransition_Tick_1(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 76)
                {
                    // tự động thu lại khi menu thu nhỏ
                    // thu nhỏ member
                    memberTransition.Start();
                    if (memberContainer.Height <= 98)
                    {
                        memberTransition.Stop();
                        memberExpand = false;
                    }
                    else
                    {
                        memberContainer.Height -= 5;
                    }
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 355)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
        }

        private void historyTransition_Tick(object sender, EventArgs e)
        {
            if (historyExpand == false)
            {
                // tự động phóng to menu khi click icon Member
                menuTransition.Start();
                if (sidebar.Width >= 355)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
                historyContainer.Height += 5;
                if (historyContainer.Height >= 290)
                {
                    historyTransition.Stop();
                    historyExpand = true;
                }
            }
            else
            {
                historyContainer.Height -= 5;
                if (historyContainer.Height <= 98)
                {
                    historyTransition.Stop();
                    historyExpand = false;
                }
            }
        }

        private void bt_violation_Click(object sender, EventArgs e)
        {
            historyTransition.Start();
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
