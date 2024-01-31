using _10_1_klasy.classes;

namespace _10_1_klasy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person person = new Person();
      Console.WriteLine(person.GetData());

      Student s1 = new Student();
      s1.StudentNumber = "12345";

      Teacher t1 = new Teacher();
      t1.Subjects = new List<string> { "Informatyka", "Matematyka" };

      t1.GetAllSubjects();

      /*
      foreach (var item in t1.Subjects)
      {
          Console.WriteLine(item);
      }
      */

      person.FirstName = "Janusz";
      //Console.WriteLine(person.FirstName);
      Console.WriteLine(person.GetData());
      Console.Clear();

      Person p1 = new Person();
      p1.Address = new Address();
      p1.Address.City = "Gniezno";
      p1.Address.Street = "Polna";
      p1.Address.HouseNumber = "1c/3";
      p1.Address.PostalCode = "12-345";

      Console.WriteLine(p1.Address.GetAddress());

      p1.DateOfBirth = DateTime.Now;
      Console.WriteLine("Data i godzina: {0}", p1.DateOfBirth); //Data: 01/29/2024 08:32:07

      p1.DateOfBirth = new DateTime(2000, 6, 10);
      Console.WriteLine("Data i godzina: {0}", p1.DateOfBirth); //Data: 06/10/2000 00:00:00

      p1.DateOfBirth = new DateTime(2000, 6, 10, 8, 33, 10);
      Console.WriteLine("Data i godzina: {0}", p1.DateOfBirth); //Data: 06/10/2000 08:33:10

      Console.WriteLine("Czas: {0}", p1.DateOfBirth.ToShortTimeString()); //Czas: 08:33
      Console.WriteLine("Czas: {0}", p1.DateOfBirth.ToLongTimeString()); //Czas: 08:33:10

      Console.WriteLine("Data: {0}", p1.DateOfBirth.ToShortDateString()); //Data: 06/10/2000
      Console.WriteLine("Data: {0}", p1.DateOfBirth.ToLongDateString()); //Data: Saturday, 10 June 2000

      p1.Gender = Gender.mężczyzna;


    }
  }
}
