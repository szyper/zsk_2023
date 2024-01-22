






namespace _1_1_klasy
{
  internal class Program
  {
    class Person
    {
      public string[] Parents { get; set; }
      public List<string> Children { get; set; }

      public void ChangeFirstNameOfParents(string newName)
      {
        Parents[0] = newName;
      }

      public void ChangeSecondNameOfParents(string newName)
      {
        Parents[1] = newName;
      }

      public void AddChild(string Name)
      {
        Children.Add(Name);
      }

      public void RemoveChild(string Name)
      {
        Children.Remove(Name);
      }

    }
      static void Main(string[] args)
    {
      Person p1 = new Person();
      p1.Parents = new string[] {"Anna", "Tomasz"};

      p1.ChangeFirstNameOfParents("Maria");

      Console.WriteLine($"Imię matki: {p1.Parents[0]}, imię ojca: {p1.Parents[1]}");

      p1.Children = new List<string>() { "Tomasz", "Anna", "Agnieszka" };
      p1.AddChild("Jan");

      Console.WriteLine("Ilość dzieci: " + p1.Children.Count);

      //dokończyć

    }
  }
}

















