using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    class User : Info
    {
        public User()
        {
            color = ConsoleColor.DarkYellow;
        }
        public override void View()
        {
            base.View();
            Console.Write("User ");
        }
    }
}
