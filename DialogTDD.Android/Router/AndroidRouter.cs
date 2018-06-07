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
            Intent intent = new Intent(_context, typeof(ChatActivity));
            //intent.PutExtra(ChatActivity.IdKey, id);
            _context.StartActivity(intent);
        }

        public void GoRegistrationPage()
        {
            Intent intent = new Intent(_context, typeof(RegistrationActivity));
            //intent.PutExtra(ChatActivity.IdKey, id);
            _context.StartActivity(intent);
        }
    }
}