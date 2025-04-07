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

namespace qltv.GUI.UI_For_Admin
{
    public partial class FormBorrowedDevices : Form
    {
        public FormBorrowedDevices()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public void load_data ()
        {
            table_BDL.DataSource = UsersRepository.GetBorrewedDevice();

        }

        private void FormBorrewedDevices_Load(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
