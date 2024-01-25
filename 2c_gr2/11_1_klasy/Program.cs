namespace _11_1_klasy
{
  internal class Program
  {
    class Address
    {
      public string City { get; set; }
      public string Street { get; set; }
      public string HouseOfNumber { get; set; }
      public string PostalCode { get; set; }
    }
    class Person
    {
      public string FirstName { get; private set; }
      public string LastName { get; set; }
      public DateTime DateOfBirth { get; set; }
      public Address Address { get; set; }

      public void SetName(string name)
      {
        FirstName = name;
      }
    }
    static void Main(string[] args)
    {
      Person p1 = new Person();
      //p1.FirstName = "Janusz";
      p1.SetName("Paweł");
      Console.WriteLine($"Imię: {p1.FirstName}");
      Console.WriteLine($"Nazwisko: {p1.LastName}");
    }
  }
}
