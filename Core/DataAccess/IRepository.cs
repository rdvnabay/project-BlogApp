﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace YazilimBlogApp.Core.DataAccess
{
    public interface IEntityRepository<T>
    {
        T Get(Expression<Func<T,bool>>filter);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}