namespace project_5_1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
      Console.Write("Podaj bok a:");
      double a;
      if (double.TryParse(Console.ReadLine(), out a))
      {
        Console.WriteLine(a);
      }
      else
      {
        Console.WriteLine("error");
      }
      */

      bool isCorrect = false;

      do
      {
          Console.Write("Podaj bok a:");
          double a;
          while (!double.TryParse(Console.ReadLine(), out a))
          {
            Console.Write("Podaj bok a:");
          }

          Console.Write("Podaj bok b:");
          double b;
          while (!double.TryParse(Console.ReadLine(), out b))
          {
            Console.Write("Podaj bok b:");
          }

          Console.Write("Podaj bok c:");
          double c;
          while (!double.TryParse(Console.ReadLine(), out c))
          {
            Console.Write("Podaj bok c:");
          }

          if (a + b > c && a + c > b && b + c > a)
          {
            isCorrect = true;
            //dokończyć obliczenie pola
          }
      } while(!isCorrect);
      
      

    }
  }
}