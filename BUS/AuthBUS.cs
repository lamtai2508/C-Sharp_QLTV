using qltv.DAO;
using qltv.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qltv.BUS
{
    internal class AuthBUS
    {
        // Kiểm tra đăng nhập
        public static accountDTO Login(string account_id, string password)
        {
            accountDTO account = AccountDAO.GetAccount(account_id);
            if (account != null && account.password == password)
            {
                return account;
            }
            return null;
        }
    }
}
