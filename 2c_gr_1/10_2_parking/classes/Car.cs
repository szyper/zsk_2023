using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_parking.classes
{
  internal class Car
  {
    public string Brand { get; set; }
    public string Model { get; set; }
    public ushort Year { get; set; }
    public Color Color { get; set; }
    public void ShowInformation()
    {
      Console.WriteLine($"To jest {Brand} {Model} z {Year}, kolor: {Color}");
    }
  }
}
