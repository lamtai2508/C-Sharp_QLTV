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
            this.Dock = DockStyle.Fill;
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
        private void MemberList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
