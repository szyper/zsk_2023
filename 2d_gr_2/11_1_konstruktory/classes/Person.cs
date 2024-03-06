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
    public float Height { get; set; }

    //konstruktor statyczny jest wywoływany automatycznie, aby zainicjować klasę przed utworzeniem pierwszej instancji. Konstruktor statyczny jest wywoływany tylko raz, przed pierwszym użyciem typu. Nie może mieć parametrów ani modyfikatorów dostępu. Służy do inicjowania pól statyczncyh lub wykonywania innych operacji statycznych (wykonywanie dowolnego kodu, któy jest związany z klasą a nie z jej obibektami np. ustawienie wartości domyślnych dla pól statycznych)

    static Person()
    {
      Console.WriteLine("Konstruktor statyczny klasy Person\n");
      //Counter++;
    }

    //konstruktor domyślny jest bezparametrowy. Jeśli klasa nie ma żadnego konstruktora parametrycznego, to konstruktor domyślny jest wywoływany przy tworzeniu obiektu. Inicjujeon wszystkie pola do ich wartości domyślnych. Jeśli zdefiniujemy jakiś konstruktor parametryczny, to nie otrzymamy automatycznie konstruktora domyślnego i możemy/musimy go samodzielnie zadeklarować

    public Person()
    {
      Console.WriteLine("Konstruktor domyślny klasy Person");
      Name = "nieznane";
      Surname = "nieznane";
      Counter++;
    }

    //konstruktor parametryczny ma co najmniej jeden parametr. Służy do inicjowania pól obiektu zgodnie z wartościami podanymi przy tworzeniu obiektu. Możemy mieć wiele konstruktorów parametrycznych o ile różnią się liczbą lub typem parametrów

    //konstruktor parametryczny z jednym parametrem
    public Person(string name)
    {
      Console.WriteLine("Konstruktor parametryczny klasy Person z jednym parametrem");
      Name = name;
      Counter++;
    }
    
    //konstruktor parametyczny z dwoma parametrami
    public Person(string name, string surname)
    {
      Console.WriteLine("Konstruktor parametryczny klasy Person z dwoma parametrami");
      Name = name;
      Surname = surname;
      Counter++;
    }
    
    //konstruktor parametyczny z trzema parametrami
    public Person(string name, string surname, int age) :this(name, surname)
    {
      Console.WriteLine("Konstruktor parametryczny klasy Person z trzema parametrami");
      Age = age;
      Counter++;
    }

    //konstruktor parametyczny z czterema parametrami
    public Person(string name, string surname, int age, float height) :this(name, surname, age)
    {
      Console.WriteLine("Konstruktor parametryczny klasy Person z czterema parametrami");
      Height = height;
      Counter++;
    }

  }
}
