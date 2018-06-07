using DialogTDD.IOS.Router;
using DialogTDD.Portable.Authorization.Auth_Interactor;
using DialogTDD.Portable.Authorization.Auth_Interactor.Interfaces;
using DialogTDD.Portable.Authorization.Auth_Presenter;
using DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces;
using DialogTDD.Portable.Authorization.Auth_View.Interfaces;
using DialogTDD.Portable.Data;
using DialogTDD.Portable.Data.Interfaces;
using DialogTDD.Portable.Router.Interfaces;
using System;

using UIKit;

namespace DialogTDD.IOS
{
    public partial class ViewController : UIViewController, IAuth_View
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public event Action<string, string> OnSignInClick;
        public event Action OnRegistrationClick;
        public event Action<bool> ChangeLocalizationClick;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            IDataWrap dataWrap = new DataWrap();
            IRouter router = new IOSRouter(NavigationController);
            IAuth_Presenter auth_Presenter = new Auth_Presenter(router, this);
            auth_Presenter.Router = router;

            IAuth_Interactor auth_Intarector = new Auth_Interactor(dataWrap);
            auth_Intarector.Auth_Presenter = auth_Presenter;

            signInButton.TouchUpInside += SignInButton_TouchUpInside;
            registrationButton.TouchUpInside += RegistrationButton_TouchUpInside;
            localizationChangeButton.TouchUpInside += LocalizationChangeButton_TouchUpInside;
        }

        private void LocalizationChangeButton_TouchUpInside(object sender, EventArgs e)
        {
            var click = (UISwitch)sender;
            ChangeLocalizationClick?.Invoke(click.On);//Проверить
        }

        private void RegistrationButton_TouchUpInside(object sender, EventArgs e)
        {
            OnRegistrationClick?.Invoke();
        }

        private void SignInButton_TouchUpInside(object sender, EventArgs e)
        {
            string login = loginEditText.Text;
            string password = passwordEditText.Text;
            OnSignInClick?.Invoke(login, password);
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }



        public void SetMainLabelText(string mainLabel)
        {
            mainLabelText.Text = mainLabel;
        }

        public void SetLabelLoginText(string labelLogin)
        {
            loginLabelField.Text = labelLogin;
        }

        public void SetLabelPasswordText(string LabelPassword)
        {
            passwordLabelField.Text = LabelPassword;
        }

        public void SetButtonSignInText(string buttonSignInText)
        {
            signInButton.SetTitle(buttonSignInText, UIControlState.Normal);
        }

        public void SetButtonRegistrationText(string buttonRegistrationText)
        {
            registrationButton.SetTitle(buttonRegistrationText, UIControlState.Normal);
        }

        public void SetExeptionMessage(string message)
        {
            exceptionLabel.Text = message;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            exceptionLabel.Text = "";
        }
    }
}