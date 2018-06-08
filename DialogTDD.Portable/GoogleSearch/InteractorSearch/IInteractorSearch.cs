using DialogTDD.Portable.GoogleSearch.PresenterSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.GoogleSearch.InteractorSearch
{
    public interface IInteractorSearch
    {
       IPresenterSearch PresenterSearch { set; }

        void SetData(int position);
    }
}
