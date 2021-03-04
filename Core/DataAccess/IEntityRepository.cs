﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    //generic constraint
    //class :referans tip
    //IEntity:IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new(): new'lenebilir olmalı (IEntity new lemesin diye)
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByCategory(int categoryId);
    }
}
