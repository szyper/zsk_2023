using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_konstruktory.classes
{
  internal class Person
  {
    //statyczne, pola które przechowuje liczbę obiektów klasy Person
    public static int Counter = 0;

    //właściwości
    public string Name { get; set; }
    public string Surname { get; set; }

    //konstruktor statyczny jest wywoływany automatycznie, aby zainicjować klasę przed utworzeniem pierwszej instancji.Konstruktor statyczny jest wywoływany tylko raz, przed pierwszym użyciem typu. Nie może mieć parametrów ani modyfikatorów dostępu. Służy do inicjowania pól statycznych lub wykonywania innych operacji statycznych (wykonywanie kodu, który jest związany z klasą a nie z jej obiektami np. ustawianie wartośći domyślnych dla pól statycznych)

    static Person()
    {
      Console.WriteLine("Statyczny konstruktor klasy Person");
      Counter++;
    }

    //konstruktor domyślny
    /*public Person()
    {
        Console.WriteLine("Konstruktor domyślny klasy Person");
    }*/

    //konstruktor parametryczny
    public Person(string name)
    {
      Name = name;
    }

  }
}

