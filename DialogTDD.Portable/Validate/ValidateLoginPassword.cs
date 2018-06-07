using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.Validate
{
    public class ValidateLoginPassword : IValidate
    {
        char[] arrayNumbers = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        char[] arraySymbolsFirstAndLast = new char[] { '!', '~', '`', '@', '"', '#', '№', '$', ';', '%', '^', ':',
            '&', '?', '*', '(', ')', '_', '-', '=', '+', '[', ']', '{', '}', '|', '/', '.', ',', ';', '\\', '\''};


        public ValidateLoginExeption ValidateLogin(string login)
        {

            if (login == null) { throw new ArgumentNullException(); }
            
            string workLogin = login.Trim(' ');
            
            if (workLogin.Length < 3)
            {
                return ValidateLoginExeption.ExeptionLoginToShort;
            }

            if (workLogin.Length > 16)
            {
                return ValidateLoginExeption.ExeptionLoginToLong;
            }

            for (int i = 0; i<arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] == workLogin[0])
                {
                    return ValidateLoginExeption.ExeptionCannotStartWithDigit;
                }
            }

            for(int i = 0; i<arraySymbolsFirstAndLast.Length; i++)
            {
                if (workLogin[0] == arraySymbolsFirstAndLast[i] || workLogin[workLogin.Length-1]== arraySymbolsFirstAndLast[i])
                {
                    return ValidateLoginExeption.ExeptionUncorrectFirstOrLastSymbol;
                }
            }

            for (int i = 0; i < arraySymbolsFirstAndLast.Length; i++)
            {
                string prohibedChar = arraySymbolsFirstAndLast[i] + "";
                if (workLogin.Contains(prohibedChar))
                {
                    return ValidateLoginExeption.ExeptionContainsUncorrectSymbol;
                }
            }

            for (int i = 0; i < workLogin.Length; i++)
            {
                if(workLogin[i] == ' ')
                {
                    return ValidateLoginExeption.ExeptionContainsSpaceInLogin;
                }
            }

            for (int i = 0; i < workLogin.Length; i++)
            {
                if ((workLogin[i] >= 'a' && workLogin[i] <= 'z') || (workLogin[i] >= 'A' && workLogin[i] <= 'Z'))
                {
                    return ValidateLoginExeption.Correct;
                }
                return ValidateLoginExeption.ExeptionNonEnglishLogin;
            }

            if (workLogin == null)
            {
                return ValidateLoginExeption.ExeptionEnterLogin;
            }
            return ValidateLoginExeption.Correct;
        }





        public ValidatePasswordExeption ValidatePassword(string password)
        {
            string workPassword = password.Trim();

            if (workPassword.Length<6)
            {
                return ValidatePasswordExeption.ExeptionPasswordToShort;
            }

            if (workPassword.Length>128)
            {
                return ValidatePasswordExeption.ExeptionPasswordToLong;
            }

            for (int i = 0; i < workPassword.Length; i++)
            {
                if (workPassword[i] == ' ')
                {
                    return ValidatePasswordExeption.ExeptionContainsSpaceInPassword;
                }
            }

            

            bool containsDigit = false;
            bool containsLetter = false;

            for (int i = 0; i < workPassword.Length; i++)
            {
                if (char.IsDigit(workPassword[i]))
                {
                    containsDigit = true;
                }
                if (char.IsLetter(workPassword[i]))
                {
                    containsLetter = true;
                }
            }
            if (!containsDigit || !containsLetter)
            {
                return ValidatePasswordExeption.ExeptionMustContainAtLeastOneLetterAndDigit;
            }

            return ValidatePasswordExeption.Correct;
        }
    }
}
