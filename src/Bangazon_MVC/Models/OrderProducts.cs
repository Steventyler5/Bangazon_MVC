using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon_MVC.Models
{
    public class OrderProducts
    {
        public int IdOrderProducts { get; set; }
        public int IdProduct { get; set; }
        public int IdCustomerOrder { get; set; }
    }
}
