using System;
using DialogTDD.IOS.DataSource;
using DialogTDD.IOS.Router;
using DialogTDD.Portable.GoogleSearch.DataSearch;
using DialogTDD.Portable.GoogleSearch.InteractorSearch;
using DialogTDD.Portable.GoogleSearch.Interface;
using DialogTDD.Portable.GoogleSearch.PresenterSearch;
using DialogTDD.Portable.GoogleSearch.ViewSearch;
using DialogTDD.Portable.Router.Interfaces;
using Foundation;
using UIKit;

namespace DialogTDD.IOS.Cells
{
    public partial class MyCollectionViewCell : UICollectionViewCell, IViewSearch, ISetDataToView
    {
        public static readonly NSString Key = new NSString("MyCollectionViewCell");
        public static readonly UINib Nib;

        private IPresenterSearch _presenterSearch;
        private IInteractorSearch _interactorSearch;
        private IRouter _router;

        static MyCollectionViewCell()
        {
            Nib = UINib.FromName("MyCollectionViewCell", NSBundle.MainBundle);
        }

        public void CreateViper (BBCNewsList data, UINavigationController navigationController)
        {
            _presenterSearch = new PresenterSearch(_router, this);
            _interactorSearch = new InteractorSearch(data);
            _router = new IOSRouter(navigationController);
            _interactorSearch.PresenterSearch = _presenterSearch;
            _presenterSearch.Router = _router;
        }

        protected MyCollectionViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public void SetDescription(string description)
        {
            descriptionTextView.Text = description;
        }

        public void SetImage(string image)
        {
            UIImage img = ImageConverter.FromUrl(image);
            imageViewNews.Image = img;
        }

        public void SetTitle(string title)
        {
            titleTextView.Text = title;
        }

        public void SetData(int position)
        {
            _interactorSearch.SetData(position);
        }
    }
}
