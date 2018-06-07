using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.Validate
{
    public enum ValidateLoginExeption
    {
        ExeptionLoginToShort,
        ExeptionCannotStartWithDigit,
        Correct,
        ExeptionUncorrectFirstOrLastSymbol,
        ExeptionContainsUncorrectSymbol,
        ExeptionLoginToLong,
        ExeptionContainsSpaceInLogin,
        ExeptionNonEnglishLogin,
        ExeptionEnterLogin
    }
}
