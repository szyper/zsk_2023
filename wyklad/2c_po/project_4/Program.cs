namespace project_4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      bool isCorrect = false;
      do
      {
        Console.Write("Podaj promień:");
        string input = Console.ReadLine();

        if (input == "q")
        {
          break;
        }

        try
        {
          double r = double.Parse(input);

          if (r < 0)
          {
            throw new OverflowException($"Za mała liczba, liczba musi być dodatnia, nie większ niż {double.MaxValue}");
          }

          if (r > double.MaxValue)
          {
            throw new OverflowException($"Za duża liczba. Maksymalna liczba: {double.MaxValue}");
          }

          Console.WriteLine($"\n\nPole koła o promieniu {r} wynosi: {Area(r):F3}, obwód wynosi: {Circuit(r):F3}");

          isCorrect = true;
        }
        catch (FormatException)
        {
          Console.WriteLine("\nPodaj liczbę");
        }
        catch (OverflowException ex)
        {
          Console.WriteLine($"\nPrzekroczony zakres.\n{ex.Message}");
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
      }
      while (!isCorrect);






      /*
       * Napisz program w C#, który wczytuje promień koła od użytkownika i oblicza jego obwód (funkcja statyczna) i pole (funkcja statyczna) według wzorów: obwód = 2πr, pole = πr^2. Jeśli użytkownik wprowadzi liczbę mniejszą lub równą zero, program powinien wyświetlić komunikat o błędnych danych. Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien wyświetlić komunikat o nieprawidłowym formacie i poprosić o ponowne wprowadzenie danych. Program powinien działać w pętli, dopóki użytkownik nie wpisze q lub użytkownik poda prawidłowe dane i będzie możliwe obliczenie pola i obwodu. Użyj instrukcji try-catch do obsługi wyjątków.
        Tylko wynik pola i obwód wyświetl w kolorze zielonym.
      */
    }

    static double Circuit(double r)
    {
      return 2 * Math.PI * r;
    }

    static double Area(double r)
    {
      return Math.PI * Math.Pow(r, 2);
    }
  }
}