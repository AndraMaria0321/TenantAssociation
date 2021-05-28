using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TenantsAss.DataModel;

namespace TenantsAss.AppLogic.Tests
{
    [TestClass]
    public class ApartmentLogicTest
    {
        [TestMethod]
        public void GetApartmentByNumber_Return_CountOfApartmentsWithThatNumber()
        {
            //Arrange
            Building building = new Building()
            {
                BuildingId = 5,
                StreetName = "Street 5",
                StreetNo = "No.5",
                BuildingNo = "55"
            };

            List<Apartment> apartments = new List<Apartment>
            {
                new Apartment{ApartmentId = 10, ApartmentNo = 11, UserId = Guid.NewGuid(), BuildingId = 5, BuildingNo = "55"},
                new Apartment{ApartmentId = 11, ApartmentNo = 33, UserId = Guid.NewGuid(), BuildingId = 5, BuildingNo = "55"},
                new Apartment{ApartmentId = 12, ApartmentNo = 11, UserId = Guid.NewGuid(), BuildingId = 5, BuildingNo = "55"},
                new Apartment{ApartmentId = 13, ApartmentNo = 22, UserId = Guid.NewGuid(), BuildingId = 5, BuildingNo = "55"},
                new Apartment{ApartmentId = 14, ApartmentNo = 11, UserId = Guid.NewGuid(), BuildingId = 5, BuildingNo = "55"},
            };

            foreach (var apartment in apartments)
                building.Apartments.Add(apartment);

            //Act
            var retList = building.GetApartmentByNumber(11);

            //Assert            
            Assert.AreEqual(3, retList.Count);
        }
    }
}
