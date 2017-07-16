using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace First.WebSite.DB.Interface.Public
{
    public interface IBaseCommon<T> where T:class,new()
    {
        void Add(T t);
        void Delete(T t);
        List<T> Query(Expression<Func<T,bool>> where);
        List<T> QueryList();
        List<T> QueryPageList<TKey>(int pageIndex,int pageSize,Expression<Func<T,bool>> where, Expression<Func<T,TKey>> orderBy,out int count);
    }
}