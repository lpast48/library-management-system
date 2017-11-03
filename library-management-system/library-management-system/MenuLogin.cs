using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    class MenuLogin
        : Menu
    {
        List<User> list;

        public MenuLogin(List<User> list)
            : base()
        {
            this.list = list;
            PrepareMenu();
            Show();
            Login();
        }

        private void PrepareMenu()
        {
            capital = "LOGIN";
            menu = "exit ";
            content += "podaj: [login:hasło]";
        }

        private void Login()
        {
            string line = Console.ReadLine();
            string[] inArray = line.Split(':');
            try
            {
                User user = Parse(inArray);
                Menu menu = new MenuMain(user);
            }
            catch(Exception e)
            {
                content = "blad logowania! \n";
                PrepareMenu();
                Show();
                Login();
            }
        }

        private User Parse(string[] inArray)
        {
            foreach (var item in list)
            {
                if (item.CheckLogin(inArray))
                {
                    return item;
                }
            }

            throw new Exception();
        }
    }
}
