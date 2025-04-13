using qltv.BUS;
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

        public void load_data()
        {
            table_BDL.DataSource = ReservationBUS.GetAllReservation();

            table_BDL.Columns["reservation_id"].HeaderText = "Mã vi phạm";
            table_BDL.Columns["member_id"].HeaderText = "Mã thành viên";
            table_BDL.Columns["device_id"].HeaderText = "Mã thiết bị";
            table_BDL.Columns["reservation_date"].HeaderText = "Ngày đặt chỗ";
            table_BDL.Columns["borrowed_date"].HeaderText = "Ngày mượn";
            table_BDL.Columns["returned_date"].HeaderText = "Ngày trả";
            table_BDL.Columns["status"].HeaderText = "Trạng thái";
        }

        private void FormBorrewedDevices_Load(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
