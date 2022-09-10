using System;
using System.Collections.Generic;

namespace CrudApp1.Models
{
    public partial class Town
    {
        public int Id { get; set; }
        public string TownName { get; set; } = null!;
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public string? Code { get; set; }

        public virtual City? City { get; set; }
        public virtual Country? Country { get; set; }
        public virtual District? District { get; set; }
    }
}
