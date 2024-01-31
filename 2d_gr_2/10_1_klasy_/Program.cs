using _10_1_klasy.classes;
using _10_1_klasy_.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_klasy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person nowak = new Person();
      nowak.FirstName = "Janusz";
      //Console.WriteLine(nowak.FirstName);

      Console.WriteLine(nowak.GetData());

      Student s1 = new Student();
      s1.StudentNumber = "12345";

      Teacher t1 = new Teacher();
      t1.Subjects = new List<string> { "Informatyka", "Matematyka" };

      //foreach (var item in t1.Subjects)
      //{
      //  Console.WriteLine(item);
      //}

      t1.GetSubjects();
      Console.Clear();

      Person p1 = new Person();
      p1.Address = new Address();
      p1.Address.City = "Poznań";
      p1.Address.Street = "Polna";
      p1.Address.HouseNumber = "1a/2";
      p1.Address.PostalCode = "12-345";

      Console.WriteLine(p1.Address.GetAddress());
      p1.Gender = Gender.mężczyzna;
      Console.WriteLine("Płeć: " + p1.Gender);

      p1.DateOfBirth = DateTime.Now;
      Console.WriteLine("Data i czas: {0}", p1.DateOfBirth); //Data i czas: 01/29/2024 11:15:48

      p1.DateOfBirth = new DateTime(2000, 1, 22);
      Console.WriteLine("Data i czas: {0}", p1.DateOfBirth); //Data i czas: 01/22/2000 00:00:00

      p1.DateOfBirth = new DateTime(2000, 1, 22, 11, 17, 22);
      Console.WriteLine("Data i czas: {0}", p1.DateOfBirth); //Data i czas: 01/22/2000 11:17:22

      Console.WriteLine("Czas: {0}", p1.DateOfBirth.ToShortTimeString()); //Czas: 11:17
      Console.WriteLine("Czas: {0}", p1.DateOfBirth.ToLongTimeString()); //Czas: 11:17:22

      Console.WriteLine("Data: {0}", p1.DateOfBirth.ToShortDateString()); //Data: 01/22/2000
      Console.WriteLine("Data: {0}", p1.DateOfBirth.ToLongDateString()); //Data: Saturday, 22 January 2000

      Console.ReadKey();
    }
  }
}
