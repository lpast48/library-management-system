using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            User student0 = new Student("14", "student0", "student0");
            User student1 = new Student("15", "student1", "student1");
            User admin = new Admin();
            List<User> list = new List<User>();
            list.Add(student0);
            list.Add(student1);
            list.Add(admin);
            MenuLogin login = new MenuLogin(list);
            Console.Read();
        }
    }
}
