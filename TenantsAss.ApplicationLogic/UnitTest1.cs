using Microsoft.VisualStudio.TestTools.UnitTesting;
using TenantsAss.DataModel;

namespace TenantsAss.ApplicationLogic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddInvoice()
        {
            //Arange
            Invoice invoice = new Invoice()
            {
                InvoiceId = new int(),
                UserName = "Test User Name",
                ApartmentNo = new int(),
                Price = new int(),
                Status = "Unpaid",
                DueDate = new System.DateTime(),
                Description = "Test Description",
                ApartmentId = new int();
            };
        }
    }
}
