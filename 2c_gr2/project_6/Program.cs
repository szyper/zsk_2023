namespace project_6
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //dodać pętle do while
      Console.WriteLine("Podaj dwie liczby\n");
      try
      {
        Console.Write("Podaj x:");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Podaj y:");
        int y = int.Parse(Console.ReadLine());
        if ( y != 0)
        {
          Console.Write($"Iloraz ");
          Console.ForegroundColor = ConsoleColor.Green;
        }
        
        Console.WriteLine($"{x} / {y} = {x / y}");
        Console.ResetColor();
      }
      catch(FormatException) 
      {
        ErrorColorChange("Podaj liczbę całkowitą");
      }
      catch (OverflowException)
      {
        ErrorColorChange($"Liczba poza zakresem <{int.MinValue} ; {int.MaxValue}>");
      }
      catch (DivideByZeroException)
      {
        ErrorColorChange("Dzielenie przez 0!");
      }
      catch (Exception ex)
      {
        //Console.WriteLine(ex.ToString());
        Console.WriteLine(ex.Message);
      }
      finally
      {
        Console.WriteLine("Dziękujemy za skorzystanie z programu");
      }

    }

    static void ErrorColorChange(string message)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"\nBłąd: {message}\n");
      Console.ResetColor();
    }
  }
}