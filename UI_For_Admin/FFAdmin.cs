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
    public partial class FFAdmin : Form
    {
        public FFAdmin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void contentContainer_Resize(object sender, EventArgs e)
        {
            if (contentContainer.Controls.Count > 0)
            {
                contentContainer.Controls[0].Dock = DockStyle.Fill; // Form con tự mở rộng theo Panel
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MemberList mbList = new QLTV.MemberList();

            contentContainer.Controls.Clear();

            mbList.TopLevel = false;
            mbList.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(mbList);
            mbList.Show();

        }
        bool menuExpand = false;
        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                sidebarTransition.Start();
                if (sidebar.Width >= 355)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = true;
                }
                menuContainer.Height += 5;
                if (menuContainer.Height >= 275)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 5;
                if (menuContainer.Height <= 98)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }

        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 76)
                {
                    menuTransition.Start();
                    if (menuContainer.Height <= 98)
                    {
                        menuTransition.Stop();
                        menuExpand = false;
                    }
                    else
                    {
                        menuContainer.Height -= 5;
                    }
                    sidebarTransition.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 355)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = true;
                }
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            contentContainer.Controls.Clear();

            Home home = new Home();
            home.TopLevel = false; // ko hiện thị form 2 làm màn hình chính
            home.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(home);

            home.Show();
        }
    }
}
