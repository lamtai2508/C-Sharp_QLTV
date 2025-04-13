using qltv.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.BUS
{
    internal class ViolationBUS
    {
        public static DataTable GetAllViolation()
        {
            return ViolationDAO.GetALlViolation();
        }
    }
}
