using System.Formats.Asn1;

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

      float? a1;
      Console.Write("Podaj bok a:");
      a1 = float.Parse(Console.ReadLine());

      while (a1 <= 0)
      {
        Console.Write("Podaj bok a:");
        a1 = float.Parse(Console.ReadLine());
      }

      Console.WriteLine($"Bok a wynosi: {a1}, pole: {a1*a1}cm^2");

      Console.Clear();

      //pole trójkąta (wzór Herona)
      double a, b, c;

      Console.WriteLine("Podaj długośc boku a:");
      a = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Podaj długośc boku b:");
      b = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Podaj długośc boku c:");
      c = Convert.ToDouble(Console.ReadLine());

      if (a + b > c && a + c > b && b + c > a)
      {
        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine("Pole trójkąta wynosi: {0:F2}cm^2", area);
      }
      else
      {
        Console.WriteLine("Nie można utworzyć trójkąta o podanych długościach boków");
      }

    }
  }
}