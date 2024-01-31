using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_klasy_.classes
{
  internal class Address
  {
    public string City { get; set; }
    public string Street { get; set; }
    public string HouseNumber { get; set; }
    public string PostalCode { get; set; }

    public string GetAddress()
    {
      return $"Miasto: {City}, ulica: {Street} {HouseNumber}, kod pocztowy: {PostalCode}";
    }
  }
}
