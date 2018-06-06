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
            throw new NotImplementedException();
        }

        public void SetButtonSignInText(string buttonSignInText)
        {
            throw new NotImplementedException();
        }

        public void SetLabelLoginText(string labelLogin)
        {
            throw new NotImplementedException();
        }

        public void SetLabelPasswordText(string LabelPassword)
        {
            throw new NotImplementedException();
        }

        public void SetMainLabelText(string mainLabel)
        {
            throw new NotImplementedException();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var loginWindowView = FindViewById<LoginWindowView>(Resource.Id.loginWindow);

            IDataWrap dataWrap = new DataWrap();
            IRouter router = new AndroidRouter(this);
            IAuth_Presenter auth_Presenter = new Auth_Presenter(router, loginWindowView);
            auth_Presenter.Router = router;

            IAuth_Interactor auth_Intarector = new Auth_Interactor(dataWrap);
            auth_Intarector.Auth_Presenter = auth_Presenter;

            var d = FindViewById<Switch>(Resource.Id.change_localization);
            d.Click += ((s, e) =>
            {
                var h = (Switch)s;

                ChangeLocalizationClick?.Invoke(h.Checked);


            });


        }
    }
}

