using BarberShop.Data.Common.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BarberShop.Data.Repositories
{
    public class DbRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        public DbRepository(BarberShopDbContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
            this.DbSet = this.Context.Set<TEntity>();
        }
        protected DbSet<TEntity> DbSet { get; set; }
        protected BarberShopDbContext Context { get; set; }
   
        public virtual IQueryable<TEntity> All() => this.DbSet;

        public virtual IQueryable<TEntity> AllAsNoTracking() => this.DbSet.AsNoTracking();
        public virtual void Add(TEntity entity) => this.DbSet.Add(entity);
        public virtual void Update(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity) => this.DbSet.Remove(entity);

        public void SaveChanges() => this.Context.SaveChanges();

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Context?.Dispose();
            }
        }
    }
}
