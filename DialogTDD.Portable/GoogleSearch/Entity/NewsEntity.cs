using DialogTDD.Portable.GoogleSearch.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.GoogleSearch.Entity
{
    public class NewsEntity : INewsEntity
    {
        public string Title { get;}
        public string Description { get;}
        public string Img { get; }

        public NewsEntity(string title,string description,string img)
        {
            Title = title;
            Description = description;
            Img = img;
        }
    }
}
