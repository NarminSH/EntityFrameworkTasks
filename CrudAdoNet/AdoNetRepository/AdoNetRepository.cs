using System;
using Microsoft.Data.SqlClient;



public class AdoNetRepository<T> : IRepository<T> where T: class
{
    
    const string connectionString = "Server=localhost;Database=MyDb;Integrated Security=True;";
    public void Add(T entity)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(InsertData(entity), connection))
            {
                int result = command.ExecuteNonQuery();
                Console.WriteLine($"{result} rows affected after insert");
            }
        }
    }

        public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> FindAll(Func<T, bool> func)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
    public string InsertData(T entity)
    {
        string insertQuery = "";
        insertQuery += $"INSERT INTO {entity.GetType().Name}s (";
        foreach (var property in entity.GetType().GetProperties())
        {
            insertQuery += property.Name + ",";
        }
        insertQuery += ") VALUES (";
        foreach (var property in entity.GetType().GetProperties())
        {
            insertQuery += "'" + property.GetValue(entity) + "'" + ",";
        }
        insertQuery += (')');
        return insertQuery;
    }
}


