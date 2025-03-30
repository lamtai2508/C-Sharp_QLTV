using qltv.GUI.UI_For_Admin;
using qltv.GUI.UI_For_Login;


namespace QLTV
{
    public partial class FormAdminDashboard : Form
    {
        bool menuExpand = true;
        bool deviceExpand = false;
        bool memberExpand = false;
        bool violationExpand = false;
        bool statisticsExpand = false;


        public FormAdminDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void bt_member_Click(object sender, EventArgs e)
        {
            memberTransition.Start();
        }
        private void bt_violation_Click(object sender, EventArgs e)
        {
            violationTransition.Start();
        }

        private void bt_device_transition_Click(object sender, EventArgs e)
        {
            deviceTransition.Start();
        }
        private void bt_menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        private void bt_home_Click_1(object sender, EventArgs e)
        {
            contentContainer.Controls.Clear();

            Home home = new Home();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(home);

            home.Show();
        }
        private void bt_deviceList_Click(object sender, EventArgs e)
        {
            // Tải FormDevice vào contentContainer
            FormDevice deviceForm = new FormDevice();
            contentContainer.Controls.Clear();
            deviceForm.TopLevel = false;
            deviceForm.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(deviceForm);
            deviceForm.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            MemberList mbList = new MemberList();

            contentContainer.Controls.Clear();

            mbList.TopLevel = false;
            mbList.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(mbList);
            mbList.Show();

        }
        private void menuTransition_Tick(object sender, EventArgs e)
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
                    // thu nhỏ device
                    deviceTransition.Start();
                    if (deviceContainer.Height <= 98)
                    {
                        deviceTransition.Stop();
                        deviceExpand = false;
                    }
                    else
                    {
                        deviceContainer.Height -= 5;
                    }
                    // thu nhỏ vi phạm
                    violationTransition.Start();
                    if (violationContainer.Height <= 98)
                    {
                        violationTransition.Stop();
                        violationExpand = false;
                    }
                    else
                    {
                        violationContainer.Height -= 5;
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
        private void deviceTransition_Tick(object sender, EventArgs e)
        {
            if (deviceExpand == false)
            {
                // tự động phóng to menu khi click icon device
                menuTransition.Start();
                if (sidebar.Width >= 355)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }

                deviceContainer.Height += 5;
                if (deviceContainer.Height >= 290)
                {
                    deviceTransition.Stop();
                    deviceExpand = true;
                }
            }
            else
            {
                deviceContainer.Height -= 5;
                if (deviceContainer.Height <= 98)
                {
                    deviceTransition.Stop();
                    deviceExpand = false;
                }
            }
        }
        private void MemberTransition_Tick(object sender, EventArgs e)
        {
            if (memberExpand == false)
            {
                // tự động phóng to menu khi click icon Member
                menuTransition.Start();
                if (sidebar.Width >= 355)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
                memberContainer.Height += 5;
                if (memberContainer.Height >= 190)
                {
                    memberTransition.Stop();
                    memberExpand = true;
                }
            }
            else
            {
                memberContainer.Height -= 5;
                if (memberContainer.Height <= 98)
                {
                    memberTransition.Stop();
                    memberExpand = false;
                }
            }
        }
        private void violationTransition_Tick(object sender, EventArgs e)
        {
            if (violationExpand == false)
            {
                // tự động phóng to menu khi click icon Member
                menuTransition.Start();
                if (sidebar.Width >= 355)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
                violationContainer.Height += 5;
                if (violationContainer.Height >= 180)
                {
                    violationTransition.Stop();
                    violationExpand = true;
                }
            }
            else
            {
                violationContainer.Height -= 5;
                if (violationContainer.Height <= 98)
                {
                    violationTransition.Stop();
                    violationExpand = false;
                }
            }
        }
        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
