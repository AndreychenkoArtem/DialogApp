using DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces;
using DialogTDD.Portable.Data.Interfaces;

namespace DialogTDD.Portable.Authorization.Auth_Interactor.Interfaces
{
    public interface IAuth_Interactor
    {
        IAuth_Presenter Auth_Presenter { set; }

        void SignInPressed(string login, string password); //Test+
        void RegistrationPressed(); //Test+

       // IAuth_Entity GetDataFromUser(string login, string password);

    }
}
