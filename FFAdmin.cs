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
    public partial class FFAdmin: Form
    {
        public FFAdmin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Text = "Phần mềm quán lý thư quán"; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            Form3 memberlist = new Form3();

            contentContainer.Controls.Clear();

            memberlist.TopLevel = false;
            memberlist.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(memberlist);
            memberlist.Show();

        }
        bool menuExpand = false;
        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                sidebarTransition.Start();
                if(sidebar.Width >= 265)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = true;
                }
                menuContainer.Height += 5;
                if (menuContainer.Height >= 185)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 5;
                if (menuContainer.Height <= 65)
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
                    menuContainer.Height -= 5;
                    if(menuContainer.Height <=65)
                    {
                         menuTransition.Stop();
                         menuExpand = false;
                    }
                    sidebarTransition.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 265)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            contentContainer.Controls.Clear();

            Form2 form2 = new Form2();
            form2.TopLevel = false; // ko hiện thị form 2 làm màn hình chính
            form2.Dock = DockStyle.Fill; 
            contentContainer.Controls.Add(form2);

            form2.Show();
        }
    }
}
