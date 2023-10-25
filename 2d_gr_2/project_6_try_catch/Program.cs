namespace project_6_try_catch
{
  internal class Program
  {
    static void Main(string[] args)
    {
      bool isCorrect = false;
      do
      {
        Console.WriteLine("Podaj dwie liczby\n");
        try
        {
          Console.Write("Podaj x:");
          int x = int.Parse(Console.ReadLine());
          Console.Write("Podaj y:");
          int y = int.Parse(Console.ReadLine());
          if (y != 0)
          {
            Console.Write($"Iloraz liczb ");
            Console.ForegroundColor = ConsoleColor.Green;
          }
          Console.WriteLine($"{x} / {y} = {x / y}");
          Console.ResetColor();
          isCorrect = true;
        }
        catch (OverflowException)
        {
          ErrorColorChange($"liczba powinna być z zakresu <{int.MinValue} ; {int.MaxValue}>");
        }
        catch (FormatException)
        {
          ErrorColorChange("podaj prawidłowe dane");
        }
        catch (DivideByZeroException)
        {
          ErrorColorChange("dzielenie przez 0");
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Błąd: {ex.Message}");
        }
        finally
        {
          Console.WriteLine("\nDziękujemy za skorzystanie z programu\n");
        }

      }
      while (!isCorrect);
      

    }

    static void ErrorColorChange(string comment)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"Błąd: {comment}");
      Console.ResetColor();
    }

  }
}