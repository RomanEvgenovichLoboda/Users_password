using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0204.Classes
{
    class User
    {
        public User() { }
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public override string ToString() { return string.Format("id: {0}\tname: {1}\temail: {2}", id, email, password); }
    }
}
