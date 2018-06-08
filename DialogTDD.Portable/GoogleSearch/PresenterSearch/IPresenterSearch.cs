using DialogTDD.Portable.GoogleSearch.Interface;
using DialogTDD.Portable.GoogleSearch.ViewSearch;
using DialogTDD.Portable.Router.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.GoogleSearch.PresenterSearch
{
    public interface IPresenterSearch
    {
        event Action<string> SearchButtonPresed;

        IRouter Router { get; set; }
        IViewSearch ViewSearch { get; set; }
        void SetData(INewsEntity entity);
    }
}
