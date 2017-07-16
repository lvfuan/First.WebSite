using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using System.IO;
using First.WebSite.DB.Interface;
using Autofac.Integration.Mvc;

namespace First.WebSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(RegisterService().Build()));
        }
        private ContainerBuilder RegisterService()
        {
            var builder = new ContainerBuilder();
            var assemblys = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/bin/")).GetFiles("*.dll").Select(r => System.Reflection.Assembly.LoadFrom(r.FullName)).ToArray();
            //var assemblys = AppDomain.CurrentDomain.GetAssemblies();
            builder.RegisterControllers(assemblys); //开启了Controller的依赖注入功能,这里使用Autofac提供的RegisterControllers扩展方法来对程序集中所有的Controller一次性的完成注册
            builder.RegisterFilterProvider();//开启了Filter的依赖注入功能，为过滤器使用属性注入必须在容器创建之前调用RegisterFilterProvider方法，并将其传到AutofacDependencyResolver

            // 普通组件注入
            var baseType = typeof(IDependency);
            builder.RegisterAssemblyTypes(assemblys).Where(t => baseType.IsAssignableFrom(t) && t != baseType).AsImplementedInterfaces().InstancePerLifetimeScope();

            // 缓存组件注入
            //var baseCacheType = typeof(ICache);
            //builder.RegisterAssemblyTypes(assemblys).Where(t => !baseType.IsAssignableFrom(t) && baseCacheType.IsAssignableFrom(t) && t != baseCacheType).AsImplementedInterfaces().InstancePerLifetimeScope();

            return builder;


        }
    }
}
