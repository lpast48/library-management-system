using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    class Admin : User
    {
        public Admin()
        {
            color = ConsoleColor.Red;
        }
        public override void View()
        {
            base.View();
            Console.WriteLine("admin");
        }
    }
}
