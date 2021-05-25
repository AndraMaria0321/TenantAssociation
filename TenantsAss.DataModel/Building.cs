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


        public Building() {

            Apartments = new List<Apartment>();
        }

        public IReadOnlyCollection<Apartment> GetApartmentsWithApartmentNoGreaterThan(int apNo) {
            
            var apartmentsList = new List<Apartment>();
            foreach (var apartment in Apartments) {

                var apartmentNo = apartment.ApartmentNo;
                if (apartmentNo >= apNo) { apartmentsList.Add(apartment); }
            }

            return apartmentsList.AsReadOnly();

        }
    }
}
