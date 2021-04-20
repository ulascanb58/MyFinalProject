using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;


namespace Core.DataAccess
{
    //generic constraint yani generic kısıtlaması.
    //class kullanılması referans tipin olduğunu ifade eder.
   public interface IEntityRepository<T> 
       where T:class,IEntity,new()
   // IEntity : IEntity olabilri veya IEntity implemente eden bir nesne olabilir.
   //new() : newlenebilir olması.
    {

        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
