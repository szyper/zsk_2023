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


      Console.ReadKey();
    }
  }
}
