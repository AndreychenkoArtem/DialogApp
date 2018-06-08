using DialogTDD.Portable.Data.Interfaces;
using DialogTDD.Portable.GoogleSearch.DataSearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.Data
{
    public class DataWrap : IDataWrap
    {

        public DataWrap()
        {
            Articles dataSearch = new Articles(); // создаем инстанс класса коллекции
            //_dataSearch = dataSearch; // сетим ссылку на конструктор коллекции в котором заполняется коллекция данными
        }


        //public int GetCount()
        //{
        //    return _dataSearch.id;
        //}
    }
}
