MyDbContext context = new();

IContactRepository repo = new ContactRepository(context);
IRepository<Contact> c1 = new AdoNetRepository<Contact>;

StartMenu();

void StartMenu()
{
menu:
    Console.WriteLine(" a. Add data\n b. List data\n c. Search Data\n d. Exit");
    string input = Console.ReadLine().Trim();

    switch (input)
    {
        case "a":
            InsertData();
            goto menu;
        case "b":
            ListData();
            goto menu;
        case "c":
            LookUp();
            goto menu;
        case "d":
            break;
        default:
            Console.WriteLine("Please choose from below options");
            goto menu;
    }
};


void InsertData()
{
    Console.WriteLine("Please enter your name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Please enter your surname: ");
    string surname = Console.ReadLine();
    Console.WriteLine("Please enter your phone: ");
    string phone = Console.ReadLine();
    Console.WriteLine("Please enter you Mail address: ");
    string mail = Console.ReadLine();
    Console.WriteLine("Are you sure you want to save data? Y/N");
    string reply = Console.ReadLine().Trim().ToLower();
    if (reply == "y")
    {
        Contact contact = new Contact(name: name, surname: surname, mail: mail, phone: phone);
        repo.Add(contact);
        Console.WriteLine("Saved the data successfully! ");
    }
    else Console.WriteLine("Didn't save the data!"); ;
};


void ListData()
{
    var contacts = repo.GetAll();
    Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "Name", "Surname", "Phone", "Mail");
    Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "----------", "--------", "----------", "----------");

    foreach (var item in contacts)
    {
        Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", item.Name, item.Surname, item.Phone, item.Mail);
    }
    Console.WriteLine("Press d to remove contact or m to go back to the Start Menu");
    string reply = Console.ReadLine().Trim().ToLower();
    if (reply == "d")
    {
        Console.WriteLine("Available ids in database are: ");
        var allIds = repo.GetAll();
        foreach (var item in allIds)
        {
            Console.WriteLine(item.Id + " " + item.Name);
        }
    enteragain:
        Console.WriteLine("Enter id you want to delete: ");
        if (!Int32.TryParse(Console.ReadLine(), out int enteredId))
        {
            Console.WriteLine("Please enter Id");
            goto enteragain;
        }
        else
        {
            Contact user = repo.GetById(enteredId);
            repo.Delete(user);
        }

    }

};

void LookUp()
{
    Console.WriteLine("Enter the search keyword: ");
    string reply = Console.ReadLine();
    Console.WriteLine(reply);
    var result = repo.FindAll(c => c.Name == reply ||
    c.Phone == reply || c.Mail == reply || c.Surname == reply);
    Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "Name", "Surname", "Phone", "Mail");
    Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "----------", "--------", "----------", "----------");
    foreach (var item in result)
    {
        Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", item.Name, item.Surname, item.Phone, item.Mail);
    }
};