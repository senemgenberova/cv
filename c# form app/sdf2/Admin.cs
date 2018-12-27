using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdf2
{
    public class Admin
    {
        public string username, password;

        public Admin(string username, string pass) {
            this.username = username;
            this.password = pass;
        }
    }
}
