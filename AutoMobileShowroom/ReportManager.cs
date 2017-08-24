using AutoMobileShowroom.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileShowroom
{
    public class ReportManager : IReportManager
    {
        public int RevenueReportGenerator(List<Invoice> invoiceList)
        {
            int revenue = 0;
            foreach(var invoice in invoiceList)
            {
                revenue += invoice.Cost;
            }
            return revenue;
        }

        public List<ServiceType> ServiceReportGenerator(List<Invoice> invoiceList)
        {
            List<ServiceType> serviceList = new List<ServiceType>();
            foreach(var invoice in invoiceList)
            {
                serviceList.Add(invoice.Service);
            }
            return serviceList;
        }
    }
}
