
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Contact
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public Contact(string name, string surname, string mail, string phone)
    {
        Name = name;
        Surname = surname;
        Phone = phone;
        Mail = mail;
    }

    public override string ToString()
    {
        return Name + " " + Surname;
    }


}
