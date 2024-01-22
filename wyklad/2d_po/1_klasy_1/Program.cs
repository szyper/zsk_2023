using System.Collections.Generic;
using System;
using _1_klasy.classes;

namespace dziedziczenie_wzor
{
  internal class Program
  {
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

      p1.DateOfBirth = DateTime.Now;
      Console.WriteLine("Data: " + p1.DateOfBirth); //Data: 22.01.2024 14:40:57
      p1.DateOfBirth = new DateTime();
      Console.WriteLine("Data: " + p1.DateOfBirth); //Data: 01.01.0001 00:00:00

      p1.DateOfBirth = new DateTime(2000 - 1 - 2);
      Console.WriteLine("Data: " + p1.DateOfBirth); //Data: 01.01.0001 00:00:00

      p1.DateOfBirth = new DateTime(2000,1,2);
      Console.WriteLine("Data: " + p1.DateOfBirth); //Data: 02.01.2000 00:00:00

      p1.DateOfBirth = new DateTime(2000, 1, 2);
      Console.WriteLine("Data: " + p1.DateOfBirth.ToShortDateString()); //Data: 02.01.2000

      Console.WriteLine("Godzina: " + p1.DateOfBirth.ToShortTimeString()); //Godzina: 00:00

      p1.DateOfBirth = new DateTime(2000, 1, 2, 14, 50, 00);
      Console.WriteLine("Godzina: " + p1.DateOfBirth.ToShortTimeString()); //Godzina: 14:50

      Console.WriteLine("Godzina: " + p1.DateOfBirth.ToLongTimeString()); //Godzina: 14:50:00


      //p1.DateOfBirth = new DateTime(2000, 1, 2, 30, 50, 00); //błąd
      Console.WriteLine("Godzina: " + p1.DateOfBirth.ToLongTimeString()); //Godzina: 14:50:00



      Console.ReadKey();
    }
  }
}