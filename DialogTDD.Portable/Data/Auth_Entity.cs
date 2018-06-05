using DialogTDD.Portable.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.Data
{
    public class Auth_Entity:IAuth_Entity 
    {
        private string _login;
        private string _password;

        public Auth_Entity(string login, string password)
        {
            _login = login;
            _password = password;
        }

        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
