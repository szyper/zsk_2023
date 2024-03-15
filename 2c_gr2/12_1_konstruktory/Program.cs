using _12_1_konstruktory.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_konstruktory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person p0 = new Person();
      Person p1 = new Person("Jan");
      Person p2 = new Person("Jan", "Nowak");
      Person p3 = new Person("Jan", "Nowak", 20);
      Person p4 = new Person("Jan", "Nowak", 20, 175.5f);

      Console.WriteLine("Ilość obiektów klasy Person: {0}", Person.Counter); //8

      List<Person> persons = new List<Person>();
      /*
      persons.Add(p0);
      persons.Add(p1);
      persons.Add(p2);
      persons.Add(p3);
      persons.Add(p4);
      */
      
      persons.AddRange(new []{ p0, p1, p2, p3, p4});
      Console.WriteLine("Ilość obiektów klasy Person: {0}", persons.Count); //5
      
      
      Console.ReadKey();
    }
  }
}
