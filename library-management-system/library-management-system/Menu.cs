using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    class Menu
    {
        public string capital { get; set; }
        public string menu { get; set; }
        public string content { get; set; }
        public ConsoleColor color;

        public Menu()
        {
            color = ConsoleColor.Gray;
        }

        private void Colour()
        {
            Console.ForegroundColor = color;
        }

        public void Show()
        {
            Console.Clear();
            Colour();
            Console.WriteLine(capital);
            Console.WriteLine(menu);
            Console.WriteLine(content);
        }

    }
}
