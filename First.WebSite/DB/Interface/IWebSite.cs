using First.WebSite.DB.Interface.Public;
using First.WebSite.DB.Interface.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First.WebSite.DB.Interface
{
    public interface IWebSite:IDependency
    {
        IUser User { get; set; }
        IMenu Menu { get; set; }
    }
}