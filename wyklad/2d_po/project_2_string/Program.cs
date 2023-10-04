namespace project_2_string
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //a = float.Parse("4");

      float a;
      a = float.Parse(Console.ReadLine());
      Console.WriteLine($"Bok a: {a}, pole: {a*a}cm^2");
    }
  }
}