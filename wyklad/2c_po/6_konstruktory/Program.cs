using _6_konstruktory.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_konstruktory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //Person pd = new Person();
      //Person p1 = new Person("Janusz");
      //Person p2 = new Person("Janusz", "Nowak");
      //Person p3 = new Person("Janusz", "Nowak", 200);

      List<Person> people = new List<Person>();

      people.Add(new Person("Jan", "Kowal", 177));
      people.Add(new Person("Jan", "Kowal"));
      people.Add(new Person("Jan"));
      people.Add(new Person());

      people[0].Name = "Tomasz";
      Console.WriteLine("Imię: {0}", people[0].Name);

      Person p1 = new Person("Anna");
      people.Add((Person)p1);

      Person p2 = new Person("Paweł", "Nowak");
      people.Add(p2);

      //Console.WriteLine($"Liczba obiektów klasy Person: {Person.Counter}");
      Console.WriteLine($"Liczba obiektów klasy Person: {people.Count}");

      Console.ReadKey();
    }
  }
}
