using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace First.WebSite.Models.context
{
    public class WebSiteDBContext:DbContext
    {
        public WebSiteDBContext():base("name=WebSiteDBContext") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuModel>().ToTable("Menu");
            modelBuilder.Entity<UserModel>().ToTable("User");
            //base.OnModelCreating(modelBuilder);
        }
    }
}