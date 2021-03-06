using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenantsAss.DataModel
{
    public class Apartment
    {
        public int ApartmentId { get; set; }

        public int ApartmentNo { get; set; }

        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public int BuildingId { get; set; }

        public string BuildingNo { get; set; }

        public Building Building { get; set; }

        public ICollection<Invoice> Invoices { get; set; }

        public Apartment() {

            Invoices = new List<Invoice>();
        }

        public IReadOnlyCollection<Invoice> GetInvoicesWithPriceLowerThanAndPaid(int price1, string status1)
        {

            var invoicesList = new List<Invoice>();
            foreach (var invoice in Invoices)
            {

                var price = invoice.Price;
                var status = invoice.Status;
                if (price < price1 && status == status1) { invoicesList.Add(invoice); }
            }

            return invoicesList.AsReadOnly();

        }
    }
}
