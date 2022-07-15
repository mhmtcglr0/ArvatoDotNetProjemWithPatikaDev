using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess

{
    //generic constraint
    // class: referans tip demek
    // IEntity: Ientity yada IEntity implemente edebilen bir nesne olabilir.
    // new() : newlenebilir
    public interface IEntityRepository<T> where T : class, IEntity, new() // T yerine her şeyi yazamasın veritabanı nesnelerini yazabilsin
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //null burda filtre vermeyede biliriz demek
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);


    }
}