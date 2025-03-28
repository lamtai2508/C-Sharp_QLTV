using MySql.Data.MySqlClient;
using qltv.DTO;
using QLTV.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace qltv.DAO
{
    internal class AccountDAO
    {
        public static accountDTO GetAccount(String account_id)
        {

            string query = "select * from account where account_id = @account_id ";
            using (MySqlConnection conn = DatabaseHelep.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("account_id", account_id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {

                    return new accountDTO
                    {
                        account_id = reader["account_id"].ToString(),
                        password = reader["password"].ToString(),
                        role = (int)reader["role"]
                    };
                }    
            }return null;    
        }
    }
}
