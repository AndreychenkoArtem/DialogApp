using NUnit.Framework;
using Moq;
using DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces;
using DialogTDD.Portable.Router.Interfaces;
using DialogTDD.Portable.Authorization.Auth_View.Interfaces;
using DialogTDD.Portable.Authorization.Auth_Presenter;
using System.Reflection;
using DialogTDD.Portable.Localization;

namespace DialogTDD.Test.Authorization_Test.Presenter_Test
{
    /// <summary>
    /// Summary description for Presenter_Localization_Test
    /// </summary>
    [TestFixture]
    public class Presenter_Localization_Test
    {
        [Test]
        public void SetLabelLoginText_Test()
        {
            Mock<IAuth_View> mockAuth_View = new Mock<IAuth_View>(MockBehavior.Strict);
            Mock<IRouter> mockRouter = new Mock<IRouter>(MockBehavior.Strict);

            IAuth_Presenter auth_Presenter = new Auth_Presenter(mockRouter.Object, mockAuth_View.Object);
            
            mockAuth_View.Setup(a => a.SetLabelLoginText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetLabelPasswordText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetButtonSignInText(It.IsAny<string>()));
            mockAuth_View.Setup(a => a.SetButtonRegistrationText(It.IsAny<string>()));

            //object[] answer = new object[]
            //{
            //    true
            //};
            //MethodInfo localChange = typeof(Auth_Presenter).GetMethod("_auth_View_ChangeLocalizationClick", BindingFlags.Instance | BindingFlags.NonPublic);
            //localChange.Invoke(auth_Presenter, answer);

        }
    }
}
