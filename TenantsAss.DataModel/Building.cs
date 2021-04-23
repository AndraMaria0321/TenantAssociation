using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenantsAss.DataModel
{
    public class Building
    {
        public int BuildingId { get; set; }

        public string StreetName { get; set; }

        public string StreetNo { get; set; }

        public string BuildingNo { get; set; }

        public ICollection<Apartment> Apartments { get; set; }
    }
}
