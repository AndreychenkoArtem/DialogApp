using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DialogTDD.Portable.Router.Interfaces;
using Foundation;
using UIKit;

namespace DialogTDD.IOS.Router
{
    public class IOSRouter : IRouter
    {
        private UINavigationController _navigationController;
        public IOSRouter(UINavigationController navigationController)
        {
            _navigationController = navigationController;
        }

        public void GoChatPage()
        {
            var dest = UIStoryboard.FromName("Main", NSBundle.MainBundle).InstantiateViewController("ChatViewController") as ChatViewController;
            //dest.Id = id;
            _navigationController.PushViewController(dest, true);
        }

        public void GoRegistrationPage()
        {
            var dest = UIStoryboard.FromName("Main", NSBundle.MainBundle).InstantiateViewController("RegistrationViewController") as RegistrationViewController;
            //dest.Id = id;
            _navigationController.PushViewController(dest, true);
        }
    }
}