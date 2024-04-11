using _13_1_destruktory.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_destruktory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Car car1 = new Car("Ferrari", "F430", 300);
      Car car2 = new Car("Fiat", "126p", 120);
      Car car3 = new Car("Porsche", "x", 330);

      car1.StartRace();
      car2.StartRace();
      car3.StartRace();

      car2 = null;

      Console.ReadKey();
    }
  }
}
