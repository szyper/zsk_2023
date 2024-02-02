using _11_1_klasy.classes;

namespace _11_1_klasy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person p1 = new Person();
      //p1.FirstName = "Janusz";
      p1.SetName("Paweł");
      p1.LastName = "Nowak";
      Console.WriteLine($"Imię: {p1.FirstName}");
      Console.WriteLine($"Nazwisko: {p1.LastName}");

      p1.Address = new Address();
      p1.Address.City = "Poznań";
      p1.Address.Street = "Polna";
      p1.Address.HouseOfNumber = "1c/3";
      p1.Address.PostalCode = "11-234";

      Console.WriteLine($"\nImię i nazwisko: {p1.FirstName} {p1.LastName}\nAdres: {p1.Address.GetAddress()}\n\n");

      p1.Gender = Gender.mężczyzna;
      Console.WriteLine($"Płeć: {p1.Gender}");

      p1.DateOfBirth = DateTime.Now;
      Console.WriteLine(p1.DateOfBirth); //02/01/2024 08:16:23
      Console.WriteLine(p1.DateOfBirth.Year); //2024

      p1.DateOfBirth = new DateTime(2020, 1, 10);
      Console.WriteLine(p1.DateOfBirth); //01/10/2020 00:00:00

      p1.DateOfBirth = new DateTime(2020, 1, 10, 8, 19, 10);
      Console.WriteLine(p1.DateOfBirth); //01/10/2020 08:19:10

      p1.DateOfBirth = new DateTime(2020, 1, 10, 8, 19, 10);
      Console.WriteLine(p1.DateOfBirth.ToShortDateString()); //01/10/2020
      Console.WriteLine(p1.DateOfBirth.ToLongDateString()); //Friday, 10 January 2020

      Console.WriteLine(p1.DateOfBirth.ToShortTimeString()); //08:19
      Console.WriteLine(p1.DateOfBirth.ToLongTimeString()); //08:19:10

      //p1.Permission = Permission.Administrator;
      p1.Permission = Permission.User;
      if (p1.Permission == Permission.Administrator)
      {
        Console.WriteLine("Jesteś administratorem");
      }
      else
      {
        Console.WriteLine("Nie jesteś administartorem");
      }


      int p1Value = (int)p1.Permission;
      Console.WriteLine(p1Value); //3

      p1.Role = Role.Teacher;
      Console.WriteLine($"Rola: {p1.Role}");


      Teacher t1 = new Teacher();
      t1.Subjects = new List<string> { "matematyka", "po", "informatyka" };
      t1.Subjects.Add("Geografia");

      foreach (var subject in t1.Subjects)
      {
        Console.WriteLine(subject);
      }

      Console.WriteLine(string.Join(", ", t1.Subjects));

    }
  }
}
