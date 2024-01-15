using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _2_dziedziczenie.classes
{
    internal class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseOfNumber { get; set; }
        public string PostalCode { get; set; }

        public Address(string city, string street, string houseOfNumber, string postalCode)
        {
            City = city;
            Street = street;
            HouseOfNumber = houseOfNumber;
            PostalCode = postalCode;
        }
    }
}
