using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace DialogTDD.IOS.DataSource
{
    public static class ImageConverter
    {
        public static UIImage FromUrl(string uri)
        {
            Contract.Ensures(Contract.Result<UIImage>() != null);
            try
            {
                using (var url = new NSUrl(uri))
                using (var data = NSData.FromUrl(url))
                    return UIImage.LoadFromData(data);
            }
            catch (Exception e)
            {
                return new UIImage();
            }

        }
    }
}