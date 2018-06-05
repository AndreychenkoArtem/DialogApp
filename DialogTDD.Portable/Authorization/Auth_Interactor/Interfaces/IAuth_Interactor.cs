using DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogTDD.Portable.Authorization.Auth_Interactor.Interfaces
{
    public interface IAuth_Interactor
    {
        IAuth_Presenter Auth_Presenter { get; set; }

        void SignInPressed();
        void RegistrationPressed();
    }
}
