using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Abstract
{
   public interface IRepository<T>
    {
        T GetById(int id);//id ile bulup getircek
        T GetOne(Expression<Func<T, bool>> filter);//herhangi birşeyle bulmak isterse bir tane getirir
        List<T> GetAll(Expression<Func<T, bool>> filter=null);//bütün kayıtları getirir
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
