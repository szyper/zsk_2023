using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_klasy
{
  internal class Program
  {
    class Address
    {
      public string City { get; set; }
      public string Street { get; set; }
      public string HouseNumber { get; set; }
      public string PostalCode { get; set; }
    }
    class Person
    {
      public string Name { get; set; }
      public string Surname { get; set; }
      public float Height { get; private set; }
      public float Weight { get; set; }
      public Address Address { get; set; }
      public void GetFullName()
      {
        Console.WriteLine($"{Name} {Surname}");
      }

      public string NameSurname()
      {
        return $"{Name} {Surname}";
      }

      public string GetData()
      {
        return $"Imię i nazwisko: {this.NameSurname()}, wzrost: {this.Height}cm, waga: {this.Weight}kg";
      }

      public void SetHeight(float height)
      {
        Height = height;
      }
    }

    class Student
    {
      public string StudentNumber { private get; set; }
      public string GetStudentNumber()
      {
        return $"Numer indeksu: {StudentNumber}";
      }
    }

    class Teacher
    {
      public List<string> Subjects { get; set; }
    }

    static void Main(string[] args)
    {
      //Person nowak = new Person() { Name = "Janusz"};
      Person nowak = new Person();
      Console.WriteLine("Imię: " + nowak.Name + "\n");
      nowak.Name = "Anna";
      nowak.Surname = "Pawlak";
      nowak.GetFullName();
      //nowak.Height = 111;
      nowak.SetHeight(177);
      Console.WriteLine("Wzrost: " + nowak.Height + "cm\n");

      Student s1 = new Student();
      s1.StudentNumber = "12345";
      //Console.WriteLine(s1.StudentNumber);
      Console.WriteLine(s1.GetStudentNumber());

      Teacher t1 = new Teacher();
      t1.Subjects = new List<string>() { "informatyka", "matematyka", "fizyka" };

      foreach (var item in t1.Subjects)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine(string.Join(", ", t1.Subjects));

      //nowak.Address.City = "Poznań";

      //Console.WriteLine($"Użytkownik pochodzi z {nowak.Address.City}");
      Console.WriteLine(nowak.GetData());

      Console.ReadKey();
    }
  }
}
