using AspNetCoreIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIntro.Models
{
    public class CustomerListViewModel
    {
        public List<Customer> Customers{ get; set; }
        public List<String> Shops { get; set; }
    }
}
