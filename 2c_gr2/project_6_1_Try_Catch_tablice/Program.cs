namespace project_6_1_Try_Catch_tablice
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] array = new int[5];
      bool isCorrect = false;

      do
      {
        Console.WriteLine("Podaj 5 liczb całkowitych\n");
        try
        {
          for (int i = 0; i < array.Length; i++)
          {
            Console.Write($"Podaj liczbę {i+1}:");
            //array[i] = int.Parse(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out array[i]))
            {
              //Console.WriteLine("error");
              i--;
            }
          }
          isCorrect = true;
        }
        catch (FormatException)
        {
          Console.WriteLine("\nNieprawidłowe dane. Wprowadź poprawną liczbę całkowitą\n\n");
        }
        catch(OverflowException)
        {
          Console.WriteLine($"\nNieprawidłowe dane. Liczba poza zakresem <{int.MinValue} ; {int.MaxValue}\n\n");
        }
      }
      while (!isCorrect);

      int index = 0;
      string input;

      do
      {
        Console.Write("\nWprowadź indeks tablicy lub q, aby zakończyć program:");
        input = Console.ReadLine();

        if (input == "q")
        {
          break;
        }

        try
        {
          index = int.Parse(input);

          if (index > array.Length - 1 || index < 0)
          {
            throw new OverflowException("\nPodana liczba jest mniejsza od 0 lub większa od ostatniego ideksu w tablicy\n\n");
          }

          Console.WriteLine($"\nLiczba pod indeksem {index} wynosi {array[index]}\n\n");

        }
        catch (FormatException)
        {
          Console.WriteLine("\nNieprawidłowe dane. Wprowadź liczbę całkowitą\n\n");
        }
        catch (IndexOutOfRangeException ex)
        {
          Console.WriteLine($"\nNieprawidłowe dane. Indeks być między 0 a {array.Length - 1}. {ex.Message}\n\n");
        }
        catch (OverflowException ex)
        {
          Console.WriteLine($"Nieprawidłowe dane. Przekroczono zakres.{ex.Message}");
        }
      }
      while (true);

      /*
       Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. Następnie program prosi użytkownika o podanie indeksu tablicy i wyświetla liczbę znajdującą się pod tym indeksem. Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie danych. Program powinien działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch do obsługi wyjątkówJeśli liczba jest ujemna, program powinien zgłosić wyjątek IndexOutOfRangeException i wyświetlić odpowiedni komunikat. 
                  Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. 
       */
    }
  }
}