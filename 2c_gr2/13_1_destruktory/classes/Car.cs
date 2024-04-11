using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_destruktory.classes
{
  internal class Car
  {
    private string brand;
    private string model;
    private double speed;


    public Car(string brand, string model, double speed)
    {
      this.brand = brand;
      this.model = model;
      this.speed = speed;
    }

    ~Car()
    {
      Console.WriteLine($"Samochód {brand} {model} został zniszczony");
    }

    public void StartRace()
    {
      Console.WriteLine($"Samochód {brand} {model} rozpoczął wyścig");
    }
  }
}
