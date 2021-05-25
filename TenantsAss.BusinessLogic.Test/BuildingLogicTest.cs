using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TenantsAss.DataModel;

namespace TenantsAss.BusinessLogic.Test
{
    [TestClass]
    public class BuildingLogicTest
    {
        [TestMethod]
        public void GetApartmentsWithApartmentNoGreaterThan_Returns_OnlyApartmentsWithApartmentNoGT()
        {
            //Arrange

            Building building = new Building()
            {
                StreetName = "Test Street Name",
                StreetNo = "Test Street No",
                BuildingNo = "Test building no"
            };

            List<Apartment> apartments = new List<Apartment>
                                    {
                                        new Apartment {  ApartmentNo = 1, UserName="User1@user.com", BuildingNo ="1" },
                                        new Apartment {  ApartmentNo = 2, UserName="User1@user.com", BuildingNo ="1" },
                                        new Apartment {  ApartmentNo = 3, UserName="User1@user.com", BuildingNo ="1" },
                                        new Apartment {  ApartmentNo = 4, UserName="User1@user.com", BuildingNo ="1" },

                                    };
            foreach (var apartment in apartments)
                building.Apartments.Add(apartment);

            //Act

            var retList = building.GetApartmentsWithApartmentNoGreaterThan(2);

            //Assert            
            Assert.AreEqual(3, retList.Count);
            var collectionEnum = retList.GetEnumerator();
            collectionEnum.MoveNext();

        }
    }
}
