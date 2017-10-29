using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    class Student
        : User
    {
        private string ID;

        public Student(string id)
            : base("asf","saf","dsf","sdf")
        {
            ID = id;
        }

        public Student(Student student)
    : base(student)
        {
            ID = student.ID + "a";
        }

        public override void View()
        {
            base.View();
            Console.WriteLine(ID);
        }

        public override void Create()
        {
            base.Create();
            View("nr albumu: ");
            ID = Console.ReadLine();
        }
    }
}
