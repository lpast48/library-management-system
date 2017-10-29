using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    abstract class Info
    {
        Menu menu = new Menu();
        public ConsoleColor color = ConsoleColor.Gray;
        public void Colour()
        {
            Console.ForegroundColor = color;
        }

        public virtual void View()
        {
            Colour();
        }

        public virtual void View(string text)
        {
            Colour();
        }
    }
}
