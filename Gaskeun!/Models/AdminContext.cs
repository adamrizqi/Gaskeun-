using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class AdminContext : Connection
    {
        public bool CekAdmin(string username, string password)
        {
            bool isSucces = false;
            using (var conn = GetConnection())
            {
                string sqlAdmin = "SELECT COUNT(1) FROM akun WHERE username = @username AND password = @password AND role = @role";
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sqlAdmin, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("role", "admin");

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        isSucces = true;
                    }
                    else
                    {
                        isSucces = false;
                    }
                }
            }
            return isSucces;
        }
    }
}
