using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using AutoMobileShowroom;
namespace AutoShowroomTest
{
    public class InvoiceGeneratorFixture 
    {
        [Fact]
        public void Invoice_Generation_Test()
        {
            InvoiceGenerator generator = new InvoiceGenerator();
            Assert.True(generator.GenerateInvoice("Sales", 120000));
            
        }
    }
}
