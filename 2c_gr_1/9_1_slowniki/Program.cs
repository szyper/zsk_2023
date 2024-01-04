namespace _9_1_slowniki
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Dictionary<int, string> d = new Dictionary<int, string>();
      d.Add(1, "Anna");
      d.Add(2, "Gustaw");
      d.Add(3, "Tomasz");

      foreach (var item in d)
      {
        Console.WriteLine($"{item.Value}");
      }
      Console.WriteLine();
      //#########################################################################

      Dictionary<string, int> d1 = new Dictionary<string, int>();
      d1.Add("jeden", 1);
      d1.Add("dwa", 2);
      d1.Add("trzy", 3);

      foreach (var item in d1)
      {
        Console.WriteLine($"{item.Value}");
      }
      Console.WriteLine();
      //#########################################################################

      Dictionary<string, string> capitals = new Dictionary<string, string>();
      capitals.Add("Polska", "Warszawa");
      capitals.Add("Niemcy", "Berlin");
      capitals.Add("Francja", "Paryż");

      foreach (var item in capitals)
      {
        Console.WriteLine($"{item.Value}");
      }
      Console.WriteLine();
      //#########################################################################

      Dictionary<string, string> animals = new Dictionary<string, string>();
      animals.Add("pies", "hauhau");
      animals.Add("kot", "miaumiau");
      animals.Add("koń", "ihaha");

      foreach (KeyValuePair<string, string> item in animals)
      {
        Console.WriteLine($"{item.Key}: {item.Value}");
      }
      Console.WriteLine();
      //#########################################################################

      Dictionary<string, string> colors = new Dictionary<string, string>();
      animals.Add("biały", "#FFFFFF");
      animals.Add("czarny", "#000000");
      animals.Add("czerwony", "#FF0000");
      animals.Add("zielony", "#00FF00");
      animals.Add("niebieski", "#0000FF");

      foreach (var color in colors)
      {
        Console.WriteLine("Kolor: {1}, hex: {0}", color.Key, color.Value);
      }
      Console.WriteLine();
      //#########################################################################
    }
  }
}
