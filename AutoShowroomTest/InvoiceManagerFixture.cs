using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMobileShowroom;

namespace AutoShowroomTest
{
    [TestClass]
    public class InvoiceManagerFixture
    {
        [TestMethod]
        public void Addition_Of_Invoice_To_Invoice_List_Test()
        {
            InvoiceGenerator generator = new InvoiceGenerator();
            var invoice =new Invoice("Sales", 120000);
            InvoiceManager manager = new InvoiceManager();
            Assert.IsTrue(manager.AddInvoiceToList(invoice));
        }
    }
}
