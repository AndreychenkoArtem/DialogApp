using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces;
using DialogTDD.Portable.Authorization.Auth_Interactor.Interfaces;
using DialogTDD.Portable.Authorization.Auth_Interactor;
using DialogTDD.Portable.Data.Interfaces;
using System.Reflection;
using DialogTDD.Portable.Data;
using DialogTDD.Portable.Authorization.Auth_View.Interfaces;

namespace DialogTDD.Test.Authorization_Test.Interactor_Test
{
    /// <summary>
    /// Summary description for Auth_Interactor_Test
    /// </summary>
    [TestFixture]
    public class Auth_Interactor_Test
    {

        [Test]
        public void Constructor_Test()
        {
            Mock<IDataWrap> mockDataWrap = new Mock<IDataWrap>(MockBehavior.Strict);
            Assert.DoesNotThrow(() =>
            {
                IAuth_Interactor auth_Interactor = new Auth_Interactor(mockDataWrap.Object);
            });
        }

        [Test]
        public void Constructor_Test_NotNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                IAuth_Interactor auth_Interactor = new Auth_Interactor(null);
            });
        }

        [Test]
        public void RegistrationPressed_Test()
        {
            Mock<IDataWrap> mockDataWrap = new Mock<IDataWrap>(MockBehavior.Strict);
            Mock<IAuth_Presenter> mockAuth_Presenter = new Mock<IAuth_Presenter>(MockBehavior.Strict);

            IAuth_Interactor auth_Interactor = new Auth_Interactor(mockDataWrap.Object);

            mockAuth_Presenter.Setup(a => a.GoToRegistration());
            auth_Interactor.Auth_Presenter = mockAuth_Presenter.Object;
            auth_Interactor.RegistrationPressed();
            mockAuth_Presenter.Verify(a => a.GoToRegistration(), Times.Once);
        }

        [Test]
        public void OnSignInPressed_Event_Test_validation_True()
        {
            string login = "admin";
            string password = "admin123";
            Mock<IDataWrap> mockDataWrap = new Mock<IDataWrap>(MockBehavior.Strict);
            Mock<IAuth_Presenter> mockAuth_Presenter = new Mock<IAuth_Presenter>(MockBehavior.Strict);

            IAuth_Interactor auth_Interactor = new Auth_Interactor(mockDataWrap.Object);

            mockAuth_Presenter.Setup(a => a.GoToChat());
            mockAuth_Presenter.Raise(a => a.OnSignInPressed += null);

            auth_Interactor.Auth_Presenter = mockAuth_Presenter.Object;

            object[] obj = new object[]
            {
                login, password
            };
            MethodInfo validate = typeof(Auth_Interactor).GetMethod("Validation", BindingFlags.Instance | BindingFlags.NonPublic);
            validate.Invoke(auth_Interactor, obj);
            auth_Interactor.SignInPressed(login, password);
            mockAuth_Presenter.Verify(a => a.GoToChat(), Times.Once);
        }

        [Test]
        public void OnSignInPressed_Event_Test_validation_False()
        {
            string login = "123admin";
            string password = "admin123";
            Mock<IDataWrap> mockDataWrap = new Mock<IDataWrap>(MockBehavior.Strict);
            Mock<IAuth_Presenter> mockAuth_Presenter = new Mock<IAuth_Presenter>(MockBehavior.Strict);

            IAuth_Interactor auth_Interactor = new Auth_Interactor(mockDataWrap.Object);

            mockAuth_Presenter.Setup(a => a.ErrorValidation());
            mockAuth_Presenter.Raise(a => a.OnSignInPressed += null);

            auth_Interactor.Auth_Presenter = mockAuth_Presenter.Object;

            object[] obj = new object[]
            {
                login, password
            };
            MethodInfo validate = typeof(Auth_Interactor).GetMethod("Validation", BindingFlags.Instance | BindingFlags.NonPublic);
            validate.Invoke(auth_Interactor, obj);
            auth_Interactor.SignInPressed(login, password);
            mockAuth_Presenter.Verify(a => a.ErrorValidation(), Times.Once);
        }
    }
}
