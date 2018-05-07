using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using YourHealthWeb.Contracts;

namespace YourHealthWeb.DAL
{
    public abstract class AbstractRepository<T>:IRepository<T> where T : class
    {
        protected DbSet<T> DbSet { get; set; }
        protected HospitalContext HospitalContext { get; set; }

        protected AbstractRepository(HospitalContext db)
        {
            DbSet = db.Set<T>();
            HospitalContext = db;
        }

        public void Create(T entity)
        {
            DbSet.Add(entity);
        }

        //TODO: WTF
        public void Delete(int id)
        {
            var entity = DbSet.Find(id);
            if (HospitalContext.Entry(entity).State==EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            DbSet.Remove(entity);
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet;
        }
    }
}
