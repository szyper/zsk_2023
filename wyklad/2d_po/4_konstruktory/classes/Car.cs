using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_konstruktory.classes
{
  internal class Car
  {
    public string Brand { get; set; }
    public string Model { get; set; }
    private float price { get; set; }

    public static int Counter = 0;

    public Car(string Brand, string model)
    {
      Console.WriteLine("Konstruktor parametryczny z dwoma parametrami");
      this.Brand = Brand;
      Model = model;
      Counter++;
    }

    public Car(string brand, string model, float price) : this(brand, model)
    {
      this.price = price;
      Counter++;
    }

    public Car()
    {
      Counter++;
    }

    public void setPrice(float price)
    {
      this.price = price;
    }
  }
}
