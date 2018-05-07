using System;
using System.Collections.Generic;

namespace YourHealthWeb.Contracts
{
    public interface IRepository<T>
    {
        void Create(T entity);

        void Delete(int id);

        T GetById(int id);

        IEnumerable<T> GetAll();
    }
}
