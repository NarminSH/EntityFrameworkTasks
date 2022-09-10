using System;
using CrudApp1.Models;

public class GenericRepository<T> : IGenericRepository<T> where T: class
{

    protected readonly NorthwindContext _context;

    public GenericRepository(NorthwindContext context)
    {
        _context = context;
    }


    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
        _context.SaveChanges();

    }


    //public void Delete(Func<T, bool> func)
    //{

    //    T answer = _context.Set<T>().FirstOrDefault(func);
    //    if (answer != null)
    //    {
    //        _context.Set<T>().Remove(answer);
    //        _context.SaveChanges();
    //    }
    //}

    public void Delete(T entity)
    {

        _context.Set<T>().Remove(entity);
        _context.SaveChanges();
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }


    public T GetById(int id) => _context.Set<T>().Find(id);


    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
        _context.SaveChanges();
    }
}

