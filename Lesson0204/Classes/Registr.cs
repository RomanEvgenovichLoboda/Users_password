using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0204.Classes
{
    class Registr
    {
        public Registr() { }
        public void Regestration(string _email, string _pass)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                User regestration = new User() { email = _email, password = new Crypto().Generate(_pass) };
                connection.Execute("INSERT INTO user (email, password) VALUES(@email,@password)", regestration);
            }
        }
    }
}
