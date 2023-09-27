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

      Console.ReadKey();
    }
  }
}