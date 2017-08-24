using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMobileShowroom;
using System.Collections.Generic;

namespace AutoShowroomTest
{
    [TestClass]
    public class ReportManagerFixture
    {
        [TestMethod]
        public void Generation_of_Revenue_Report_Test()
        {
            List<Invoice> invoiceList = new List<Invoice>();
            var invoice1 = new Invoice(ServiceType.Sales,500000);
            var invoice2 = new Invoice(ServiceType.Lease, 12000);
            invoiceList.Add(invoice1);
            invoiceList.Add(invoice2);
            ReportManager manager = new ReportManager();
            manager.RevenueReportGenerator(invoiceList);
        }
        public void Generation_Of_Service_Report_Test()
        {

        }
    }
}
