using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using DialogTDD.Portable.Authorization.Auth_View.Interfaces;
using DialogTDD.Portable.Router.Interfaces;
using DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces;
using DialogTDD.Portable.Authorization.Auth_Presenter;
using DialogTDD.Portable.Localization;
using System.Reflection;

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
            auth_Presenter.GoToRegistration();
            mockRouter.Verify(a => a.GoRegistrationPage(), Times.Once);

        }

        [Test]
        public void OnRegistrationPressed_Test()
        {
            Mock<IAuth_View> mockAuth_View = new Mock<IAuth_View>(MockBehavior.Strict);
            Mock<IRouter> mockRouter = new Mock<IRouter>(MockBehavior.Strict);

            IAuth_Presenter auth_Presenter = new Auth_Presenter(mockRouter.Object, mockAuth_View.Object);

            mockRouter.Setup(a => a.GoRegistrationPage());
            mockAuth_View.Raise(a => a.OnRegistrationClick+=null);
            auth_Presenter.GoToRegistration();
            mockRouter.Verify(a => a.GoRegistrationPage(), Times.Once);

        }

        //Узнать как проверить вызывается ли приватный метод в приватном методе!!!
        //[Test]
        //public void OnLocalizationChangePressed_Test()
        //{
        //    Mock<IAuth_View> mockAuth_View = new Mock<IAuth_View>(MockBehavior.Strict);
        //    Mock<ILocalization> mockLocalization = new Mock<ILocalization>(MockBehavior.Loose);
        //    Mock<IRouter> mockRouter = new Mock<IRouter>(MockBehavior.Strict);

        //    IAuth_Presenter auth_Presenter = new Auth_Presenter(mockRouter.Object, mockAuth_View.Object);

        //    mockAuth_View.Raise(a => a.ChangeLocalizationClick += null);

        //    auth_Presenter.Localization = mockLocalization.Object;

        //    object[] obj = new object[]
        //    {
        //        mockLocalization.Object
        //    };
        //    MethodInfo localChange = typeof(Auth_Presenter).GetMethod("SetLocalization", BindingFlags.Instance | BindingFlags.NonPublic);
        //    localChange.Invoke(auth_Presenter, obj);


        //    mockAuth_View.Verify(a => a.SetMainLabelText(It.IsAny<string>()), Times.Once);

        //}

        [Test]
        public void SetMainLabelText_test()
        {
            Mock<IAuth_View> mockAuth_View = new Mock<IAuth_View>(MockBehavior.Strict);
            Mock<IRouter> mockRouter = new Mock<IRouter>(MockBehavior.Strict);
            Mock<ILocalization> mockLocalization = new Mock<ILocalization>(MockBehavior.Loose);
            IAuth_Presenter auth_Presenter = new Auth_Presenter(mockRouter.Object, mockAuth_View.Object);

            mockAuth_View.Setup(a => a.SetMainLabelText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetLabelLoginText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetLabelPasswordText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetButtonSignInText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetButtonRegistrationText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetExeptionMessage(It.IsAny<string>()));

            auth_Presenter.Localization = mockLocalization.Object;
            object[] obj = new object[]
            {
                mockLocalization.Object
            };
            MethodInfo localChange = typeof(Auth_Presenter).GetMethod("SetLocalization", BindingFlags.Instance | BindingFlags.NonPublic);
            localChange.Invoke(auth_Presenter, obj);

            mockAuth_View.Verify(a => a.SetMainLabelText(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void SetLabelLoginText_test()
        {
            Mock<IAuth_View> mockAuth_View = new Mock<IAuth_View>(MockBehavior.Strict);
            Mock<IRouter> mockRouter = new Mock<IRouter>(MockBehavior.Strict);
            Mock<ILocalization> mockLocalization = new Mock<ILocalization>(MockBehavior.Loose);
            IAuth_Presenter auth_Presenter = new Auth_Presenter(mockRouter.Object, mockAuth_View.Object);

            mockAuth_View.Setup(a => a.SetMainLabelText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetLabelLoginText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetLabelPasswordText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetButtonSignInText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetButtonRegistrationText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetExeptionMessage(It.IsAny<string>()));

            auth_Presenter.Localization = mockLocalization.Object;

            object[] obj = new object[]
            {
                mockLocalization.Object
            };
            MethodInfo localChange = typeof(Auth_Presenter).GetMethod("SetLocalization", BindingFlags.Instance | BindingFlags.NonPublic);
            localChange.Invoke(auth_Presenter, obj);

            mockAuth_View.Verify(a => a.SetLabelLoginText(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void SetLabelPasswordText_test()
        {
            Mock<IAuth_View> mockAuth_View = new Mock<IAuth_View>(MockBehavior.Strict);
            Mock<IRouter> mockRouter = new Mock<IRouter>(MockBehavior.Strict);
            Mock<ILocalization> mockLocalization = new Mock<ILocalization>(MockBehavior.Loose);
            IAuth_Presenter auth_Presenter = new Auth_Presenter(mockRouter.Object, mockAuth_View.Object);

            mockAuth_View.Setup(a => a.SetMainLabelText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetLabelLoginText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetLabelPasswordText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetButtonSignInText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetButtonRegistrationText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetExeptionMessage(It.IsAny<string>()));

            auth_Presenter.Localization = mockLocalization.Object;

            object[] obj = new object[]
            {
                mockLocalization.Object
            };
            MethodInfo localChange = typeof(Auth_Presenter).GetMethod("SetLocalization", BindingFlags.Instance | BindingFlags.NonPublic);
            localChange.Invoke(auth_Presenter, obj);

            mockAuth_View.Verify(a => a.SetLabelPasswordText(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void SetButtonSignInText_test()
        {
            Mock<IAuth_View> mockAuth_View = new Mock<IAuth_View>(MockBehavior.Strict);
            Mock<IRouter> mockRouter = new Mock<IRouter>(MockBehavior.Strict);
            Mock<ILocalization> mockLocalization = new Mock<ILocalization>(MockBehavior.Loose);
            IAuth_Presenter auth_Presenter = new Auth_Presenter(mockRouter.Object, mockAuth_View.Object);

            mockAuth_View.Setup(a => a.SetMainLabelText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetLabelLoginText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetLabelPasswordText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetButtonSignInText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetButtonRegistrationText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetExeptionMessage(It.IsAny<string>()));

            auth_Presenter.Localization = mockLocalization.Object;

            object[] obj = new object[]
            {
                mockLocalization.Object
            };
            MethodInfo localChange = typeof(Auth_Presenter).GetMethod("SetLocalization", BindingFlags.Instance | BindingFlags.NonPublic);
            localChange.Invoke(auth_Presenter, obj);

            mockAuth_View.Verify(a => a.SetButtonSignInText(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void SetButtonRegistrationText_test()
        {
            Mock<IAuth_View> mockAuth_View = new Mock<IAuth_View>(MockBehavior.Strict);
            Mock<IRouter> mockRouter = new Mock<IRouter>(MockBehavior.Strict);
            Mock<ILocalization> mockLocalization = new Mock<ILocalization>(MockBehavior.Loose);
            IAuth_Presenter auth_Presenter = new Auth_Presenter(mockRouter.Object, mockAuth_View.Object);

            mockAuth_View.Setup(a => a.SetMainLabelText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetLabelLoginText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetLabelPasswordText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetButtonSignInText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetButtonRegistrationText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetExeptionMessage(It.IsAny<string>()));

            auth_Presenter.Localization = mockLocalization.Object;

            object[] obj = new object[]
            {
                mockLocalization.Object
            };
            MethodInfo localChange = typeof(Auth_Presenter).GetMethod("SetLocalization", BindingFlags.Instance | BindingFlags.NonPublic);
            localChange.Invoke(auth_Presenter, obj);

            mockAuth_View.Verify(a => a.SetButtonRegistrationText(It.IsAny<string>()), Times.Once);
        }
    }
}
