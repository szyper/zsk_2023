using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_parking.classes
{
  internal class Parking
  {
    public string Name { get; set; }
    public Car[] cars { get; set; }

    public void AddCar(Car car)
    {
      for (int i = 0; i < cars.Length; i++)
      {
        if (cars[i] == null)
        {
          cars[i] = car;
          Console.WriteLine($"\nDodano samochód do cars[{i}]");
          return;
        }
      }
      Console.WriteLine("\nBrak miejsc parkingowych");
    }
  }
}
