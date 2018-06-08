using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.GoogleSearch.ViewSearch
{
    public interface IViewSearch
    {
        void SetImage(string image);
        void SetTitle(string title);
        void SetDescription(string description);
    }
}
