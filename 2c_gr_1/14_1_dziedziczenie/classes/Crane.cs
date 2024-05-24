using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_dziedziczenie.classes
{
  internal class Crane : Machine
  {
    public Crane(string name) : base(name)
    {
    }

    public override void Start()
    {
      base.Start();
      Console.WriteLine($"{Name} rozpoczyna podnoszenie ładunku");
    }

    //symulacja podnoszenia ładunku
    public void Lift()
    {
      Console.WriteLine($"{Name} podnosi ładunek");
    }

    public void Work()
    {
      Lift();
    }
  }
}
