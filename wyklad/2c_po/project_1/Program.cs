namespace project_1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = System.Text.Encoding.Unicode;
      //Console.OutputEncoding = System.Text.Encoding.Default;
      Console.WriteLine("②");

      Console.WriteLine("\x263A");
      Console.WriteLine("☺");

      //char letter = 'a';

      char letter = (char)97;
      Console.WriteLine(letter); //a

      Console.WriteLine("\x61"); //a

      Console.ReadKey();
    }
  }
}