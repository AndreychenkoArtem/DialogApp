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
        UIKit.UIButton _btnSearch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView _chatView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UICollectionView _myCollectionView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField _searchTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint searchButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_btnSearch != null) {
                _btnSearch.Dispose ();
                _btnSearch = null;
            }

            if (_chatView != null) {
                _chatView.Dispose ();
                _chatView = null;
            }

            if (_myCollectionView != null) {
                _myCollectionView.Dispose ();
                _myCollectionView = null;
            }

            if (_searchTextField != null) {
                _searchTextField.Dispose ();
                _searchTextField = null;
            }

            if (searchButton != null) {
                searchButton.Dispose ();
                searchButton = null;
            }
        }
    }
}