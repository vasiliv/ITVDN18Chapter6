using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework2and3.Models {
    public class Order {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        // ararsebulma klientma rom ar ganaxorcielos ararsebuli produqtis shekveta
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}