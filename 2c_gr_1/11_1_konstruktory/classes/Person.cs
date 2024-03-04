using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_konstruktory.classes
{
  internal class Person
  {
    //statyczne pole, które przechowuje liczbę obiektów klasy Person
    public static int Counter = 0;

    //właściwości
    public string Name { get; set; }
    public string Surname { get; set; }

    //konstruktor statyczny jest wywoływany automatycznie, aby zainicjować klasę przed utworzeniem pierwszej instancji. Konstruktor statyczny jest wywoływany tylko raz, przed pierwszym użyciem typu. Nie może mieć parametrów ani modyfikatorów dostępu. Służy do inicjowania pól statycznych lub wykonywania innych operacji sattycznych (wykonywanie dowolnego kodu, który jest związany z kalsą a nie z jej obiektami np. ustawienie wartości domoślnych dla pól statycznych)

    static Person()
    {
      Console.WriteLine("Statyczny konstruktor klasy Person");
      Counter++;
    }

    //konstruktor domyślny

    //konstruktor parametryczny z jednym parametrem
    public Person(string name)
    {
      Name = name;
    }

  }
}
