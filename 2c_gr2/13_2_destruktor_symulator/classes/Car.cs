using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_destruktor_symulator.classes
{
  internal class Car
  {
    public string Brand { get; set; }
    public string Model { get; set; }
    public bool IsDamaged { get; set; }

    public Car(string brand, string model)
    {
      Brand = brand;
      Model = model;
      IsDamaged = false;
    }

    ~Car()
    {
      Console.WriteLine($"amochód {Brand} {Model} został zezłomowany");
    }

    public void Drive()
    {
      if (IsDamaged)
      {
        Console.WriteLine($"Samochód {Brand} {Model} ma awarię!");
      }
      else
      {
        Console.WriteLine($"Samochód {Brand} {Model} porusza się");
      }
    }

    public void SimulateRandomDamage()
    {
      Random random = new Random();

      int damageType = random.Next( 1, 4); //losowanie liczby 1-3

      switch ( damageType )
      {
        case 1:
          Console.WriteLine($"Samochód {Brand} {Model} ma przebita oponę");
          break;
        case 2:
          Console.WriteLine($"Silnik samochodu {Brand} {Model} jest uszkodzony");
          break;
        case 3:
          Console.WriteLine($"Samochód {Brand} {Model} ma uszkodzone światło");
          break;
      }

      IsDamaged = true;

    }

  }
}
