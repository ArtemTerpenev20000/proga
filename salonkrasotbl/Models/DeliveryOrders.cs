using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace salonkrasotbl.Models
{
    public class DeliveryOrders
    {
        public int ID { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Orders { get; set; }
    }
}