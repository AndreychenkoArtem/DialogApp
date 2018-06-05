
using DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces;
using DialogTDD.Portable.Authorization.Auth_View.Interfaces;
using DialogTDD.Portable.Router.Interfaces;
using System;


namespace DialogTDD.Portable.Authorization.Auth_Presenter
{
    public class Auth_Presenter : IAuth_Presenter
    {
        public event Action OnSignInPressed;
        public event Action OnRegistrationPressed;
        public event Action OnLocalizationChangePressed;

        private IRouter _router;
        private IAuth_View _auth_View;

        public IRouter Router { get => _router; set => _router = value; }
        public IAuth_View Auth_View { get => _auth_View; set => _auth_View = value; }

        public Auth_Presenter(IRouter router, IAuth_View auth_View)
        {
           throw new NotImplementedException();
            //_router = router ?? throw new ArgumentNullException();
            //_auth_View = auth_View ?? throw new ArgumentNullException();

            //_auth_View.OnSignInClick += _auth_View_OnSignInClick;
            //_auth_View.OnRegistrationClick += _auth_View_OnRegistrationClick;
            //_auth_View.ChangeLocalizationClick += _auth_View_ChangeLocalizationClick;
        }

        private void _auth_View_ChangeLocalizationClick(bool localization)
        {
            //throw new NotImplementedException();
            switch (localization)
            {
                case true:
                    _auth_View.SetButtonRegistrationText("Регистрация");
                    _auth_View.SetButtonSignInText("Вход");
                    _auth_View.SetLabelLoginText("Логин");
                    _auth_View.SetLabelPasswordText("Пароль");
                    break;
                case false:
                    _auth_View.SetButtonRegistrationText("Registration");
                    _auth_View.SetButtonSignInText("Sign In");
                    _auth_View.SetLabelLoginText("Login");
                    _auth_View.SetLabelPasswordText("Password");
                    break;
            }

        }

        private void _auth_View_OnRegistrationClick()
        {
            throw new NotImplementedException();
            //OnRegistrationPressed?.Invoke();
        }

        private void _auth_View_OnSignInClick(string arg1, string arg2)
        {
            throw new NotImplementedException();
           // OnSignInPressed?.Invoke();
        }

        public void GoToChat()
        {
            throw new NotImplementedException();
           // Router.GoChatPage();
        }

        public void GoToRegistration()
        {
            throw new NotImplementedException();
            //Router.GoRegistrationPage();
        }
    }
}
