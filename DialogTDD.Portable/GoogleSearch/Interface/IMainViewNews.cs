using DialogTDD.Portable.GoogleSearch.DataSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.GoogleSearch.Interface
{
    public interface IMainViewNews
    {
        event Action<string> btnClickSearch;
        void UpdateData(BBCNews data);
    }
}
