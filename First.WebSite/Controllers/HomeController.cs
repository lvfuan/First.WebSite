using First.WebSite.DB.Interface;
using First.WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First.WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebSite webSiteServer;
        public HomeController(IWebSite webSite)
        {
            this.webSiteServer = webSite;
        }
        public ActionResult Index()
        {
            //this.webSiteServer.User.Add(new Models.UserModel() { LoginId = "admin", LoginPwd = "88888888", Age = 20, Sex = 1, Email = "lvfuan@163.com", Mobile = "13838384388" });
            //List<MenuModel> lst = new List<MenuModel>()
            //{
            //    new MenuModel(){Name="Home", Code="001"},
            //    new MenuModel(){ Name="Server", Code="002" },
            //    new MenuModel(){ Name="New" ,Code="003"},
            //    new MenuModel(){ Name="About", Code="004" },
            //    new MenuModel(){ Name="Contcat",Code="005" },
            //    new MenuModel(){ Name="Login", Code="006" }
            //};
            //lst.ForEach(x => this.webSiteServer.Menu.Add(x));
            ViewBag.Menu = this.webSiteServer.Menu.QueryList();
            return View();
        }
    }
}