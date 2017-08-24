using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileShowroom.Contracts
{
    interface IReportManager
    {
        int RevenueReportGenerator(List<Invoice> invoiceList);
        List<ServiceType> ServiceReportGenerator(List<Invoice> invoiceList);
    }
}
