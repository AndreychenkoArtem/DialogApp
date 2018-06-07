
using DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces;
using DialogTDD.Portable.Authorization.Auth_View.Interfaces;
using DialogTDD.Portable.Localization;
using DialogTDD.Portable.Router.Interfaces;
using System;


namespace DialogTDD.Portable.Authorization.Auth_Presenter
{
    public class Auth_Presenter : IAuth_Presenter
    {
        public event Action<string, string> OnSignInPressed;
        public event Action OnRegistrationPressed;
      

        private ILocalization _localization;
        private IRouter _router;
        private IAuth_View _auth_View;

        public ILocalization Localization { set => _localization = value; }
        public IRouter Router { get => _router; set => _router = value; }
        public IAuth_View Auth_View { get => _auth_View; set => _auth_View = value; }

        public Auth_Presenter(IRouter router, IAuth_View auth_View)
        {
            _router = router ?? throw new ArgumentNullException();
            _auth_View = auth_View ?? throw new ArgumentNullException();

            _auth_View.OnSignInClick += _auth_View_OnSignInClick;
            _auth_View.OnRegistrationClick += _auth_View_OnRegistrationClick;
            _auth_View.ChangeLocalizationClick += _auth_View_ChangeLocalizationClick;
        }

        private void _auth_View_ChangeLocalizationClick(bool localization)
        {
            if (localization)
            {
                _localization = new LocalizationRu();
            }
            else
            {
                _localization = new LocalizationEn();
            }
            SetLocalization(_localization);
        }

        private void _auth_View_OnRegistrationClick()
        {
            OnRegistrationPressed?.Invoke();
        }

        private void _auth_View_OnSignInClick(string login, string password)
        {
           OnSignInPressed?.Invoke(login, password);
        }

        public void GoToChat()
        {
           Router.GoChatPage();
        }

        public void GoToRegistration()
        {
            Router.GoRegistrationPage();
        }

        private void SetLocalization(ILocalization localization)
        {
            _auth_View.SetMainLabelText(localization.MainLabel);
            _auth_View.SetLabelLoginText(localization.LoginTextLabel);
            _auth_View.SetLabelPasswordText(localization.PasswordTextLabel);
            _auth_View.SetButtonSignInText(localization.LoginTextButton);
            _auth_View.SetButtonRegistrationText(localization.RegistrationTextButton);
        }

        public void ErrorValidation()
        {
            _auth_View.SetExeptionMessage("Invalid Login or Password");
        }
    }
}
