using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
  internal class Dog : Animal
  {
    public Dog(string name) : base(name)
    {
    }

    public override void Speak()
    {
      Console.WriteLine("Hau hau");
      RaiseOnSpeak();
    }
  }
}
