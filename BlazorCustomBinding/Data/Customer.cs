using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCustomBinding.Data
{
    public class Customer
    {

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        // Making this an int? fixed compiler error
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
