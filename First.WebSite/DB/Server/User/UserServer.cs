using First.WebSite.DB.Interface.User;
using First.WebSite.DB.Server.Public;
using First.WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First.WebSite.DB.Server.User
{
    public class UserServer:BaseCommon<UserModel>,IUser
    {
    }
}