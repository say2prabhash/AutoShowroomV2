using AutoMobileShowroom.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileShowroom
{
    public class InvoiceGenerator
    {
        public bool GenerateInvoice(ServiceType service, int cost)
        {
            var invoice = new Invoice(service, cost);
            InvoiceManager manager = new InvoiceManager();
            return manager.AddInvoiceToList(invoice);
        }
    }
}
