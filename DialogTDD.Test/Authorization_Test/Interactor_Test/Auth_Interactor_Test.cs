using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces;
using DialogTDD.Portable.Authorization.Auth_Interactor.Interfaces;
using DialogTDD.Portable.Authorization.Auth_Interactor;
using DialogTDD.Portable.Data.Interfaces;

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
        public void SignInPressed_Test()
        {
            Mock<IDataWrap> mockDataWrap = new Mock<IDataWrap>(MockBehavior.Strict);
            Mock<IAuth_Presenter> mockAuth_Presenter = new Mock<IAuth_Presenter>(MockBehavior.Strict);

            IAuth_Interactor auth_Interactor = new Auth_Interactor(mockDataWrap.Object);
            mockAuth_Presenter.Setup(a => a.GoToChat());
            auth_Interactor.SignInPressed();
            mockAuth_Presenter.Verify(a => a.GoToChat(), Times.Once);
        }

        [Test]
        public void RegistrationPressed_Test()
        {
            Mock<IDataWrap> mockDataWrap = new Mock<IDataWrap>(MockBehavior.Strict);
            Mock<IAuth_Presenter> mockAuth_Presenter = new Mock<IAuth_Presenter>(MockBehavior.Strict);

            IAuth_Interactor auth_Interactor = new Auth_Interactor(mockDataWrap.Object);

            mockAuth_Presenter.Setup(a => a.GoToRegistration());
            auth_Interactor.RegistrationPressed();
            mockAuth_Presenter.Verify(a => a.GoToRegistration(), Times.Once);
        }
    }
}
