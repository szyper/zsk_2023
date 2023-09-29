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

    }
  }
}