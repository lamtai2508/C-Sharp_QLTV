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
        private DatabaseHelep dbHelper;
        public MemberList()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            dbHelper = new DatabaseHelep();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            members_table.DataSource = UsersRepository.GetUser();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (member_id_tb.Text == "")
            {
                member_id_tb.Text = "Mã thành viên";
                member_id_tb.ForeColor = Color.Black;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (member_id_tb.Text == "Mã thành viên")
            {
                member_id_tb.Text = "";
                member_id_tb.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(member_id_tb.Text))
            {
                member_id_tb.Text = "Mã thành viên";
                member_id_tb.ForeColor = Color.Gray;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
            member_id_tb.Text = "Mã thành viên";
            member_id_tb.ForeColor = Color.Gray;
            member_id_tb.Enter += textBox2_Enter;
            member_id_tb.Leave += textBox2_Leave;
        }
    }
}
