using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    class Admin
        : User
    {
        public Admin()
            : base("name", "surname", "login", "password")
        {
            color = ConsoleColor.Red;
        }
        public override void View()
        {
            base.View();
            Console.WriteLine("admin");
        }

        public User AddStudent()
        {
            User student = new Student("1", "login", "pass");
            student.Create();
            return student;
        }

        public User AddAdmin()
        {
            User admin = new Admin();
            admin.Create();
            return admin;
        }
    }
}
