namespace project_4_1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string message = "imię I NAzwisko"; 
      Console.WriteLine(message);

      string messageUpper = message.ToUpper();
      Console.WriteLine(messageUpper);

      Console.WriteLine(message.Substring(7)); //NAzwisko
      Console.WriteLine(message.Substring(7, 3)); //NAz

      Console.WriteLine(message[0]); //i

      string newMessage = message[0].ToString().ToUpper() + message.Substring(1).ToLower();
      Console.WriteLine(newMessage); //Imię i nazwisko

      string newMessage1 = message.Substring(0,1).ToUpper() + message.Substring(1).ToLower();
      Console.WriteLine(newMessage1); //Imię i nazwisko

      //zakres zmiennej
      Console.WriteLine(int.MinValue); //-2 147 483 648
      Console.WriteLine(int.MaxValue); //2 147 483 647

      Console.WriteLine(char.MaxValue); //wyświetla ?

      string firstName = "Janusz";
      Console.WriteLine(firstName.Length); //6

      string lastName = "Bąk";
      Console.WriteLine(lastName.Length); //3

      Console.WriteLine(lastName[0]); //B

      Console.WriteLine(firstName.Equals(lastName)); //False
      Console.WriteLine("Janusz".Equals("Janusz")); //True
      Console.WriteLine("janusz".Equals("Janusz")); //False

      //###########################################################

      Console.Write("Podaj imię:");
      string? name = Console.ReadLine();

      while (name.Length == 0)
      {
        Console.Write("Podaj imię:");
        name = Console.ReadLine();
      }

      Console.WriteLine("Imię: " + name);

      //###########################################################

      Console.Write("Podaj długość boku kwadratu:");
      float a = float.Parse(Console.ReadLine());
      while (a <= 0)
      {
        Console.Write("Podaj długość boku kwadratu:");
        a = float.Parse(Console.ReadLine());

      }

      Console.WriteLine($"Bok kwadratu wynosi: {a}, pole: {a*a}cm^2");


    }
  }
}