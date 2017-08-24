using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMobileShowroom;

namespace AutoShowroomTest
{
    [TestClass]
    public class ShowroomFixture
    {
        [TestMethod]
        public void Car_Sales_Test()
        {
            ShowroomManager manager = new ShowroomManager();
            Assert.IsTrue(manager.Sales());
        }
        [TestMethod]
        public void Car_Lease_Test()
        {
            ShowroomManager manager = new ShowroomManager();
            Assert.IsTrue(manager.Lease());
        }
        [TestMethod]
        public void Car_Maintenance_Test()
        {
            ShowroomManager manager = new ShowroomManager();
            Assert.IsTrue(manager.Maintenance());
        }
        [TestMethod]
        public void Car_Test_Drive_Test()
        {
            ShowroomManager manager = new ShowroomManager();
            Assert.IsTrue(manager.TestDrive());
        }
    }
}
