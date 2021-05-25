using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TenantsAss.DataModel;

namespace TenantsAss.BusinessLogic.Test
{
    [TestClass]
    public class ApartmentLogicTest
    {
        [TestMethod]
        public void GetInvoicesWithPriceLowerThanAndPaid_Returns_OnlyInvoicesWithPriceLTAndPaid()
        {
            //Arrange

            Apartment apartment = new Apartment()
            {
                ApartmentNo = 13,
                UserId = Guid.NewGuid(),
                UserName = "User1@user.com",
                BuildingNo = "Test building no"
            };

            List<Invoice> invoices = new List<Invoice>
                                    {
                                        new Invoice { UserName="User1@user.com", ApartmentNo = 13, Price = 133, Status = "paid"},
                                        new Invoice { UserName="User1@user.com",ApartmentNo = 13, Price = 13, Status = "unpaid"},
                                        new Invoice { UserName="User1@user.com",ApartmentNo = 13, Price = 200, Status = "paid"},
                                        new Invoice { UserName="User1@user.com",ApartmentNo = 13, Price = 458, Status = "paid"},

                                    };
            foreach (var invoice in invoices)
                apartment.Invoices.Add(invoice);

            //Act

            var retList = apartment.GetInvoicesWithPriceLowerThanAndPaid(300, "paid");

            //Assert            
            Assert.AreEqual(2, retList.Count);
            var collectionEnum = retList.GetEnumerator();
            collectionEnum.MoveNext();

        }
    }
}
