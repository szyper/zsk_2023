namespace project_6_try_catch
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Podaj dwie liczby");
      bool isCorrect = false;
      do
      {
        try
        {
          Console.Write("Podaj x:");
          int x = int.Parse(Console.ReadLine());
          Console.Write("Podaj y:");
          int y = int.Parse(Console.ReadLine());
          Console.WriteLine($"Iloraz {x} / {y} = {x / y}");
          isCorrect = true;
        }
        catch (DivideByZeroException)
        {
          ErrorColorChange("Dzielenie przez 0");
        }
        catch (FormatException)
        {
          ErrorColorChange($"Błąd: błędny format danych");
        }
        catch (OverflowException)
        {
          ErrorColorChange($"Błąd: przekroczono zakres danych <{int.MinValue} ; {int.MaxValue}>");
        }
        catch (Exception ex)
        {
          ErrorColorChange($"{ex.Message}");
        }
        finally
        {
          Console.WriteLine("\nDziękujemy za skorzystanie z programu\n");
        }
      } while (!isCorrect);
    }

    static void ErrorColorChange(string message)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"\nBłąd: {message}");
      Console.ResetColor();
    }

  }
}