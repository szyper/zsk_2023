namespace project_4_1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string message = "imiĘ i NAzwisko";
      Console.WriteLine(message); //imiĘ i NAzwisko

      string messageUpperCase = message.ToUpper();
      Console.WriteLine(messageUpperCase); //IMIĘ I NAZWISKO

      string messageLowerCase = message.ToLower();
      Console.WriteLine(messageLowerCase); //imię i nazwisko

      string name = message.Substring(1);
      Console.WriteLine(name); //miĘ i NAzwisko

      string name1 = message.Substring(0, 4);
      Console.WriteLine(name1); //imiĘ

      Console.WriteLine(name1[0]); //i

      // imiĘ i NAzwisko => Imię i nazwisko
      Console.WriteLine(message.Substring(0, 1).ToUpper() + message.Substring(1).ToLower()); //Imię i nazwisko
      Console.WriteLine(message[0].ToString().ToUpper() + message.Substring(1).ToLower()); //Imię i nazwisko

      //zakres zmiennej
      Console.WriteLine(int.MinValue); //-2147483648
      Console.WriteLine(int.MaxValue); //2147483647

      Console.WriteLine(char.MaxValue); //?

      string firstName = "Janusz";
      Console.WriteLine(firstName.Length); //6

      Console.WriteLine(firstName[0]); //J

      string lastName = "Nowak";
      Console.WriteLine(firstName.Equals(lastName)); //False
      Console.WriteLine("Janusz".Equals("Janusz")); //True
      Console.WriteLine("Janusz".Equals("janusz")); //False

      //######################################################

      Console.Write("Podaj imię:");
      string? name2 = Console.ReadLine();
      Console.WriteLine($"Imię: {name2}");

      while (name2.Length == 0)
      {
        Console.Clear();
        Console.Write("Podaj imię:");
        name2 = Console.ReadLine();
      }

      //######################################################
      //pole kwadratu

      float d;
      do
      {
        Console.Clear();
        Console.Write("Podaj bok d:");
        d = float.Parse(Console.ReadLine());
      } while (d <= 0);

      Console.WriteLine($"Pole kwadratu o boku {d} wynosi: {d * d:F2}");

      //######################################################
      //pole trójkąta (wzór Herona) 
      /*Herona wzór, mat. wzór na obliczanie pola trójkąta S, gdy dane są jego boki a, b, c: , gdzie p = (a + b + c)/2 — połowa obwodu trójkąta.
       */

      Console.Clear();
      double a, b, c;

      Console.Write("Podaj długość boku a:");
      a = double.Parse(Console.ReadLine());

      Console.Write("Podaj długość boku b:");
      b = double.Parse(Console.ReadLine());

      Console.Write("Podaj długość boku c:");
      c = double.Parse(Console.ReadLine());

      if (a + b > c && a + c > b && b + c > a)
      {
        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine($"Pole trójkąta wynosi: {area:F2}cm^2");
      }
      else
      {
        Console.WriteLine("Nie można utworzyć trójkąta o podanych bokach");
      }

    }
  }
}