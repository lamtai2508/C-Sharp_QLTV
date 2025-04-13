using qltv.BUS;
using qltv.DTO;
using qltv.GUI.UI_For_User;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace qltv.GUI.UI_For_Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tb_user_Enter(object sender, EventArgs e)
        {
            if (tb_user.Text == "Mã thành viên")
            {
                tb_user.Text = "";
                tb_user.ForeColor = Color.Black;
            }
        }

        private void tb_user_Leave(object sender, EventArgs e)
        {
            if (tb_user.Text == "")
            {
                tb_user.Text = "Mã thành viên";
                tb_user.ForeColor = Color.Gray;
            }
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "Mật khẩu")
            {
                tb_password.Text = "";
                tb_password.ForeColor = Color.Black;
                tb_password.UseSystemPasswordChar = true;
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.Text = "Mật khẩu";
                tb_password.ForeColor = Color.Gray;
            }
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string username = tb_user.Text;
            string password = tb_password.Text;

            accountDTO account = AuthBUS.Login(username, password);

            if (account != null)
            {
                // đăng nhập thành công vào admin
                if (account.role == 0)
                {
                    this.Hide();
                    new FormAdminDashboard().ShowDialog();

                    this.Close();
                }
                // Đăng nhập thành công vào user
                if (account.role == 1)
                {
                    this.Hide();
                    new FormUserDashboard().ShowDialog();

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Login_Click(sender, e);
            }
        }
    }
}
