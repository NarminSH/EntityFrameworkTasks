using System;
using CrudApp1.Repositories.Category;
using CrudApp1.Models;


public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(NorthwindContext context) : base(context)
    {
    }

}

