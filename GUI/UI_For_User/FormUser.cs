using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
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
            this.FormClosing += new FormClosingEventHandler(FormUser_FormClosing); // Add the FormClosing event handler
        }

        private void FormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Exit the application when the form is closing
        }

        private void ThanhVien_bt_Click(object sender, EventArgs e)
        {
            memberTransition.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        // Hàm Transition cho button member
        private void memberTransition_Click(object sender, EventArgs e)
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

        private void contentContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormReserve fr = new FormReserve();
            contentContainer.Controls.Clear();

            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(fr);
            fr.Show();
        }

        //FormHistory Button click event
        private void button10_Click(object sender, EventArgs e)
        {
            // Add your event handling code here
            FormHistory fh = new FormHistory();
            contentContainer.Controls.Clear();

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(fh);
            fh.Show();
        }

        //FormViolation click event
        private void button1_Click(object sender, EventArgs e)
        {
            // Add your event handling code here
            FormViolation fv = new FormViolation();
            contentContainer.Controls.Clear();

            fv.TopLevel = false;
            fv.Dock = DockStyle.Fill;
            contentContainer.Controls.Add(fv);
            fv.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
