using MySql.Data.MySqlClient;
using QLTV.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.DAO
{
    internal class ViolationDAO
    {
        public static DataTable GetALlViolation()
        {
            string query = "select * from violations";
            return DatabaseHelper.GetData(query);
        }
    }
}
