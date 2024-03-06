using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_konstruktory.classes
{
  internal class Person
  {
    //statyczne pole, któe przechowuje liczbę obiektów klasy Person
    public static int Counter = 0;
    
    //właściwości
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public float Height { get; set; }

    //konstruktor statyczny jest wywoływany automatycznie, aby zainicjować klasę przed utworzeniem pierwszej instancji. Konstruktor statyczny jest wywoływany tylko raz, przed pierwszym użyciem typu. Nie może mieć parametrów ani modyfikatorów dostępu. Służy do inicjowania pól statycznych lub wykonywania innych operacji statycznych (wykonywanie dowolnego kodu, który jest związany z klasą a nie z jej obiektami np. ustawienie wartości domyślnych pól statycznych)
    static Person()
    {
      Console.WriteLine("Konstruktor statyczny klasy Person\n");
      //Counter++; 
    }

    //konstruktor domyślny jest bezparametrowy. Jeśłi klasa nie ma żadnego konstruktora parametrycznego, to konstruktor domyślny jest wywoływany przy tworzeniu obiektu. Inicjuje on wszystkie pola do ich wartości domyślnych. Jeśli zdefiniujemy jakiś konstruktor parametryczny, to nie otrzymamy automatycznie konstruktora domyślnego i możemy/musimy go samodzielnie zadeklarować

    public Person()
    {
      Console.WriteLine("Konstruktor domyślny klasy Person");
      Name = "nieznane";
      Surname = "nieznane";
      Counter++;
    }

    //konstruktor parametryczny ma co najmniej jeden parametr. Służy do inicjowania pól obiektu zgodnie z wartościami podanymi przy tworzeniu obiektu. Możemy mieć wiele konstruktorów parametrycznych, o ile różnią się liczbą lub/i typem parametrów 

    //konstruktor parametryczny z jednym parametrem
    public Person(string name)
    {
      Console.WriteLine("Konstruktor parametryczny klasy Person z jednym parametrem");
      Name = name;
      Counter++;
    }

    //konstruktor parametryczny z dwoma parametrami
    public Person(string name, string surname)
    {
      Console.WriteLine("Konstruktor parametryczny klasy Person z dwoma parametrami");
      Name = name;
      Surname = surname;
      Counter++;
    }

    //konstruktor parametryczny z trzema parametrami
    //this służy do wywołania innego konstruktora tej samej klasy, cyzli konstruktora z dwoma parametrami. Dzięki temu konstruktor z trzema parametrami nie musi inicjować pól Name, Surname a może skupić się na dodaniu pola Age. Jest to sposób na uniknięcie powtarzania kodu i zapewnienie spójności danych
    public Person(string name, string surname, int age) :this(name, surname)
    {
      Console.WriteLine("Konstruktor parametryczny klasy Person z trzema parametrami");
      Age = age;
      Counter++;
    }

    //konstruktor parametryczny z czterema parametrami
    public Person(string name, string surname, int age, float height) :this(name, surname, age)
    {
      Console.WriteLine("Konstruktor parametryczny klasy Person z czterema parametrami");
      Height = height;
      Counter++;
    }
    
  }
}
