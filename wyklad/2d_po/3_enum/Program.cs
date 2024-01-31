using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_enum
{
  enum DayOfWeek
  {
    poniedziałek,
    wtorek,
    środa,
    czwartek,
    piątek,
    sobota,
    niedziela
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      DayOfWeek dayOfWeek = DayOfWeek.poniedziałek;
      Console.WriteLine(dayOfWeek);

      for (int i = 0; i < 7; i++)
      {
        //Console.WriteLine(DayOfWeek[i]);
      }
      //dokończyć
      Console.ReadKey();
    }
  }
}
