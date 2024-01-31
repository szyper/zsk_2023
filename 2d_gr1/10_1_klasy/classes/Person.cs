using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_klasy.classes
{
  public enum Gender 
  { 
    kobieta, 
    mężczyzna 
  
  }

  internal class Person
    {
        public string FirstName { private get; set; }
        public string LastName { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public Address Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string GetData()
        {
            return "Imię i nazwisko: " + FirstName + " " + LastName + ", wzrost: " + Height + "cm, waga: " + Weight + "kg";
        }
    }
}
