using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using DialogTDD.Portable.Authorization.Auth_View.Interfaces;

namespace DialogTDD.Android.Views
{
    public class LoginWindowView : RelativeLayout, IAuth_View
    {
        private LayoutInflater _layoutInflater;

        public LoginWindowView(Context context) : base(context)
        {
        }

        public LoginWindowView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public LoginWindowView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public LoginWindowView(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        protected LoginWindowView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        protected override void OnFinishInflate()
        {
            base.OnFinishInflate();
            _layoutInflater = LayoutInflater.From(Context);
            _layoutInflater.Inflate(Resource.Layout.Main, this, true);
        }

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
    }
}