using ConsoleApp1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Dog reksio = new Dog("Reksio");
      Cat latek = new Cat("Łatek");

      reksio.OnSpeak += HandleOnSpeak;
      reksio.Speak();

      latek.OnSpeak += HandleOnSpeak;
      latek.Speak();

      latek.OnSpeak -= HandleOnSpeak;
      latek.Speak();


      Console.ReadKey();
    }

    private static void HandleOnSpeak(object sender, EventArgs e)
    {
      if (sender is Animal)
      {
        Animal animal = (Animal)sender;
        Console.WriteLine("Zdarzenie OnSpeak zgłoszone przez {0}", animal.Name);
      }
    }
  }
}
