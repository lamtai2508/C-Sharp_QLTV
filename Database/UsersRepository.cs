using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Resources
{
    public class UsersRepository
    {
        //Lấy dữ liệu bảng member trong database
        public static DataTable GetUser()
        {
            String query = "SELECT * FROM MEMBERS";
            return DatabaseHelep.GetData(query);
        }
    }
}
