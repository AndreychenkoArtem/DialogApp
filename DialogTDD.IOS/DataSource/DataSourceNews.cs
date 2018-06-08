using System;
using UIKit;
using Foundation;
using DialogTDD.IOS.Cells;
using CoreGraphics;
using DialogTDD.Portable.GoogleSearch.Interface;
using DialogTDD.Portable.GoogleSearch.DataSearch;

namespace DialogTDD.IOS.DataSource
{
    public class DataSourceNews : UICollectionViewDataSource
    {
        private IMainViewNews _chatViewController;
        // private INewsEntity _newsEntity;
        private BBCNewsList _data;
        private UINavigationController _navigationController;

        public DataSourceNews(IMainViewNews chatViewController, BBCNewsList data, UINavigationController navigationController)
        {
            _chatViewController = chatViewController;
            _data = data;
            _navigationController = navigationController;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = collectionView.DequeueReusableCell(MyCollectionViewCell.Key, indexPath) as MyCollectionViewCell;
            int position = (int)indexPath.Item;

            cell.CreateViper(_data, _navigationController);
            cell.SetData(position);
            return cell;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return _data == null ? 0 : _data.GetCount();
        }
    }
}
