using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileShowroom
{
    public class InvoiceManager:IInvoiceManager
    {
        public List<Invoice> InvoiceList { get; }

        public InvoiceManager()
        {
            InvoiceList = new List<Invoice>();
        }
        public bool AddInvoiceToList(Invoice invoice)
        {
            InvoiceList.Add(invoice);
            return true;
        }
        public List<Invoice> GetInvoiceList()
        {
            return InvoiceList;
        }
    }
}
