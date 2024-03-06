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
    public int Age { get; set; }

    //konstruktor statyczny jest wywoływany automatycznie, aby zainicjować klasę przed utworzeniem pierwszej instancji. Konstruktor statyczny jest wywoływany tylko raz, przed pierwszym użyciem typu. Nie może mieć parametrów ani modyfikatorów dostępu. Służy do inicjowania pól statycznych lub wykonywania innych operacji sattycznych (wykonywanie dowolnego kodu, który jest związany z kalsą a nie z jej obiektami np. ustawienie wartości domoślnych dla pól statycznych)

    static Person()
    {
      Console.WriteLine("Statyczny konstruktor klasy Person\n");
      //Counter++;
    }

    //konstruktor domyślny jest bezparametrowy. Jeśli klasa nie ma żadnego konstruktora parametrycznego, to konstruktor domyślny jest wywoływany przy tworzeniu obiektu. Inicjuje on wszystkie pola do ich wartości domyślnych. Jeśli zdefiniujemy jakiś konstruktor parametryczny, to nie otrzymamy automatycznie konstruktora domyślnego i możemy/musimy go samodzielnie zadeklarować
    public Person()
    {
      Console.WriteLine("Konstruktor domyślny z klasy Person");
      Counter++;
    }

    //konstruktor parametryczny z jednym parametrem
    public Person(string name)
    {
      Console.WriteLine("Konstruktor parametryczny z klasy Person z jednym parametrem");
      Name = name;
      Counter++;
    }

    //konstruktor parametryczny z dwoma parametrami
    public Person(string name, string surname)
    {
      Console.WriteLine("Konstruktor parametryczny z klasy Person z dwoma parametrami");
      Name = name;
      Surname = surname;
      Counter++;
    }

    //konstruktor parametryczny z trzema parametrami
    //this służy do wywołania innego konstruktora tej samej klasy, czyli konstruktora parametrycznego z dwoma parametrami. Dzięki temu konstruktor z trzema parametrami nie musi inicjować pól Name, Surname a może skupić się na dodaniu pola Age. Jest to sposób na uniknięcie powtarzania kodu i zapewnienie spójności danych
    public Person(string name, string surname, int age) : this(name, surname)
    {
      Console.WriteLine("Konstruktor parametryczny z klasy Person z trzema parametrami");
      Age = age;
      Counter++;
    }

    public string GetData()
    {
      return $"Imię i nazwisko: {Name} {Surname}, wiek: {Age}";
    }
  }
}
