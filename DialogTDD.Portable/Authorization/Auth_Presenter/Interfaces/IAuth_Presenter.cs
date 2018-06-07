using DialogTDD.Portable.Authorization.Auth_View.Interfaces;
using DialogTDD.Portable.Localization;
using DialogTDD.Portable.Router.Interfaces;
using System;


namespace DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces
{
    public interface IAuth_Presenter
    {
        event Action<string, string> OnSignInPressed;
        event Action OnRegistrationPressed;
        

        IRouter Router { get; set; }
        IAuth_View Auth_View { get; set; }
        ILocalization Localization { set; }

        void GoToChat(); //Test+
        void GoToRegistration(); //Test+
        void ErrorValidation();
    }
}
