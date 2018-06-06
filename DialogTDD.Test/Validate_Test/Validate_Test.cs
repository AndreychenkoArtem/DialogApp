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
        Validate validate = new Validate();
        
        /// <summary>
        /// Login lengh must to be min: 3 , max: 16
        /// Must contain at least one letter 
        /// Can't start with digit
        /// </summary>
        /// <param name="login"></param>
        /// <returns>result</returns>

        [TestCase("a", ExpectedResult ="ExeptionLoginToShort")]
        [TestCase(" a ", ExpectedResult = "ExeptionLoginToShort")]
        [TestCase("ab", ExpectedResult = "ExeptionLoginToShort")]
        [TestCase("123123123ab", ExpectedResult = "ExeptionCan'tStartWithDigit")]
        [TestCase("3ArteM", ExpectedResult = "ExeptionCan'tStartWithDigit")]
        [TestCase("a213b123", ExpectedResult = "Correct")]
        [TestCase("artem9123", ExpectedResult = "Correct")]
        [TestCase("artem", ExpectedResult = "Correct")]
        [TestCase("Artem", ExpectedResult = "Correct")]
        [TestCase("ARTEM", ExpectedResult = "Correct")]
        [TestCase("artem_Fatal", ExpectedResult = "Correct")]
        [TestCase("-artem", ExpectedResult = "ExeptionUncorrectFirstOrLastSymbol")]
        [TestCase("-artem~", ExpectedResult = "ExeptionUncorrectFirstOrLastSymbol")]
        [TestCase("'artem", ExpectedResult = "ExeptionUncorrectFirstOrLastSymbol")]
        [TestCase("a#r't~e%m", ExpectedResult = "ExeptionContainsUncorrectSymbol")]
        [TestCase("a=r/t?e*m", ExpectedResult = "ExeptionContainsUncorrectSymbol")]
        [TestCase("jfnvrfskryvndhcnrhdbv", ExpectedResult = "ExeptionLoginToLong")]
        [TestCase("Artem rulit", ExpectedResult = "ExeptionContainsSpaceInLogin")]
        [TestCase("Здарова", ExpectedResult = "ExeptionNonEnglishLogin")]

        public string Validate_login(string login)
        {
            return validate.ValidateLogin(login);
        }
        [Test]
        public void Validate_login_Exeption(string login)
        {
            Assert.DoesNotThrow(() =>
            {
                validate.ValidateLogin(login);
            });
        }
        [Test]
        public void Validate_login_NotNull(string login)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                validate.ValidateLogin(null);
            });
        }

        /// <summary>
        /// length min: 6, max: 128
        ///  Must contain at least one letter and digit
        /// </summary>
        /// <param name="password"></param>
        /// <returns>result</returns>

        [TestCase("a", ExpectedResult = "ExeptionPasswordToShort")]
        [TestCase("  acv  ", ExpectedResult = "ExeptionPasswordToShort")]
        [TestCase("fasdf dfg", ExpectedResult = "ExeptionContainsSpaceInPassword")]
        [TestCase("a%$#ndki234", ExpectedResult = "Correct")]
        [TestCase("123Hi321", ExpectedResult = "Correct")]
        [TestCase("#2#FataLL#%23", ExpectedResult = "Correct")]
        [TestCase("HelloMyFriend123", ExpectedResult = "Correct")]
        [TestCase("HelloMyFriend", ExpectedResult = "ExeptionMustContainAtLeastOneLetterAndDigit")]
        [TestCase("Hello'**MyFriend$@", ExpectedResult = "ExeptionMustContainAtLeastOneLetterAndDigit")]
        [TestCase("##$%$%#%$%#", ExpectedResult = "ExeptionMustContainAtLeastOneLetterAndDigit")]
        public string Validate_password(string password)
        {
            return validate.ValidatePassword(password);
        }
        [Test]
        public void Validate_password_Exeption(string password)
        {
            Assert.DoesNotThrow(() =>
            {
                validate.ValidatePassword(password);
            });
        }
        [Test]
        public void Validate_password_NotNull(string password)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                validate.ValidatePassword(null);
            });
        }
    }
}
