using System.Drawing;
using _10_2_parking.classes;

namespace _10_2_parking
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Car c1 = new Car { Brand = "Ford", Model = "Ka"};
      Car c1 = new Car();

      c1.SetBrand("Ford");
      Console.WriteLine(c1.Brand);
      c1.SetModel("Ka");
      c1.SetYear(2000);
      c1.SetColor(Color.Blue);

      Parking p1 = new Parking { Name = "Center", Cars = new Car[5] };

    }
  }
}
