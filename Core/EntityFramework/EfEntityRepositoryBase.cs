using Core.DataAccess;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.EntityFramework
{
    //Bana bir tane  tablo ve context tipi ver ona göre çalışcam
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>

        where TEntity : class, IEntity, new() //kısıtlama koydum burda 
        where TContext : DbContext, new() //Sen buraya kafana göre her classı yazamazsın Dbcontexten gitmelisin dedim
    {
        public void Add(TEntity entity)
        {
            //IDisposible pattern implementation of c# 
            using (TContext context = new TContext()) // using bittiği anda gp ye diyor gel abi topla belleği temizle diyor
            {
                var addedEntity = context.Entry(entity); // Veri kaynağından referansı yakala
                addedEntity.State = EntityState.Added; // eklenecek nesne
                context.SaveChanges();  // ekle
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext()) // using bittiği anda gp ye diyor gel abi topla belleği temizle diyor
            {
                var deletedEntity = context.Entry(entity); // Veri kaynağından 
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null) //Ternary kullancam
        {
            using (TContext context = new TContext())
            {
                return filter == null //Ternary ile yapıcam
                    ? context.Set<TEntity>().ToList() : //Select * from products döndürüyor listeye çeviriyo filtre null ise
                    context.Set<TEntity>().Where(filter).ToList(); //filtreleyip verir
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext()) // using bittiği anda gp ye diyor gel abi topla belleği temizle diyor
            {
                var updatedEntity = context.Entry(entity); // Veri kaynağından 
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}