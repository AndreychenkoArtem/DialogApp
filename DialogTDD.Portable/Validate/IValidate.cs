using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.Validate
{
    public interface IValidate
    {
        ValidateLoginExeption ValidateLogin(string login);
        ValidatePasswordExeption ValidatePassword(string password);
    }
}
