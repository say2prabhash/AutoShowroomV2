using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileShowroom
{
    public class ShowroomManager
    {
        public bool Sales()
        {
            InvoiceGenerator generator = new InvoiceGenerator();
           return generator.GenerateInvoice(ServiceType.Sales, 200000);
           
        }
        public bool Maintenance()
        {
            InvoiceGenerator generator = new InvoiceGenerator();
            return generator.GenerateInvoice(ServiceType.Maintenance, 2000);
        }
        public bool TestDrive()
        {
            InvoiceGenerator generator = new InvoiceGenerator();
            return generator.GenerateInvoice(ServiceType.TestDrive, 0);
        }
        public bool Lease()
        {
            InvoiceGenerator generator = new InvoiceGenerator();
            return generator.GenerateInvoice(ServiceType.Lease, 20000);
        }
    }
}
