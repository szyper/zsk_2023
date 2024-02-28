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

    //public Car() { }

    public Car(string brand, string model)
    {
      Brand = brand;
      Model = model;
    }

    public Car(string brand, string model, float price) : this(brand, model)
    {
      this.price = price;
    }

    public void setPrice(float price)
    {
      this.price = price;
    }
  }
}
