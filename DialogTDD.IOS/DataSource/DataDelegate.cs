using System;
using UIKit;
using Foundation;
using CoreGraphics;

namespace DialogTDD.IOS.DataSource
                   
{
    public class DataDelegate : UICollectionViewDelegateFlowLayout
    {
        [Export("collectionView:layout:sizeForItemAtIndexPath:")]
        public CoreGraphics.CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            return new CGSize(collectionView.Frame.Width, collectionView.Frame.Height / 2.5);
        }

        [Export("collectionView:layout:minimumLineSpacingForSectionAtIndex:")]
        public nfloat GetMinimumLineSpacingForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section)
        {
            return 10;
        }
    }
}
