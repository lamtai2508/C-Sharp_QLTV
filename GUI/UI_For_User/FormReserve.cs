using System;
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

        // Phương thức xử lý sự kiện khi form được tải lên
        private void FormReserve_Load(object sender, EventArgs e)
        {
            // TODO: Thêm logic nếu cần khi form mở lên
        }
    }
}
