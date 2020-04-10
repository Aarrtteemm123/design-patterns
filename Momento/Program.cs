using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            Caretaker careTaker = new Caretaker();
            Admin admin = new Admin("Login_1", "Password_1");

            originator.setDataFromAdmin(admin);
            careTaker.add(originator.createAdmin());

            originator.setLogin("Login_2");
            originator.setPassword("Password_2");

            originator.setLogin("Login_3");
            originator.setPassword("Password_3");

            careTaker.add(originator.createAdmin());

            originator.setPassword("Password_4");

            careTaker.add(originator.createAdmin());

            Console.WriteLine("Current login: " + originator.getLogin());
            Console.WriteLine("Current password: " + originator.getPassword());
            Console.WriteLine("---------------------------------------------");

            originator.setDataFromAdmin(careTaker.getAdminByIndex(0));
            Console.WriteLine("First saved login: " + originator.getLogin());
            Console.WriteLine("First saved password: " + originator.getPassword());
            Console.WriteLine("---------------------------------------------");

            originator.setDataFromAdmin(careTaker.getAdminByIndex(1));
            Console.WriteLine("Second saved login: " + originator.getLogin());
            Console.WriteLine("Second saved password: " + originator.getPassword());
            Console.WriteLine("---------------------------------------------");

            originator.setDataFromAdmin(careTaker.getAdminByIndex(2));
            Console.WriteLine("Third saved login: " + originator.getLogin());
            Console.WriteLine("Third saved password: " + originator.getPassword());
        }
    }
}