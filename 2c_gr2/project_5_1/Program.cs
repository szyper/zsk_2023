namespace project_5_1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
      Console.WriteLine("Podaj bok a:");
      double a;
      a = double.Parse(Console.ReadLine());
      */

      /*
      Console.WriteLine("Podaj bok a:");
      double a;
      double.TryParse(Console.ReadLine(), out a);
      */

      /*
      Console.WriteLine("Podaj bok a:");
      double a;
      if (double.TryParse(Console.ReadLine(), out a))
      {
        Console.WriteLine(a);
      }*/

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
          Console.WriteLine("Pole trójkąta o bokach {0},{1}, {2} wynosi: {3:F4}cm\u00B2", a, b, c, CalculateTriangleArea(a, b, c));
          Console.OutputEncoding = System.Text.Encoding.Default;
        }
        else
        {
          Console.WriteLine("Z podanych boków nie można utworzyć trójkąta");
          Thread.Sleep(2000);
          Console.Clear();
        }
      } while (!isCorrect);
      

    }

    static bool IsTriangle(double a, double b, double c)
    {
      return a + b > c && a + c > b && b + c > a;
    }

    static double CalculateTriangleArea(double a, double b, double c)
    {
      double p = (a + b + c) / 2;
      return Math.Sqrt(p * (p - a) * (p - b) * (p -c));
    }
  }
}