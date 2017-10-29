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
            Student student0 = new Student("12");
            Student student1 = new Student(student0);
            student0.View();
            student1.View();
            User student;
            Admin admin = new Admin();
            Admin admin2;
            student = admin.AddStudent();
            admin2 = (Admin)admin.AddAdmin();
            List<User> list = new List<User>();
            list.Add(student);
            list.Add(admin2);
            foreach (var item in list)
            {
                item.View();
            }
            Console.Read();
        }
    }
}
