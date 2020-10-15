using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace appCoreThree.DAL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
