using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_1_destruktory.classes
{
  internal class Car
  {
    private string name;
    private double speed;

    public Car(string name, double speed)
    {
      this.name = name;
      this.speed = speed;
    }

    ~Car()
    {
      Console.WriteLine($"Samochód {name} został zniszczony.");
    }

    public void StartRace()
    {
      Console.WriteLine($"Samochód {name} rusza na wyścig!");
    }
  }
}
