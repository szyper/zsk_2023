using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_konstruktory.classes
{
  internal class Person
  {
    public static int Counter = 0;
    public string Name { get; set; }
    public string Surname { get; set; }
    public float Height { get; set; }

    static Person() 
    {
      Console.WriteLine("Konstruktor statyczny klasy Person");
      //Counter++;
    }

    public Person() 
    { 
      Console.WriteLine("Konstruktor domyślny klasy Person");
      //Counter++;
    }

    public Person(string name)
    {
      Console.WriteLine("Konstruktor parametryczny klasy Person z jednym parametrem");
      Name = name;
      //Counter++;
    }

    public Person(string name, string surname)
    {
      Console.WriteLine("Konstruktor parametryczny klasy Person z dwoma parametrem");
      Name = name;
      Surname = surname;
      //Counter++;
    }

    public Person(string name, string surname, float height) :this(name, surname)
    {
      Console.WriteLine("Konstruktor parametryczny klasy Person z trzema parametrami");
      Height = height;
      //Counter++;
    }
  }
}
