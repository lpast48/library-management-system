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
            User student = new Student();
            Admin admin = new Admin();
            List<User> list = new List<User>();
            list.Add(student);
            list.Add(admin);
            foreach (var item in list)
            {
                item.View();
            }
            Console.Read();
        }
    }
}
