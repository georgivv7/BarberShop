namespace BarberShop.Data.Common.Repositories
{
    using System;
    using System.Linq;
    public interface IRepository<TEntity> : IDisposable
       where TEntity : class
    {
        IQueryable<TEntity> All();

        IQueryable<TEntity> AllAsNoTracking();

        void Add(TEntity entity);   

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void SaveChanges();

    }
}
