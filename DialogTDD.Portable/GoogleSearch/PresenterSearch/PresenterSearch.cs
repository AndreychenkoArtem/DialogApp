using System;
using System.Collections.Generic;
using System.Text;
using DialogTDD.Portable.GoogleSearch.Interface;
using DialogTDD.Portable.GoogleSearch.ViewSearch;
using DialogTDD.Portable.Router.Interfaces;

namespace DialogTDD.Portable.GoogleSearch.PresenterSearch
{
    public class PresenterSearch : IPresenterSearch
    {
        private IRouter _router;
        private IViewSearch _viewSearch;
        public IRouter Router { get => _router; set => _router = value; }
        public IViewSearch ViewSearch { get => _viewSearch; set => _viewSearch = value; }

        public event Action<string> SearchButtonPresed;

        public PresenterSearch(IRouter router, IViewSearch viewSearch)
        {
            ViewSearch = viewSearch;
            Router = router;

        }


        public void SetData(INewsEntity entity)
        {
            _viewSearch.SetImage(entity.Img);
            _viewSearch.SetDescription(entity.Description);
            _viewSearch.SetTitle(entity.Title);
        }
    }
}
