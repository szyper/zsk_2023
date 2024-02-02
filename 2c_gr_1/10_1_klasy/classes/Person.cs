using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_klasy.classes
{
  enum Gender
  {
    kobieta,
    mężczyzna
  }
  internal class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    private float Height;
    public float Weight;
    public Address Address { get; set; }
    public Gender Gender { get; set; }

    public string GetData()
    {
      return "Imię i nazwisko: " + FirstName + " " + LastName + ", wzrost: " + Height + "cm, waga: " + Weight + "kg";
    }

    public void SetHeight(float height)
    {
      Height = height;
    }

    public float GetHeight()
    {
      return Height;
    }
  }
}
