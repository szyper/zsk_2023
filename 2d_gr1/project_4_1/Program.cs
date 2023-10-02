namespace project_4_1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //przykłady typów predefiniowanych
      string message = "imIę i NazWiskO: ";
      string messageUpper = message.ToUpper();

      string newMessage = message[0].ToString().ToUpper() + message.Substring(1).ToLower();
      Console.WriteLine(newMessage);

      //zakres zmiennej
      Console.WriteLine(int.MinValue); //-2 147 483 648
      Console.WriteLine(int.MaxValue); //2 147 483 647
      Console.WriteLine(char.MaxValue); //?

      string firstName = "Janusz";
      Console.WriteLine(firstName.Length); //6
      Console.WriteLine("Bąk".Length); //3

      Console.WriteLine(firstName[0]); //J

      string lastName = "Nowak";
      Console.WriteLine(firstName.Equals(lastName)); //False
      Console.WriteLine("Janusz".Equals("Janusz")); //True
      Console.WriteLine("Janusz".Equals("janusz")); //False

      //#########################################################

      Console.Write("Podaj imię:");
      string? name = Console.ReadLine();

      //while (name == "")
      while (name.Length == 0)
      {
        Console.Write("Podaj imię:");
        name = Console.ReadLine();
      }

      Console.WriteLine("Imię: " + name);

      //#########################################################

      float? a;
      Console.Write("Podaj bok a:");
      a = float.Parse(Console.ReadLine());

      while (a <= 0)
      {
        Console.Write("Podaj bok a:");
        a = float.Parse(Console.ReadLine());
      }

      Console.WriteLine($"Bok a wynosi: {a}");

      //dokończyć zadanie

    }
  }
}