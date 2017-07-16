using First.WebSite.DB.Interface;
using First.WebSite.DB.Interface.Public;
using First.WebSite.DB.Interface.User;
using First.WebSite.DB.Server.Public;
using First.WebSite.DB.Server.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First.WebSite.DB.Server
{
    public class WebSiteServer:IWebSite
    {
        public IUser User { get; set; } = new UserServer();
        public IMenu Menu { get; set; } = new MenuServer();
    }
}