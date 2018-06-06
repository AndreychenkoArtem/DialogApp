using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.Localization
{
    public class LocalizationRu : ILocalization
    {
        private string _mainLabel;
        private string _loginTextLabel;
        private string _loginTextButton;
        private string _passwordTextLabel;
        private string _registrationTextButton;

        public LocalizationRu()
        {
            SetLocalizationRu("Авторизация", "Логин", "Вход", "Пароль", "Зарегистрироваться");
        }

        public string MainLabel { get => _mainLabel; set => _mainLabel = value; }
        public string LoginTextLabel { get => _loginTextLabel; set => _loginTextLabel = value; }
        public string LoginTextButton { get => _loginTextButton; set => _loginTextButton = value; }
        public string PasswordTextLabel { get => _passwordTextLabel; set => _passwordTextLabel = value; }
        public string RegistrationTextButton { get => _registrationTextButton; set => _registrationTextButton = value; }

        public void SetLocalizationRu(string mainLabel, string loginTextLabel, string loginTextButton, string passwordTextLabel, string registrationTextButton)
        {
            _mainLabel = mainLabel;
            _loginTextLabel = loginTextLabel;
            _loginTextButton=loginTextButton;
            _passwordTextLabel = passwordTextLabel;
            _registrationTextButton = registrationTextButton;
        }

       
    }
}
