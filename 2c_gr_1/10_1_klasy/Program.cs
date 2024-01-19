//using _10_1_klasy.classes;

namespace _10_1_klasy
{
  class Address
  {
    public string City { get; set; }
    public string Street { get; set; }
    public string HouseNumber { get; set; }
    public string PostalCode { get; set; }
  }

  internal class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    private float Height;
    public float Weight;
    public Address Address { get; set; }

    public string GetData()
    {
      return "Imię i nazwisko: " + FirstName + " " + LastName + ", wzrost: " + Height + "cm, waga: " + Weight + "kg";
    }

    public void SetHeight(float height)
    {
      Height = height;
    }

    public float GetHeight()
    {
      return Height;
    }
  }

  class Student
  {
    public string StudentNumber { get; set; }
  }

  class Teacher
  {
    public List<string> Subjects;
  }
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
    }
  }
}
