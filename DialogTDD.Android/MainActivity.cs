using Android.App;
using Android.Widget;
using Android.OS;
using DialogTDD.Portable.Authorization.Auth_View.Interfaces;
using System;
using DialogTDD.Portable.Data.Interfaces;
using DialogTDD.Portable.Data;
using DialogTDD.Portable.Router.Interfaces;
using DialogTDD.Android.Router;
using DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces;
using DialogTDD.Portable.Authorization.Auth_Presenter;
using DialogTDD.Android.Views;
using DialogTDD.Portable.Authorization.Auth_Interactor.Interfaces;
using DialogTDD.Portable.Authorization.Auth_Interactor;

namespace DialogTDD.Android
{
    
    [Activity(Label = "DialogTDD.Android", MainLauncher = true)]
    public class MainActivity : Activity, IAuth_View
    {

        public event Action<string, string> OnSignInClick;
        public event Action OnRegistrationClick;
        public event Action<bool> ChangeLocalizationClick;

        public void SetButtonRegistrationText(string buttonRegistrationText)
        {
            Button registrationButton = FindViewById<Button>(Resource.Id.button_registration);
            registrationButton.Text = buttonRegistrationText;
            registrationButton.Invalidate();
        }

        public void SetButtonSignInText(string buttonSignInText)
        {
            Button signInButton = FindViewById<Button>(Resource.Id.button_signIn);
            signInButton.Text = buttonSignInText;
            signInButton.Invalidate();
        }

        public void SetExeptionMessage(string message)
        {
            TextView textViewExeption = FindViewById<TextView>(Resource.Id.textViewException);
            textViewExeption.Text = message;
            textViewExeption.Invalidate();
        }

        public void SetLabelLoginText(string labelLogin)
        {
            TextView loginLabel = FindViewById<TextView>(Resource.Id.textView_username);
            loginLabel.Text = labelLogin;
            loginLabel.Invalidate();
        }

        public void SetLabelPasswordText(string labelPassword)
        {
            TextView passwordLabel = FindViewById<TextView>(Resource.Id.textView_password);
            passwordLabel.Text = labelPassword;
            passwordLabel.Invalidate();
        }

        public void SetMainLabelText(string mainLabelText)
        {
            TextView mainLabel = FindViewById<TextView>(Resource.Id.textView_main);
            mainLabel.Text = mainLabelText;
            mainLabel.Invalidate();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //var loginWindowView = FindViewById<RelativeLayout>(Resource.Id.loginWindow);

            EditText loginEditTextWindow = FindViewById<EditText>(Resource.Id.editText_user);
            EditText passwordEditTextWindow = FindViewById<EditText>(Resource.Id.editText_password);
            Switch switchButton = FindViewById<Switch>(Resource.Id.change_localization);
            Button signInButton = FindViewById<Button>(Resource.Id.button_signIn);
            Button registrationButton = FindViewById<Button>(Resource.Id.button_registration);
            TextView mainLabel= FindViewById<TextView>(Resource.Id.textView_main);
            TextView loginLabel = FindViewById<TextView>(Resource.Id.textView_username);
            TextView passwordLabel= FindViewById<TextView>(Resource.Id.textView_password);
            TextView textViewExeption = FindViewById<TextView>(Resource.Id.textViewException);


            IDataWrap dataWrap = new DataWrap();
            IRouter router = new AndroidRouter(this);
            IAuth_Presenter auth_Presenter = new Auth_Presenter(router, this);
            auth_Presenter.Router = router;

            IAuth_Interactor auth_Intarector = new Auth_Interactor(dataWrap);
            auth_Intarector.Auth_Presenter = auth_Presenter;

            
            switchButton.Click += ((o, e) =>
            {
                var click = (Switch)o;
                ChangeLocalizationClick?.Invoke(click.Checked);
            });

            registrationButton.Click += ((o, e) =>
            {
                OnRegistrationClick?.Invoke();
            });

            signInButton.Click += ((o, e) =>
            {
                string login = loginEditTextWindow.Text;
                string password = passwordEditTextWindow.Text;
                OnSignInClick?.Invoke(login, password);
            });

        }
        protected override void OnResume()
        {
            base.OnResume();
            TextView textViewExeption = FindViewById<TextView>(Resource.Id.textViewException);
            textViewExeption.Text = "";
        }
    }
}

