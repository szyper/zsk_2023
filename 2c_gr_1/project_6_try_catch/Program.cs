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
            Console.Write("\nIloraz ");
            Console.ForegroundColor = ConsoleColor.Green;
          }
          Console.WriteLine($"{x} / {y} = {x / y}");
          Console.ResetColor();
          isCorrect = true;
        }
        catch (OverflowException)
        {
          ErrorColorChange($"Przekroczono zakres liczby <{int.MinValue} ; {int.MaxValue}>");
        }
        catch (FormatException)
        {
          ErrorColorChange("Błędny format danych");
        }
        catch (DivideByZeroException)
        {
          ErrorColorChange("Dzielenie przez 0");
        }
        catch (Exception ex)
        {
          //Console.WriteLine(ex.ToString());
          Console.WriteLine("Błąd: " + ex.Message);
        }
        finally
        {
          Console.WriteLine("\nDziekujemy za skorzystanie z programu");
        }
      } while (!isCorrect);
      
    }

    static void ErrorColorChange(string comment)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"\nBłąd: {comment}");
      Console.ResetColor();
    }
  }
}