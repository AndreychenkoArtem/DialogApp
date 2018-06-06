using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.Localization
{
    public interface ILocalization
    {
        string MainLabel { get; set; }
        string LoginTextLabel { get; set; }
        string LoginTextButton { get; set; }
        string PasswordTextLabel { get; set; }
        string RegistrationTextButton { get; set; }
    }
}
