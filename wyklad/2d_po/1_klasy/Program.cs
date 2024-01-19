﻿using System.Collections.Generic;
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

      public string GetAddress()
      {
        return $"{City}, ulica: {Street} {HouseNumber}, kod pocztowy: {PostalCode}";
      }
    }

    // Zdefiniuj klasę bazową Person, która ma pola name, surname, dateOfBirth i address oraz konstruktor przyjmujący te wartości
    class Person
    {
      public string Name { get; set; }
      public string Surname { get; set; }
      public Address Address { get; set; }
      //public DateTime DateOfBirth { get; set; }
      

      // Dodaj metodę, która zwraca pełne imię i nazwisko osoby
      public string GetFullName()
      {
        return $"{Name} {Surname}";
      }

    }

    // Zdefiniuj klasę pochodną Student, która dziedziczy po klasie Person i ma dodatkowe pole studentNumber oraz konstruktor przyjmujący te wartości
    class Student
    {
      public string StudentNumber { get; private set; }

      public void SetStudentNumber(string x)
      {
        StudentNumber = x;
      }
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


      p1.Name = "Janusz";
      p1.Surname = "Nowak";
      p1.Address = new Address();
      p1.Address.City = "Poznań";
      p1.Address.Street = "Polna";
      p1.Address.HouseNumber = "1c/4";
      p1.Address.PostalCode = "12-345";
      Console.WriteLine(p1.GetFullName() + "\nAdres: " + p1.Address.GetAddress());

      Student s1 = new Student();
      //s1.StudentNumber = "12345";
      s1.SetStudentNumber("54321");
      Console.WriteLine(s1.StudentNumber);

      Teacher t1 = new Teacher();
      t1.Subjects = new List<string>() { "informatyka", "matematyka", "geografia"};

      Console.WriteLine(string.Join(", ", t1.Subjects));

      foreach (var item in t1.Subjects)
      {
        Console.WriteLine(item);
      }

      Console.ReadKey();
    }
  }
}