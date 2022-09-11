using System;


public class Repository<T> : IRepository<T> where T : class
{

    protected readonly MyDbContext _context;

    public Repository(MyDbContext context)
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

    //    T item = _context.Set<T>().FirstOrDefault(func);
    //    if (item != null)
    //    {
    //        _context.Set<T>().Remove(item);
    //        _context.SaveChanges();
    //    }
    //}

    public void Delete(T entity)
    {
        if (entity != null)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            Console.WriteLine("Deleted the user!");
        }
        else Console.WriteLine("No user with given Id");


    }

    public IEnumerable<T> FindAll(Func<T, bool> func) => _context.Set<T>().Where(func);

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

