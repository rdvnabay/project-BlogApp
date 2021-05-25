using System;
using System.Collections.Generic;
using System.Text;

namespace YazilimBlogApp.BusinessLayer.Abstract
{
    public interface IRepositoryService<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
