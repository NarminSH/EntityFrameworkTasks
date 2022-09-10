using System;
using System.Collections.Generic;

namespace CrudApp1.Models
{
    public partial class City
    {
        public City()
        {
            Districts = new HashSet<District>();
            Towns = new HashSet<Town>();
        }

        public int Id { get; set; }
        public string CityName { get; set; } = null!;
        public int CountryId { get; set; }
        public string? Code { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<Town> Towns { get; set; }
    }
}
