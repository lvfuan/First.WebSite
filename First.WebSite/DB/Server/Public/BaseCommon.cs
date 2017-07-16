using First.WebSite.DB.Interface.Public;
using First.WebSite.Models.context;
using System;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Collections.Generic;

namespace First.WebSite.DB.Server.Public
{
    public class BaseCommon<T> : IBaseCommon<T> where T : class,new()
    {
        
        public WebSiteDBContext _db { get { return Models.context.ContextFactory.DB; } }
        DbSet<T> _dbEntity;
        public BaseCommon()
        {
            this._dbEntity = this._db.Set<T>();
        }
        public void Add(T t)
        {
            if (t == null) throw new Exception("参数不能为空");
            this._dbEntity.Add(t);
            this.Submit();

        }

        public void Delete(T t)
        {
            if (t == null) throw new Exception("参数不能为空");
            this._dbEntity.Remove(t);
            this.Submit();
        }

        public List<T> Query(Expression<Func<T, bool>> where)
        {
           return this._dbEntity.Where(where).ToList();
        }

        public List<T> QueryPageList<TKey>(int pageIndex, int pageSize, Expression<Func<T,bool>> where,Expression<Func<T,TKey>> orderBy, out int count)
        {
            count = this._dbEntity.Count(where);
            return this._dbEntity.Where(where).OrderByDescending(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
        public void Submit()
        {
            this._db.SaveChanges();
        }

        public List<T> QueryList()
        {
            return this._dbEntity.ToList();
        }
    }
}