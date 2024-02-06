using _10_1_klasy.classes;

namespace _10_1_klasy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person person = new Person();
      Console.WriteLine(person.GetData());

      //person.Height = 150;
      person.SetHeight(200);
      //Console.WriteLine(person.Height + "cm");
      Console.WriteLine($"Wzrost: {person.GetHeight()}cm");

      Person p1 = new Person();
      p1.FirstName = "Janusz";

      p1.Address = new Address();
      p1.Address.City = "Poznań";
      p1.Address.Street = "Polna";
      p1.Address.HouseNumber = "1c/2";
      p1.Address.PostalCode = "12-345";
      Console.WriteLine(p1.Address.GetAddress());

      Student s1 = new Student();
      s1.StudentNumber = "12345";

      Teacher t1 = new Teacher();
      t1.Subjects = new List<string> { "matematyka", "informatyka", "geografia" };

      foreach (string s in t1.Subjects)
      {
        Console.WriteLine(s);
      }

      Console.WriteLine(string.Join(", ", t1.Subjects));

      p1.Gender = Gender.mężczyzna;
      Console.WriteLine($"Płeć p1: {p1.Gender}");

      p1.Permission = Permission.Administrator;
      if (p1.Permission == Permission.Guest)
      {
        Console.WriteLine("p1 jest gościem");
      }
      else
      {
        Console.WriteLine("p1 nie jest gościem");
      }

      int p1Value = (int)p1.Permission;
      Console.WriteLine(p1Value);

      p1.Role = Role.Student;
      Console.WriteLine($"Rola p1: {p1.Role}");

      p1.DateOfBirth = DateTime.Now;
      Console.WriteLine(p1.DateOfBirth); //02/02/2024 07:39:49

      p1.DateOfBirth = new DateTime(1990, 2, 22);
      Console.WriteLine(p1.DateOfBirth); //02 / 22 / 1990 00:00:00

      p1.DateOfBirth = new DateTime(1990, 2, 22, 7, 42, 13);
      Console.WriteLine(p1.DateOfBirth); //02/22/1990 07:42:13

      Console.WriteLine(p1.DateOfBirth.ToShortTimeString()); //07:42
      Console.WriteLine(p1.DateOfBirth.ToLongTimeString()); //07:42:13
      Console.WriteLine(p1.DateOfBirth.ToLongDateString()); //Thursday, 22 February 1990
      Console.WriteLine(p1.DateOfBirth.ToShortDateString()); //02/22/1990

      p1.DateOfBirth = DateTime.Now;
      Console.WriteLine(p1.DateOfBirth.ToLongTimeString()); //07:42:13



      Console.ReadKey();
    }
  }
}
