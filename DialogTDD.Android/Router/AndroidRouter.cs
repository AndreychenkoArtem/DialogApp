using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DialogTDD.Portable.Router.Interfaces;

namespace DialogTDD.Android.Router
{
    public class AndroidRouter : IRouter
    {
        private Context _context;

        public AndroidRouter(Context context)
        {
            _context = context;
        }

        //public void GoBack()
        //{
        //    (_context as Activity)?.OnBackPressed();
        //}

        public void GoChatPage()
        {
            throw new NotImplementedException();
        }

        public void GoRegistrationPage()
        {
            throw new NotImplementedException();
        }
    }
}