using System.Threading.Channels;

namespace project_4_1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //przykłady typów predefiniowanych
      string message = "iMię i NAZwisko";
      
      string messageUpper = message.ToUpper();
      Console.WriteLine(message);
      Console.WriteLine(messageUpper);

      string newMessage = message[0].ToString().ToUpper() + message.Substring(1).ToLower();
      Console.WriteLine(newMessage); //Imię i nazwisko

      string number = "1234567890";
      Console.WriteLine(number);
      Console.WriteLine(number.Substring(3, 3)); //456
      Console.WriteLine(number.Substring(0, 5)); //12345

      //zakres zmiennej
      Console.WriteLine(int.MinValue); //-2 147 483 648
      Console.WriteLine(int.MaxValue); //2 147 483 647
      Console.WriteLine(char.MaxValue); //?

      string firstName = "Kamil";
      Console.WriteLine(firstName.Length); //5
      Console.WriteLine("Bąk".Length); //3

      Console.WriteLine(firstName[0]); //K

      string lastName = "Nowak";
      Console.WriteLine(firstName.Equals(lastName)); //False
      Console.WriteLine("Janusz".Equals("janusz")); //False
      Console.WriteLine("janusz".Equals("janusz")); //True

      Console.Clear();

      Console.Write("Podaj imię:");
      string? name = Console.ReadLine();
      Console.WriteLine($"Imię: {name}");

      Console.Write("Podaj nazwisko:");
      string? lastName2 = Console.ReadLine();

      while( lastName2.Length == 0 )
      {
        Console.Write("Podaj nazwisko:");
        lastName2 = Console.ReadLine();
      }

      Console.WriteLine($"Nazwisko: {lastName2}");

      //#################################################################

      Console.Write("Podaj długość boku:");
      float a = float.Parse(Console.ReadLine());
      Console.WriteLine(a);



      Console.ReadKey();
    }
  }
}