using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework1.Models {
    public class User {
        public int Id { get; set; }
        public int CountryCode { get; set; }
        public int CityCode { get; set; }
        public int PhoneNumber { get; set; }
        public string TotalNumber { get; set; }
    }
}