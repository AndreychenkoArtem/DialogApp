// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace DialogTDD.IOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel exceptionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelRuEn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch localizationChangeButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField loginEditText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel loginLabelField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField mainLabelText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView mainViewController { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField passwordEditText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel passwordLabelField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton registrationButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton signInButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (exceptionLabel != null) {
                exceptionLabel.Dispose ();
                exceptionLabel = null;
            }

            if (labelRuEn != null) {
                labelRuEn.Dispose ();
                labelRuEn = null;
            }

            if (localizationChangeButton != null) {
                localizationChangeButton.Dispose ();
                localizationChangeButton = null;
            }

            if (loginEditText != null) {
                loginEditText.Dispose ();
                loginEditText = null;
            }

            if (loginLabelField != null) {
                loginLabelField.Dispose ();
                loginLabelField = null;
            }

            if (mainLabelText != null) {
                mainLabelText.Dispose ();
                mainLabelText = null;
            }

            if (mainViewController != null) {
                mainViewController.Dispose ();
                mainViewController = null;
            }

            if (passwordEditText != null) {
                passwordEditText.Dispose ();
                passwordEditText = null;
            }

            if (passwordLabelField != null) {
                passwordLabelField.Dispose ();
                passwordLabelField = null;
            }

            if (registrationButton != null) {
                registrationButton.Dispose ();
                registrationButton = null;
            }

            if (signInButton != null) {
                signInButton.Dispose ();
                signInButton = null;
            }
        }
    }
}