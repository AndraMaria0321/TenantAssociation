using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TenantsAss.DataModel;

namespace TenantsAss.AppLogic.Tests
{
    [TestClass]
    public class InvoiceLogicTest
    {
        [TestMethod]
        public void GetInvoiceByPrice_Return_IfInvoicePriceIsGreater()
        {
            //Arrange
            Apartment apartment = new Apartment()
            {
                ApartmentId = 3,
                ApartmentNo = 44,
                UserId = Guid.NewGuid(),
                BuildingId = 1,
                BuildingNo = "No.1"
            };

            List<Invoice> invoices = new List<Invoice>
            {
                new Invoice{InvoiceId = 1, UserName = "user", ApartmentNo = 44, Price = 100, Status = "Paid", ApartmentId = 3},
                new Invoice{InvoiceId = 2, UserName = "user", ApartmentNo = 44, Price = 250, Status = "Paid", ApartmentId = 3},
                new Invoice{InvoiceId = 3, UserName = "user", ApartmentNo = 44, Price = 300, Status = "Paid", ApartmentId = 3},
                new Invoice{InvoiceId = 4, UserName = "user", ApartmentNo = 44, Price = 190, Status = "Paid", ApartmentId = 3},
                new Invoice{InvoiceId = 5, UserName = "user", ApartmentNo = 44, Price = 110, Status = "Paid", ApartmentId = 3},
            };

            foreach (var invoice in invoices)
                apartment.Invoices.Add(invoice);

            //Act
            var retList = apartment.GetInvoiceByPrice(200);

            //Assert            
            Assert.AreEqual(2, retList.Count);
        }
    }
}
