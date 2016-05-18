using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon_MVC.Models
{
    public class CustomerOrder
    {
        public int IdCustomerId { get; set; }
        public string OrderNumber { get; set; }
        public string DateCreated { get; set; }
        public int IdCustomer { get; set; }
        public int IdPaymentOption { get; set; }
    }
}
