using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.GoogleSearch.Interface
{
    public interface INewsEntity
    {
        string Title { get;}
        string Description { get;}
        string Img { get;}
    }
}
