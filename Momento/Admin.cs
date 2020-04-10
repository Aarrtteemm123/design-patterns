using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Admin
    {
        private readonly String login;
        private readonly String password;

        public Admin(String login, String password)
        {
            this.login = login;
            this.password = password;
        }

        public String getLogin()
        {
            return login;
        }

        public String getPassword()
        {
            return password;
        }
    }
}
