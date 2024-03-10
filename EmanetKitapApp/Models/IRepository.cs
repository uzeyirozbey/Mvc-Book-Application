﻿using System.Linq.Expressions;

namespace EmanetKitapApp.Models
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filtre);
        void Ekle(T entity);
        void Sil(T entitity);
        void SilAralik(IEnumerable<T> entities);


    }
}
