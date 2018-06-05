using DialogTDD.Portable.Authorization.Auth_View.Interfaces;
using DialogTDD.Portable.Router.Interfaces;
using System;


namespace DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces
{
    public interface IAuth_Presenter
    {
        event Action OnSignInPressed;
        event Action OnRegistrationPressed;
        event Action OnLocalizationChangePressed;

        IRouter Router { get; set; }
        IAuth_View Auth_View { get; set; }

        void GoToChat(); //Test+
        void GoToRegistration(); //Test+
    }
}
