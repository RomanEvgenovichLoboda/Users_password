using Dapper;
using Dapper.Contrib.Extensions;
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
            string connectionString = @"Data Source=DESKTOP-54SAU6R\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                User regestration = new User() { email = _email, password = new Crypto().Generate(_pass) };
                connection.Execute("INSERT INTO Users (email, password) VALUES(@email,@password)", regestration);
                //}
                //string connectionString = @"Data Source=DESKTOP-54SAU6R\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    User regestration = new User() { email = _email, password = new Crypto().Generate(_pass) };
                //    connection.Insert(regestration);
                //}
            }
        }
        public void signIn(string _email, string _pass)
        {

        }
    }
}