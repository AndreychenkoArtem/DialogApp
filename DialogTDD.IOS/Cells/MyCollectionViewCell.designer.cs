// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace DialogTDD.IOS.Cells
{
    [Register ("MyCollectionViewCell")]
    partial class MyCollectionViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        DialogTDD.IOS.Cells.MyCollectionViewCell _myCollectionViewCell { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel descriptionTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageViewNews { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel titleTextView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_myCollectionViewCell != null) {
                _myCollectionViewCell.Dispose ();
                _myCollectionViewCell = null;
            }

            if (descriptionTextView != null) {
                descriptionTextView.Dispose ();
                descriptionTextView = null;
            }

            if (imageViewNews != null) {
                imageViewNews.Dispose ();
                imageViewNews = null;
            }

            if (titleTextView != null) {
                titleTextView.Dispose ();
                titleTextView = null;
            }
        }
    }
}