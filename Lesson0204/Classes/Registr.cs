using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            List<User> usList = new List<User>();
                usList = GetUsers();
            foreach (var item in usList)
            {
                if(item.email ==_email )//&& new Crypto().veryfy(item.password,_pass) == true)
                MessageBox.Show(item.ToString());
            }
            //string connectionString = @"Data Source=DESKTOP-54SAU6R\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //   var eventName = connection.QueryFirst<string>($"SELECT * FROM [Users] WHERE email = {_email} AND password = {_pass}");

            //    MessageBox.Show(eventName);
            //    //User regestration = new User() { email = _email, password = new Crypto().Generate(_pass) };
            //    //List<User> usList = connection.Execute($"SELECT * FROM [Users] WHERE email = {_email} AND password = {_pass}").ToList();
            //}
        }
        public List<User> GetUsers()
        {
            string connectionString = @"Data Source=DESKTOP-54SAU6R\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<User>($"SELECT * FROM [Users] ").ToList();
            }
        }
    }
}