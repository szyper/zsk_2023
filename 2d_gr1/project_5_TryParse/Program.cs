namespace project_5_TryParse
{
  internal class Program
  {
    static void Main(string[] args)
    {
      bool isCorrect = false;
      do
      {
        Console.Write("Podaj bok a:");
        double a;
        while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
        {
          Console.Write("Podaj poprawnie bok a:");
        }

        Console.Write("Podaj bok b:");
        double b;
        while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
        {
          Console.Write("Podaj poprawnie bok b:");
        }

        Console.Write("Podaj bok c:");
        double c;
        while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
        {
          Console.Write("Podaj poprawnie bok c:");
        }

        if (IsTriangle(a, b, c))
        {
          isCorrect = true;
          Console.OutputEncoding = System.Text.Encoding.Unicode;
          Console.Write("\nPole trójkąta o bokach {0}, {1}, {2} wynosi: ", a, b, c);
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("{0:F3}cm\u00B2", CalculateTriangleArea(a, b, c));
          Console.ResetColor();
          Console.OutputEncoding = System.Text.Encoding.Default;
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\nNie można utworzyć trójkąta z podanych boków");
          Console.ResetColor();
          Thread.Sleep(2000);
          Console.Clear();
        }
      } while (!isCorrect);

      Console.ReadKey();
    }

    static bool IsTriangle(double a, double b, double c)
    {
      return a + b > c && a + c > b && b + c > a;
    }

    static double CalculateTriangleArea(double a, double b, double c)
    {
      double p =(a + b + c ) / 2;
      return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

  }
}