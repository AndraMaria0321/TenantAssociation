using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenantsAss.DataModel
{
    public class Apartment
    {
        public int ApartmenTId { get; set; }

        public int ApartmentNo { get; set; }

        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int BuildingId { get; set; }

        public string BuildingNo { get; set; }

        public User User { get; set; }

        public Building Building { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
