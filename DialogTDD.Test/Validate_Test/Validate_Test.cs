using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using DialogTDD.Portable.Validate;

namespace DialogTDD.Test.Validate_Test
{
    [TestFixture]
    public class Validate_Test
    {
        IValidate validate = new ValidateLoginPassword();
        
        /// <summary>
        /// Login lengh must to be min: 3 , max: 16
        /// Must contain at least one letter 
        /// Can't start with digit
        /// </summary>
        /// <param name="login"></param>
        /// <returns>result</returns>

        [TestCase("a", ExpectedResult = ValidateLoginExeption.ExeptionLoginToShort)]//+
        [TestCase(" с ", ExpectedResult = ValidateLoginExeption.ExeptionLoginToShort)]
        [TestCase("ab", ExpectedResult = ValidateLoginExeption.ExeptionLoginToShort)]
        [TestCase("123123123ab", ExpectedResult = ValidateLoginExeption.ExeptionCannotStartWithDigit)]//+
        [TestCase("3ArteM", ExpectedResult = ValidateLoginExeption.ExeptionCannotStartWithDigit)]
        [TestCase("a213b123", ExpectedResult = ValidateLoginExeption.Correct)]//+
        [TestCase("artem9123", ExpectedResult = ValidateLoginExeption.Correct)]
        [TestCase("artem", ExpectedResult = ValidateLoginExeption.Correct)]
        [TestCase("Artem", ExpectedResult = ValidateLoginExeption.Correct)]
        [TestCase(" ARTEM ", ExpectedResult = ValidateLoginExeption.Correct)]
        [TestCase("artem_Fatal", ExpectedResult = ValidateLoginExeption.ExeptionContainsUncorrectSymbol)]
        [TestCase("-artem", ExpectedResult = ValidateLoginExeption.ExeptionUncorrectFirstOrLastSymbol)]//+
        [TestCase("-artem~", ExpectedResult = ValidateLoginExeption.ExeptionUncorrectFirstOrLastSymbol)]
        [TestCase("'artem", ExpectedResult = ValidateLoginExeption.ExeptionUncorrectFirstOrLastSymbol)]
        [TestCase("a#r't~e%m", ExpectedResult = ValidateLoginExeption.ExeptionContainsUncorrectSymbol)]//+
        [TestCase("a=r/t?e*m", ExpectedResult = ValidateLoginExeption.ExeptionContainsUncorrectSymbol)]
        [TestCase("jfnvrfskryvndhcnrhdbvsdfbadbf", ExpectedResult = ValidateLoginExeption.ExeptionLoginToLong)]//+
        [TestCase("Artem rulit", ExpectedResult = ValidateLoginExeption.ExeptionContainsSpaceInLogin)] //+
        [TestCase("кукуептаа", ExpectedResult = ValidateLoginExeption.ExeptionNonEnglishLogin)]//+

        public ValidateLoginExeption Validate_login(string login)
        {
            return validate.ValidateLogin(login);
        }
        //[Test]
        //public void Validate_login_Exeption(string login)
        //{
        //    Assert.DoesNotThrow(() =>
        //    {
        //        validate.ValidateLogin(login);
        //    });
        //}
        //[Test]
        //public void Validate_login_NotNull(string login)
        //{
        //    Assert.Throws<ArgumentNullException>(() =>
        //    {
        //        validate.ValidateLogin(null);
        //    });
        //}

        /// <summary>
        /// length min: 6, max: 128
        ///  Must contain at least one letter and digit
        /// </summary>
        /// <param name="password"></param>
        /// <returns>result</returns>

        [TestCase("a", ExpectedResult = ValidatePasswordExeption.ExeptionPasswordToShort)]
        [TestCase("  acv  ", ExpectedResult = ValidatePasswordExeption.ExeptionPasswordToShort)]
        [TestCase("mfyvndbrcbmfyvndbrcbmfyvndbrcbmfyvndbrcbmfyvndbrcbmfyvndbrcbmfyvndbrcbmfyvndbrcbmfyvndbrcbmfyvndbrcbmfyvndbrcbmfyvndbrcbmfyvndbrcb",
            ExpectedResult = ValidatePasswordExeption.ExeptionPasswordToLong)]
        [TestCase("fasdf dfg", ExpectedResult = ValidatePasswordExeption.ExeptionContainsSpaceInPassword)]
        [TestCase("a%$#ndki234", ExpectedResult = ValidatePasswordExeption.Correct)]
        [TestCase("123Hi321", ExpectedResult = ValidatePasswordExeption.Correct)]
        [TestCase("#2#FataLL#%23", ExpectedResult = ValidatePasswordExeption.Correct)]
        [TestCase("HelloMyFriend123", ExpectedResult = ValidatePasswordExeption.Correct)]
        [TestCase("HelloMyFriend", ExpectedResult = ValidatePasswordExeption.ExeptionMustContainAtLeastOneLetterAndDigit)]
        [TestCase("Hello'**MyFriend$@", ExpectedResult = ValidatePasswordExeption.ExeptionMustContainAtLeastOneLetterAndDigit)]
        [TestCase("##$%$%#%$%#", ExpectedResult = ValidatePasswordExeption.ExeptionMustContainAtLeastOneLetterAndDigit)]
        public ValidatePasswordExeption Validate_password(string password)
        {
            return validate.ValidatePassword(password);
        }
        //[Test]
        //public void Validate_password_Exeption(string password)
        //{
        //    Assert.DoesNotThrow(() =>
        //    {
        //        validate.ValidatePassword(password);
        //    });
        //}
        //[Test]
        //public void Validate_password_NotNull(string password)
        //{
        //    Assert.Throws<ArgumentNullException>(() =>
        //    {
        //        validate.ValidatePassword(null);
        //    });
        //}
    }
}
