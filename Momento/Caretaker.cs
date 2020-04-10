using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Caretaker
    {
        private List<Admin> adminList = new List<Admin>();

        public void add(Admin admin)
        {
            adminList.Add(admin);
        }

        public Admin getAdminByIndex(int index)
        {
            if (index >= 0 && index < adminList.Count)
                return adminList[index];
            return null;
        }
    }
}
