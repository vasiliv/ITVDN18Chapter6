using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework2and3.Models {
    public class Customer {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationData { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
    }
}