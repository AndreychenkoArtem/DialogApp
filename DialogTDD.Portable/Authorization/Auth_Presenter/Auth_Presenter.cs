
using DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces;
using DialogTDD.Portable.Authorization.Auth_View.Interfaces;
using DialogTDD.Portable.Localization;
using DialogTDD.Portable.Router.Interfaces;
using System;


namespace DialogTDD.Portable.Authorization.Auth_Presenter
{
    public class Auth_Presenter : IAuth_Presenter
    {
        public event Action OnSignInPressed;
        public event Action OnRegistrationPressed;
        public event Action OnLocalizationChangePressed;

        private ILocalization _localization;
        private IRouter _router;
        private IAuth_View _auth_View;

        public ILocalization localization { get => _localization; }
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
            throw new NotImplementedException();
            //if (localization)
            //{
            //    _localization = new LocalizationEn();
                
            //}
            //else
            //{
            //    _localization = new LocalizationRu();
            //}
            //SetLocalization(_localization);
        }

        private void _auth_View_OnRegistrationClick()
        {
            throw new NotImplementedException();
            //OnRegistrationPressed?.Invoke();
        }

        private void _auth_View_OnSignInClick(string login, string password)
        {
            throw new NotImplementedException();
           //OnSignInPressed?.Invoke();
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

        private void SetLocalization(ILocalization localization)
        {
            throw new NotImplementedException();
            //_auth_View.SetMainLabelText(localization.MainLabel);
            //_auth_View.SetLabelLoginText(localization.LoginTextLabel);
            //_auth_View.SetLabelPasswordText(localization.PasswordTextLabel);
            //_auth_View.SetButtonSignInText(localization.LoginTextButton);
            //_auth_View.SetButtonRegistrationText(localization.RegistrationTextButton);
        }
    }
}
