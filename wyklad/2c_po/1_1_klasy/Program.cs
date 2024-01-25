using _1_1_klasy.classes;
namespace _1_1_klasy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person p1 = new Person();
      //p1.Parents = new string[] {"Anna", "Tomasz"};

      //p1.ChangeFirstNameOfParents("Maria");

      //Console.WriteLine($"Imię matki: {p1.Parents[0]}, imię ojca: {p1.Parents[1]}");

      p1.Children = new List<string>() { "Tomasz", "Anna", "Agnieszka" };
      p1.AddChild("Jan");

      Console.WriteLine("Ilość dzieci: " + p1.Children.Count);

      //dokończyć
      p1.Address = new Address();
      p1.Address.City = "Poznań";
      p1.Address.Street = "Polna";
      Console.WriteLine(p1.Address.City);
      
      p1.DateOfBirth = DateTime.Now;
      Console.WriteLine("Data: {0}", p1.DateOfBirth); //Data: 01/25/2024 12:59:38

      p1.DateOfBirth = new DateTime();
      Console.WriteLine("Data: {0}", p1.DateOfBirth); //Data: 01/01/0001 00:00:00

      p1.DateOfBirth = new DateTime(2024, 1, 25);
      Console.WriteLine("Data: {0}", p1.DateOfBirth); //Data: 01/25/2024 00:00:00

      p1.DateOfBirth = new DateTime(2024, 1, 25);
      Console.WriteLine("Data: {0}", p1.DateOfBirth.ToShortDateString()); //Data: 01/25/2024

      p1.DateOfBirth = new DateTime(2024, 1, 25);
      Console.WriteLine("Godzina: {0}", p1.DateOfBirth.ToShortTimeString()); //Godzina: 00:00

      p1.DateOfBirth = new DateTime(2024, 1, 25, 13, 7, 22);
      Console.WriteLine("Godzina: {0}", p1.DateOfBirth.ToShortTimeString()); //Godzina: 13:07
      Console.WriteLine("Data: {0}", p1.DateOfBirth.ToLongDateString()); //Data: Thursday, 25 January 2024
      Console.WriteLine("Godzina: {0}", p1.DateOfBirth.ToLongTimeString()); //Godzina: 13:07:22

    }
  }
}

















