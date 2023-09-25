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
    }
  }
}