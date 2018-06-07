using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.Validate
{
    public enum ValidatePasswordExeption
    {
        ExeptionPasswordToShort,
        ExeptionPasswordToLong,
        ExeptionContainsSpaceInPassword,
        Correct,
        ExeptionMustContainAtLeastOneLetterAndDigit,
        ExeptionNonEnglishLogin
    }
}
