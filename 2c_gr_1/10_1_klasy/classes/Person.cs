using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_klasy.classes
{
  [Flags]
  enum Role
  {
    Student = 1,
    Teacher = 2,
    Manager = 4,
    Director = 8
  }

  enum Permission
  {
    Administrator = 1,
    Modifier = 2,
    User = 3,
    Guest = 4
  }

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
    public DateTime DateOfBirth { get; set; }
    public Address Address { get; set; }
    public Gender Gender { get; set; }
    public Permission Permission { get; set; }
    public Role Role { get; set; }

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
