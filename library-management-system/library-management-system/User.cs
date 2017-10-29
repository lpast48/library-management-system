using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    class User
        : Info
    {
        private string Name;
        private string Surname;
        private string Login;
        private string Password;

        public User(string name, string surname, string login, string password)
        {
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
            color = ConsoleColor.DarkYellow;
        }

        public User(User user)
        {
            Name = user.Name;
            Surname = user.Surname;
            Login = user.Login;
            Password = user.Password;
        }

        public override void View()
        {
            base.View();
            Console.Write(Name + "\t" + Surname + "\t" + Login + "\t");
        }

        public override void View(string text)
        {
            base.View();
            Console.Write(text);
        }

        public virtual void Create()
        {
            View("Imie: ");
            Name = Console.ReadLine();
            View("Nazwisko: ");
            Surname = Console.ReadLine();
            View("Login: ");
            Login = Console.ReadLine();
            View("Haslo: ");
            Password = Console.ReadLine();
        }
    }
}
