using CrudApp1.Models;
NorthwindContext context = new NorthwindContext();

IGenericRepository<Category> repository = new GenericRepository<Category>(context);


var collec = repository.GetById(1);
repository.Delete(collec);
collec.CategoryName = "New";
repository.Update(collec);

var all = repository.GetAll();
foreach (var item in all)
{
    Console.WriteLine(item.CategoryName);
}