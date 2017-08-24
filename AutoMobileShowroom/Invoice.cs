using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileShowroom
{
    public class Invoice
    {
        public ServiceType Service{ get; }
        public int Cost { get;}
        public Invoice(ServiceType service,int cost)
        {
            Service= service;
            Cost = cost;
        }
    }
}
