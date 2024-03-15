namespace _1_klasy
{
  internal class Program
  {
    public class Address
    {
      public static int Counter = 0;
      private string v;

      public string City { get; set; }
      public string Street { get; set; }
      public string HouseNumber { get; set; }

      public Address() { }

      static Address()
      {
        Console.WriteLine("Konstruktor statyczny");
        //Counter++;
      }

      /*public Address(string city,  string street, string houseNumber)
      {
        City = city;
        Street = street;
        HouseNumber = houseNumber;
      }*/

      public Address(string city)
      {
        Console.WriteLine("Konstruktor klasy Address z jednym parametrem");
        City = city;
        Counter++;
      }

      public Address(string city, string street) :this(city)
      {
        Console.WriteLine("Konstruktor klasy Address z dwoma parametrami");
        Street = street;
        Counter++;
      }

      public Address(string city, string street, string houseNumber) : this(city, street)
      {
        Console.WriteLine("Konstruktor klasy Address z trzema parametrami");
        HouseNumber = houseNumber;
        Counter++;
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


      Address a0 = new Address(); 
      Address a1 = new Address("Poznań"); 
      Address a2 = new Address("Poznań", "Polna"); 
      Address a3 = new Address("Poznań", "Polna", "1c/2");

      Console.WriteLine("Ilość obiektów klasy Address: {0}", Address.Counter);

      List<Address> list = new List<Address>();
      //list.Add(a0);
      //list.Add(a1);

      list.AddRange(new[] { a0, a1, a2, a3 });
      Console.WriteLine("Ilość obiektów klasy Address: {0}", list.Count);


    }
  }
}
