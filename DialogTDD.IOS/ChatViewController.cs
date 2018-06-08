using DialogTDD.IOS.Cells;
using DialogTDD.IOS.DataSource;
using DialogTDD.Portable.GoogleSearch;
using DialogTDD.Portable.GoogleSearch.DataSearch;
using DialogTDD.Portable.GoogleSearch.Entity;
using DialogTDD.Portable.GoogleSearch.Interface;
using Foundation;
using System;
using UIKit;

namespace DialogTDD.IOS
{
    public partial class ChatViewController : UIViewController, IMainViewNews
    {
        public event Action<string> btnClickSearch;

        private DataDelegate _dataDelegate;
        private INewsEntity _newsEntity;
        private BBCNewsList _data;


        public ChatViewController(IntPtr handle) : base(handle)
        {

        }

        public void UpdateData(BBCNews data)
        {
            _data = new BBCNewsList(data);
            _myCollectionView.DataSource = new DataSourceNews(this, _data, NavigationController);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            RequestToServer req = new RequestToServer(this);
            BBCNews data = new BBCNews();
            _data = new BBCNewsList(data);

            _btnSearch.TouchUpInside += Search_Clicked;
            _searchTextField.Text = "";

            _myCollectionView.RegisterNibForCell(MyCollectionViewCell.Nib, MyCollectionViewCell.Key);
            _dataDelegate = new DataDelegate();
            _myCollectionView.Delegate = _dataDelegate;
            _myCollectionView.DataSource = new DataSourceNews(this, _data, NavigationController);
        }

        private void Search_Clicked(object sender, EventArgs e)
        {
            btnClickSearch?.Invoke(_searchTextField.Text);
        }
    }
}