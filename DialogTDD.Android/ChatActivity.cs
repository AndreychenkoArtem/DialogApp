using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using DialogTDD.Portable.GoogleSearch;
using DialogTDD.Portable.GoogleSearch.DataSearch;
using DialogTDD.Portable.GoogleSearch.Interface;

namespace DialogTDD.Android
{
    [Activity(Label = "ChatActivity")]
    public class ChatActivity : Activity , IMainViewNews
    {

        private RecyclerView mRecyclerView;
        private RecyclerView.LayoutManager mLayoutManager;
        private RecyclerAdapter mUserCollection;

        private RequestToServer req;

        public event Action<string> btnClickSearch;

        public void UpdateData(BBCNews data)
        {
            mUserCollection = new RecyclerAdapter(new BBCNewsList(data));
            mRecyclerView.SetAdapter(mUserCollection);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ChatLayout);

            req = new RequestToServer(this);

            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recycler_view);
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);

            mUserCollection = new RecyclerAdapter(new BBCNewsList(new BBCNews()));
            mRecyclerView.SetAdapter(mUserCollection);


            var searchButtor = FindViewById<Button>(Resource.Id.search_button);
            searchButtor.Click += SearchButtor_Click;

        }

        private void SearchButtor_Click(object sender, EventArgs e)
        {
            var txt = FindViewById<EditText>(Resource.Id.search_Edit_Text);
            btnClickSearch?.Invoke(txt.Text);
        }
}
}