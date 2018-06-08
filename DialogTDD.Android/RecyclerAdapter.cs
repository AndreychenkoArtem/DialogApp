using System;
using Android;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using DialogTDD.Portable.Data;
using DialogTDD.Portable.Data.Interfaces;
using DialogTDD.Portable.GoogleSearch.DataSearch;
using DialogTDD.Portable.GoogleSearch.Interface;

namespace DialogTDD.Android
{
    public class RecyclerAdapter : RecyclerView.Adapter
    {
        private BBCNewsList _data;

        public RecyclerAdapter(BBCNewsList data)
        {
            _data = data;
        }



        public override int ItemCount => _data.GetCount();


        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            
            if (holder is ISetDataToView vh)
            {
                vh.SetData(position);
            }
            
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = null;
            RecyclerView.ViewHolder vh;


            itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.CustomCard, parent, false);
            vh = new ViewHolder(itemView, parent.Context, _data);



            return vh;
        }


    }
}