using System.Data;

namespace slowniki
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Dictionary<int, string> d = new Dictionary<int, string>();

      d.Add(1, "Franek");
      d.Add(2, "Anna");
      d.Add(3, "Janusz");

      foreach (var item in d)
      {
        Console.WriteLine($"{item.Value}");
      }
      Console.WriteLine();

      //###############################################################################

      Dictionary<string, int> d1 = new Dictionary<string, int>();
      d1.Add("jeden", 1);
      d1.Add("dwa", 2);
      d1.Add("trzy", 3);

      //foreach (var item in d1)
      foreach (KeyValuePair<string, int> item in d1)
      {
        Console.WriteLine($"{item.Key}: {item.Value}");
      }

      Dictionary<string, string> capitals = new Dictionary<string, string>()
      {
        { "Polska", "Warszawa" },
        { "Niemcy", "Berlin" },
        { "Francja", "Paryż" },
      };

      foreach (var item in capitals)
      {
        Console.WriteLine("Kraj: {0}, stolica: {1}", item.Key, item.Value);
      }

      Dictionary<string, string> phones = new Dictionary<string, string>();
      phones.Add("+48 123 456 789", "Anna");
      phones.Add("+48 123 456 786", "Tomasz");
      phones.Add("+48 123 456 787", "Janusz");

      foreach (string phone in phones.Keys)
      {
         Console.WriteLine("Numer telefonu: {0}, osoba: {1}", phone, phones[phone]);
      }

      Dictionary<string, string> colors = new Dictionary<string, string>();
      colors.Add("biały", "#FFFFFF");
      colors.Add("czarny", "#000000");
      colors.Add("czerwony", "#FF0000");
      colors.Add("zielony", "#00FF00");
      colors.Add("niebieski", "#0000FF");



    }
  }
}
