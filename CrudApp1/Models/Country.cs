using System;
using System.Collections.Generic;

namespace CrudApp1.Models
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
            Districts = new HashSet<District>();
            Towns = new HashSet<Town>();
        }

        public int Id { get; set; }
        public string CountryName { get; set; } = null!;
        public string? Code { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<Town> Towns { get; set; }
    }
}
