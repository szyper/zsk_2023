﻿using _11_1_konstruktory.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_konstruktory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person p0 = new Person();
      Person p1 = new Person("Janusz");

      Console.ReadKey();
    }
  }
}