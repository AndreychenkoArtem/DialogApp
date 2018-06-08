using DialogTDD.Portable.GoogleSearch.DataSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.GoogleSearch.Interface
{
    public interface IBBCNewsListGetCount
    {
        int GetCount();

        Articles GetNewsById(int id);

        Articles GetNewsByIndex(int index);

    }
}
