using System;
using System.Linq.Expressions;

public interface IGenericRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    //void Delete(Func<T, bool> func);
    void Delete(T entity);
}


