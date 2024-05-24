﻿using _14_1_dziedziczenie.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_dziedziczenie
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Machine machine = new Machine("M-100");

      Excavator excavator = new Excavator("E-200");
      excavator.Start();
      excavator.Stop("awaria silnika");
      excavator.Work();
      //excavator.Dig();

      Console.ReadKey();
    }
  }
}
