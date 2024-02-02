﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_klasy.classes
{
  internal class Address
  {
    public string City { get; set; }
    public string Street { get; set; }
    public string HouseOfNumber { get; set; }
    public string PostalCode { get; set; }

    public string GetAddress()
    {
      return $"{City}, {Street} {HouseOfNumber}, {PostalCode}";
    }
  }
}
