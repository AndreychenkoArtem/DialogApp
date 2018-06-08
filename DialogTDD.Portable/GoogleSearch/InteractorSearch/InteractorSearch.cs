using System;
using System.Collections.Generic;
using System.Text;
using DialogTDD.Portable.GoogleSearch.Entity;
using DialogTDD.Portable.GoogleSearch.Interface;
using DialogTDD.Portable.GoogleSearch.PresenterSearch;

namespace DialogTDD.Portable.GoogleSearch.InteractorSearch
{
    public class InteractorSearch : IInteractorSearch
    {

        private IBBCNewsListGetCount _rep;

        private IPresenterSearch _presenterSearch;
        public IPresenterSearch PresenterSearch
        {
            get => _presenterSearch;
            set
            {
                if (_presenterSearch != null)
                {
                    _presenterSearch.SearchButtonPresed -= _presenterSearch_SearchButtonPresed;
                }
                _presenterSearch = value ?? throw new ArgumentNullException();
                _presenterSearch.SearchButtonPresed += _presenterSearch_SearchButtonPresed;
            }
        }


        public InteractorSearch(IBBCNewsListGetCount data)
        {
            _rep = data;
        }

        public void SetData(int position)
        {
            var model = _rep.GetNewsByIndex(position);
            _presenterSearch.SetData(new NewsEntity(model.title, model.description, model.urlToImage));
        }

        private void _presenterSearch_SearchButtonPresed(string obj)
        {
            throw new NotImplementedException();
        }
    }
}