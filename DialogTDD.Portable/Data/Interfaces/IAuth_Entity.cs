using System;
using System.Collections.Generic;
using System.Text;

namespace DialogTDD.Portable.Data.Interfaces
{
    public interface IAuth_Entity
    {
        string Login { get; }
        string Password { get; }
    }
}
