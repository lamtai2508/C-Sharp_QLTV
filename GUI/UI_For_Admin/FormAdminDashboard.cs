using qltv.GUI.UI_For_Admin;
using qltv.GUI.UI_For_Login;
using qltv.GUI.UI_For_User;

namespace QLTV
{
    public partial class FormAdminDashboard : Form
    {
        bool menuExpand = true;
        bool deviceExpand = false;

        public FormAdminDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void bt_device_transition_Click(object sender, EventArgs e)
        {
            deviceTransition.Start();
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        //event hiện thị form danh sách thành viên
        private void bt_member_Click(object sender, EventArgs e)
        {
            MemberList mbList = new MemberList();

            contentContainer.Controls.Clear();

            mbList.TopLevel = false;
            mbList.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(mbList);
            mbList.Show();
        }

        //event hiện thị form trang chủ
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

        // event hien thị form lịch sử vi phạm
        private void bt_violationList_Click(object sender, EventArgs e)
        {
            FormViolation fv = new FormViolation();
            contentContainer.Controls.Clear();

            fv.TopLevel = false;
            fv.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(fv);
            fv.Show();
        }

        private void bt_borrweddevice_Click(object sender, EventArgs e)
        {
            FormBorrowedDevices BD = new FormBorrowedDevices();
            contentContainer.Controls.Clear();

            BD.TopLevel = false;
            BD.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(BD);
            BD.Show();
        }

        private void bt_statistics_Click(object sender, EventArgs e)
        {   
            FormStatistical ST = new FormStatistical();
            contentContainer.Controls.Clear();
            ST.TopLevel = false;
            ST.FormBorderStyle = FormBorderStyle.None;
            ST.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(ST);
            ST.Show();
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                contentContainer.Controls.Clear();
                sidebar.Width -= 5;
                if (sidebar.Width <= 76)
                {
                    // tự động thu lại khi menu thu nhỏ
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
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
            else
            {
                contentContainer.Controls.Clear();
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

        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }
    }
}