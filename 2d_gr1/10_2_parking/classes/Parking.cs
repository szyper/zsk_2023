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
    public Car[] Cars { get; set; }

    public void AddCar(Car car)
    {
      for (int i = 0; i < Cars.Length; i++)
      {
        if (Cars[i] == null)
        {
          Cars[i] = car;
          Console.WriteLine($"Dodano samochód na pozycji {i}");
          return;
        }
      }
      Console.WriteLine("Brak wolnych miejsc na parkingu");
    }
  }
}
