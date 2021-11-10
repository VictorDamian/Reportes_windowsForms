using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SalesListing
    {
        public int orderId { get; set; }
        public DateTime orderDate { get; set; }
        public string customer { get; set; }
        public string products { get; set; }
        public double totalAmount { get; set; }
    }
}
