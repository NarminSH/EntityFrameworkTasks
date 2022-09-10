using System;
using System.Collections.Generic;

namespace CrudApp1.Models
{
    public partial class District
    {
        public District()
        {
            Towns = new HashSet<Town>();
        }

        public int Id { get; set; }
        public string DistrictName { get; set; } = null!;
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public string? Code { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<Town> Towns { get; set; }
    }
}
