using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.Resources;

namespace qltv.GUI.UI_For_User
{
    public partial class FormViolation : Form
    {
        private DatabaseHelep dbHelper;
        public FormViolation()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            dbHelper = new DatabaseHelep();
            this.Dock = DockStyle.Fill;
        }

        private void LoadData()
        {
            // Retrieve data from the database and bind it to the DataGridView
            dataGridView1.DataSource = UsersRepository.GetUser();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormViolation_Load(object sender, EventArgs e)
        {

        }
    }
}
