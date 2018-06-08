using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.GoogleSearch.DataSearch
{
    public class BBCNews
    {
        public string status { get; set; }
        public int totalResults { get; set; }
        public List<Articles> articles { get; set; }
    }
}
