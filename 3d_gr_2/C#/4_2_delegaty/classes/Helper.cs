using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_delegaty.classes
{
  internal class Helper
  {
    public static Car[] Filter(Car[] cars, Filter filter)
    {
      int count = 0;
      foreach (Car car in cars)
      {
        if (filter(car)) count++;
      }


    }
  }
}
