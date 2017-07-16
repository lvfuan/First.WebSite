using First.WebSite.DB.Interface.Public;
using First.WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First.WebSite.DB.Server.Public
{
    public class MenuServer:BaseCommon<MenuModel>,IMenu
    {
    }
}