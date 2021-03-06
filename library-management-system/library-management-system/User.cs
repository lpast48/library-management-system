﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    class User
        : Info
    {
        public string Name;
        public string Surname;
        public string Login;
        private string Password;

        public User(string name, string surname, string login, string password)
        {
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
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

        public bool CheckLogin(string[] inArray)
        {
            if (inArray.Length != 2)
            {
                return false;
            }

            if (inArray[0].CompareTo(Login)==0 &&
                inArray[1].CompareTo(Password)==0)
            {
                return true;
            }
            return false;
        }
    }
}
