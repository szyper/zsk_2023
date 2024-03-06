using _4_konstruktory.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_konstruktory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Car car = new Car("Fiat", "126p");
      car.setPrice(10);

      Car car1 = new Car("Ford", "Panda", 100);

      Car car2 = new Car();

      Console.WriteLine("Ilość obiektów: " + Car.Counter);

      List<Car> cars = new List<Car>();
      cars.Add(car);
      cars.Add(car2);
      cars.Add(car1);

      Console.WriteLine("Ilość obiektów: " + cars.Count);


      Console.ReadKey();
    }
  }
}
