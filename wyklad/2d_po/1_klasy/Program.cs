using System.Collections.Generic;
using System;

namespace dziedziczenie_wzor
{
  internal class Program
  {

    // Zdefiniuj klasę Address, która ma pola city, street, houseNumber i postalCode jako właściwości
    class Address
    {
      public string City { get; set; }
      public string Street { get; set; }
      public string HouseNumber { get; set; }
      public string PostalCode { get; set; }
    }

    // Zdefiniuj klasę bazową Person, która ma pola name, surname, dateOfBirth i address oraz konstruktor przyjmujący te wartości
    class Person
    {
      public string Name { get; set; }
      public string Surname { get; set; }
      //public DateTime DateOfBirth { get; set; }
      //public Address Address { get; set; } // Dodaj pole address typu Address

      // Dodaj metodę, która zwraca pełne imię i nazwisko osoby
      public string GetFullName()
      {
        return Name + " " + Surname;
      }

    }

    // Zdefiniuj klasę pochodną Student, która dziedziczy po klasie Person i ma dodatkowe pole studentNumber oraz konstruktor przyjmujący te wartości
    class Student
    {
      public string StudentNumber { get; set; }
    }

    // Zdefiniuj klasę pochodną Teacher, która dziedziczy po klasie Person i ma dodatkowe pole subjects oraz konstruktor przyjmujący te wartości
    class Teacher
    {
      public List<string> Subjects { get; set; }
    }

    static void Main(string[] args)
    {
      // Aby utworzyć nowe obiekty każdej klasy, musisz użyć słowa kluczowego new i podać wartości pól w konstruktorze

      // Utwórz obiekt klasy Person i przypisz go do zmiennej p1
      Person p1 = new Person();
      Person p2 = new Person();
      p2.Surname = "Nowak";
      p2.Name = "Jan";

      Console.ReadKey();
    }
  }
}