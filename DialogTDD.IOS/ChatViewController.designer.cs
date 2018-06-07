// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DialogTDD.IOS
{
    [Register ("ChatViewController")]
    partial class ChatViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView _chatView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_chatView != null) {
                _chatView.Dispose ();
                _chatView = null;
            }
        }
    }
}