namespace project_6_try_catch
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Podaj dwie liczby\n");
      try
      {
        Console.Write("Podaj x:");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Podaj y:");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nIloraz {x} / {y} = {x / y}");
      }
      catch (OverflowException)
      {
        Console.WriteLine($"\nPrzekroczono zakres liczby <{int.MinValue} ; {int.MaxValue}>");
      }
      catch (FormatException)
      {
        Console.WriteLine("\nBłędny format danych");
      }
      catch (DivideByZeroException)
      {
        Console.WriteLine("\nDzielenie przez 0");
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
      
      
      
    }
  }
}