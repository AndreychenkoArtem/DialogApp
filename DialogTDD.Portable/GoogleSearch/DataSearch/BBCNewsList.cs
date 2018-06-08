using DialogTDD.Portable.GoogleSearch.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.GoogleSearch.DataSearch
{
    public class BBCNewsList : IBBCNewsListGetCount
    {
        private BBCNews _data;

        public BBCNewsList(BBCNews data)
        {
            _data = data;
        }

        public int GetCount()
        {
            if (_data.articles != null)
            {
                return _data.articles.Count;
            }
            else
            {
                return 0;
            }
        }

        public Articles GetNewsById(int id)
        {
            throw new NotImplementedException();
        }

        public Articles GetNewsByIndex(int index)
        {
            if (_data.articles != null)
            {
                return _data.articles[index];
            }
            else
                return null;
        }
    }
}
