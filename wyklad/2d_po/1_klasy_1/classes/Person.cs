using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_klasy.classes
{
  // Zdefiniuj klasę bazową Person, która ma pola name, surname, dateOfBirth i address oraz konstruktor przyjmujący te wartości
  internal class Person
  {
    public string Name { get; set; }
    public string Surname { get; set; }
    public Address Address { get; set; }
    public DateTime DateOfBirth { get; set; }





    // Dodaj metodę, która zwraca pełne imię i nazwisko osoby
    public string GetFullName()
    {
      return $"{Name} {Surname}";
    }
  }
}
