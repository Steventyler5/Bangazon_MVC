using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon_MVC.Models
{
    public class PaymentOption
    {
        public int IdPaymentOption { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public int IdCustomer { get; set}
    }
}
