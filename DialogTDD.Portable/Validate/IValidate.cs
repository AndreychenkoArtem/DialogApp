using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.Validate
{
    public interface IValidate
    {
        string ValidateLogin(string login);
        string ValidatePassword(string password);
    }
}
