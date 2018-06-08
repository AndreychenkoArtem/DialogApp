using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using DialogTDD.Portable.GoogleSearch.ViewSearch;

namespace DialogTDD.Android.CustomCards
{
    [Register("DialogTDD.Android.CustomCards.CustomCard")]
    public class CustomCard : RelativeLayout, IViewSearch
    {
        public CustomCard(Context context) : base(context)
        {
        }

        public CustomCard(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public CustomCard(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public CustomCard(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        protected CustomCard(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public void SetDescription(string description)
        {

            var txt = FindViewById<TextView>(Resource.Id.description_text_view);
            txt.Text = description;
        }

        public void SetImage(string image)
        {
            var img = FindViewById<ImageView>(Resource.Id.image_view_search);
            Bitmap bmp = URLtoBitmapConverter.ConvertImage(image);
            img.SetImageBitmap(bmp);
        }

        public void SetTitle(string title)
        {
            var txt = FindViewById<TextView>(Resource.Id.title_text_view);
            txt.Text = title;
        }
    }
}