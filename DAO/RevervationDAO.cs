using QLTV.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.DAO
{
    internal class RevervationDAO
    {
        public static DataTable GetALLReservation()
        {
            string query = "select * from reservations";
            return DatabaseHelper.GetData(query);
        }
    }
}
