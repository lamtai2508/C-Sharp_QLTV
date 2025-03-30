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
    public partial class FormReserve : Form
    {
        private DatabaseHelep dbHelper;
        public FormReserve()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            dbHelper = new DatabaseHelep();
            this.Dock = DockStyle.Fill;

        }

        public void FormReserve_Load()
        {
            // Load data from database
        }
    }
}
