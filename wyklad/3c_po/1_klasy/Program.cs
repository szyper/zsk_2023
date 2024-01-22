namespace _1_klasy
{
  internal class Program
  {
    class Address
    {
      public string City { get; set; }
      public string Street { get; set; }
      public string HouseNumber { get; set; }
      public Address(string city,  string street, string houseNumber)
      {
        City = city;
        Street = street;
        HouseNumber = houseNumber;
      }
    }

    class Person
    {
      public string[] Parents { get; set; }
      public Dictionary<string, Address> Address;

      public void SetChangeFirstNameParent(string Name)
      {
        Parents[0] = Name;
      }

      public void SetChangeSecondNameParent(string Name)
      {
        Parents[1] = Name;
      }

      public string GetFullData()
      {
        return $"Imię 1 rodziaca: {this.Parents[0]}\nAdres: {this.Address[this.Parents[0]].City}, ulica: {this.Address[this.Parents[0]].Street} {this.Address[this.Parents[0]].HouseNumber}\n\nImię 2 rodziaca: {this.Parents[1]}\nAdres: {this.Address[this.Parents[1]].City}, ulica: {this.Address[this.Parents[1]].Street} {this.Address[this.Parents[1]].HouseNumber}";
      }
    }
    static void Main(string[] args)
    {
      Person person = new Person();

      person.Parents = new string[] { "Anna", "Tomasz" };

      person.Address = new Dictionary<string, Address>();
      person.Address.Add(person.Parents[0], new Address("Poznań", "Polna", "1a"));
      person.Address.Add(person.Parents[1], new Address("Poznań", "Polna", "1a"));

      Console.WriteLine(person.GetFullData());
      //do poprawy GetFullData => foreach/for
    }
  }
}
