using _11_1_konstruktory.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_konstruktory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<Person> persons = new List<Person>();
      Person p0 = new Person();
      Person p = new Person("Janusz");
      Person p2 = new Person("Anna", "Nowak");
      Person p3 = new Person("Anna", "Nowak", 20);

      persons.Add(p0);
      persons.Add(p);
      persons.Add(p2);
      persons.Add(p3);

      //Console.WriteLine("\n\nLiczba obiektów klasy Person: {0}", Person.Counter);
      Console.WriteLine("\n\nLiczba obiektów klasy Person: {0}", persons.Count);

      Console.ReadKey();
    }
  }
}
