using System.Reflection.Metadata.Ecma335;

namespace project_5
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
      double a;
      Console.Write("Podaj a:");
      a = double.Parse(Console.ReadLine());
      */

      /*if (double.TryParse(Console.ReadLine(), out a))
      {
        Console.WriteLine(a);
      }*/
      bool isCorrect = false;
      do
      {
        Console.Write("Podaj a:");
        double a;
        while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
        {
          Console.Write("Podaj prawidłowo bok a:");
        }

        Console.Write("Podaj b:");
        double b;
        while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
        {
          Console.Write("Podaj prawidłowo bok b:");
        }

        Console.Write("Podaj c:");
        double c;
        while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
        {
          Console.Write("Podaj prawidłowo bok c:");
        }

        if (Istriangle(a, b, c))
        {
          isCorrect = true;
          double area = CalculateTriangleArea(a, b, c);
          Console.OutputEncoding = System.Text.Encoding.Unicode;
          Console.WriteLine("Pole trójkąta o bokach {0}, {1}, {2} wynosi: {3:F5}cm\u00B2", a, b, c, area);
          Console.OutputEncoding = System.Text.Encoding.Default;
        }
        else
        {
          Console.WriteLine("Z podanych boków nie można stworzyć trójkąta");
          Thread.Sleep(2000);
          Console.Clear();
        }
      } while (!isCorrect);
      

    }

    static bool Istriangle(double a, double b, double c)
    {
      return a + b > c && a + c > b && b + c > a;
    }

    static double CalculateTriangleArea(double a, double b, double c)
    {
      double p = (a + b + c) / 2;
      return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }


  }
}