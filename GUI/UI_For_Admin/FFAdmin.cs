namespace QLTV
{
    public partial class FFAdmin : Form
    {
        bool menuExpand = true;
        bool deviceExpand = false;
        bool memberExpand = false;
        bool violationExpand = false;
        bool statisticsExpand = false;


        public FFAdmin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            memberTransition.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    // thu nhỏ thống kê
                    statisticsTransition.Start();
                    if (statisticsContainer.Height <= 98)
                    {
                        statisticsTransition.Stop();
                        statisticsExpand = false;
                    }
                    else
                    {
                        statisticsContainer.Height -= 5;
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            contentContainer.Controls.Clear();

            Home home = new Home();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(home);

            home.Show();
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            deviceTransition.Start();
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
                if (deviceContainer.Height >= 385)
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
                if (memberContainer.Height >= 275)
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

        private void deviceContainer_Paint(object sender, PaintEventArgs e)
        {

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

        private void bt_violation_Click(object sender, EventArgs e)
        {
            violationTransition.Start();
        }

        private void statisticsTransiton_Tick(object sender, EventArgs e)
        {
            if (statisticsExpand == false)
            {
                // tự động phóng to menu khi click icon Member
                menuTransition.Start();
                if (sidebar.Width >= 355)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
                statisticsContainer.Height += 5;
                if (statisticsContainer.Height >= 180)
                {
                    statisticsTransition.Stop();
                    statisticsExpand = true;
                }
            }
            else
            {
                statisticsContainer.Height -= 5;
                if (statisticsContainer.Height <= 98)
                {
                    statisticsTransition.Stop();
                    statisticsExpand = false;
                }
            }

        }

        private void bt_statistics_Click(object sender, EventArgs e)
        {
            statisticsTransition.Start();
        }
    }
}
