using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using DialogTDD.Portable.Authorization.Auth_View.Interfaces;
using DialogTDD.Portable.Router.Interfaces;
using DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces;
using DialogTDD.Portable.Authorization.Auth_Presenter;

namespace DialogTDD.Test.Authorization_Test.Presenter_Test
{
    
    [TestFixture]
    public class Auth_Presenter_Test
    {
        [Test]
        public void Constructor_Test_NotNull()
        {
            Mock<IAuth_View> mockAuth_View = new Mock<IAuth_View>(MockBehavior.Strict);
            Mock<IRouter> mockRouter = new Mock<IRouter>(MockBehavior.Strict);
            Assert.DoesNotThrow(() =>
            {
                IAuth_Presenter auth_Presenter = new Auth_Presenter(mockRouter.Object, mockAuth_View.Object);
            });
        }

        [Test]
        public void Constructor_Test_Null()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                IAuth_Presenter auth_Presenter = new Auth_Presenter(null, null);
            });
        }

        [Test]
        public void GoToChat_Test()
        {
            Mock<IAuth_View> mockAuth_View = new Mock<IAuth_View>(MockBehavior.Strict);
            Mock<IRouter> mockRouter = new Mock<IRouter>(MockBehavior.Strict);

            IAuth_Presenter auth_Presenter = new Auth_Presenter(mockRouter.Object, mockAuth_View.Object);

            mockRouter.Setup(a => a.GoChatPage());

            auth_Presenter.Auth_View = mockAuth_View.Object;
            auth_Presenter.GoToChat();

            mockRouter.Verify(a => a.GoChatPage(), Times.Once);

        }

        [Test]
        public void GoToRegistration_Test()
        {
            Mock<IAuth_View> mockAuth_View = new Mock<IAuth_View>(MockBehavior.Strict);
            Mock<IRouter> mockRouter = new Mock<IRouter>(MockBehavior.Strict);

            IAuth_Presenter auth_Presenter = new Auth_Presenter(mockRouter.Object, mockAuth_View.Object);

            mockRouter.Setup(a => a.GoRegistrationPage());

            auth_Presenter.Auth_View = mockAuth_View.Object;
            auth_Presenter.GoToChat();

            mockRouter.Verify(a => a.GoRegistrationPage(), Times.Once);

        }

    }
}
