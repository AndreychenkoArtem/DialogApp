using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using DialogTDD.Android.Router;
using DialogTDD.Portable.Data.Interfaces;
using DialogTDD.Portable.GoogleSearch.DataSearch;
using DialogTDD.Portable.GoogleSearch.InteractorSearch;
using DialogTDD.Portable.GoogleSearch.Interface;
using DialogTDD.Portable.GoogleSearch.PresenterSearch;
using DialogTDD.Portable.GoogleSearch.ViewSearch;
using DialogTDD.Portable.Router.Interfaces;

namespace DialogTDD.Android
{
    public class ViewHolder : RecyclerView.ViewHolder, ISetDataToView
    {
        private IInteractorSearch _interactorSearch;
        private IPresenterSearch _presenterSearch;
        private IViewSearch _cardView;

        public ViewHolder(View itemView, Context context, BBCNewsList data) : base(itemView)
        {
            _cardView = itemView as IViewSearch;

            IRouter router = new AndroidRouter(context);
            _interactorSearch = new InteractorSearch(data);

            _presenterSearch = new PresenterSearch(router, _cardView);
            _interactorSearch.PresenterSearch = _presenterSearch;
        }

        public void SetData(int position)
        {
            _interactorSearch.SetData(position);
        }

    }
}