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
            Student student0 = new Student("14", "student0", "student0");
            Student student1 = new Student("15", "student1", "student1");
            List<User> list = new List<User>();
            list.Add(student0);
            list.Add(student1);
            MenuLogin login = new MenuLogin(list);
            //Student student = new Student("148877");
            //Student student0 = new Student("12");
            //Student student1 = new Student(student0);
            //student0.View();
            //student1.View();
            //Admin admin = new Admin();
            //Admin admin2;
            //admin2 = (Admin)admin.AddAdmin();
            //List<User> list = new List<User>();
            //list.Add(student);
            //list.Add(student0);
            //list.Add(student1);
            //list.Add(admin2);
            //foreach (var item in list)
            //{
            //    item.View();
            //}
            Console.Read();
        }
    }
}
