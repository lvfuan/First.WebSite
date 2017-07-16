using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace First.WebSite.Models.context
{
    public static class ContextFactory
    {
        public static WebSiteDBContext DB
        {
            get
            {
                var fullName = typeof(WebSiteDBContext).FullName;
                object obj = CallContext.GetData(fullName);
                if (obj == null)
                {
                    obj = new WebSiteDBContext();
                    CallContext.SetData(fullName, obj);
                    return obj as WebSiteDBContext;
                }
                return obj as WebSiteDBContext;
            }
        }
    }
}