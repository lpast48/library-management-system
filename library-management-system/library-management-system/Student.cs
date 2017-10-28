using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    class Student:User
    {
        public override void View()
        {
            base.View();
            Console.WriteLine("Student");
        }
    }
}
