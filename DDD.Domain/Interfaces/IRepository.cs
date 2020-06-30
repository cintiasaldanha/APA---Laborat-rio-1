namespace DDD.Domain.Interfaces
{
using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(int id);

        T Select(int id);

        IList<T> Select();             
    }
}