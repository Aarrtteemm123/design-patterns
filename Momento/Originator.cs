using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Originator
    {
        private String login;
        private String password;

        public String getLogin()
        {
            return login;
        }

        public void setLogin(String login)
        {
            this.login = login;
        }

        public String getPassword()
        {
            return password;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public Admin createAdmin()
        {
            return new Admin(login, password);
        }

        public void setDataFromAdmin(Admin admin)
        {
            this.login = admin.getLogin();
            this.password = admin.getPassword();
        }
    }
}
