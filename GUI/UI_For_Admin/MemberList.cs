using qltv.BUS;
using qltv.DAO;
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
        private DatabaseHelper dbHelper;
        public MemberList()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            dbHelper = new DatabaseHelper();
            this.Dock = DockStyle.Fill;
        }
        private void LoadData()
        {
            members_table.DataSource = MemberBUS.GetAllMenber();
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
    }
}
