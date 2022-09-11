using System;


public class ContactRepository : Repository<Contact>, IContactRepository
{
    public ContactRepository(MyDbContext context) : base(context)
    {
    }
}

