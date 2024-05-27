using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_dziedziczenie.classess
{
  internal class Excavator : Machine
  {
    public int DigDepth { get; set; }

    public Excavator(string name, int digDepth) : base(name)
    {
      DigDepth = digDepth;
    }

    public override void Start()
    {
      //base.Start();
      Console.WriteLine($"{Name} rozpoczyzna proces kopania");
    }

    public override void Stop() 
    {
      Console.WriteLine($"{Name} kończy proces kopania");
    }

    public override void Work()
    {
      Console.WriteLine($"{Name} kopie na głębokość {DigDepth} metrów");
    }

    public void ChangeDigDepth(int newDepth)
    {
      DigDepth = newDepth;
      Console.WriteLine($"{Name} jest teraz ustawiona na głębokość kopania {DigDepth} metrów");
    }
  }
}
