using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    class MenuMain
        : Menu
    {
        User user;
        public MenuMain(User user)
        {
            this.user = new User(user);
            color = user.color;
            PrepareMenu();
            Show();
        }

        private void PrepareMenu()
        {
            capital = user.Name + " " + user.Surname;
            menu = "logout";
            content = "menu główne";
        }
    }
}
