using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _6_1_try_catch_tablice
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] array = new int[5];
      bool isCorrect = false;

      do
      {
        Console.WriteLine("Wprowadź 5 liczb całkowitcych:");
        try
        {
          for (int i = 0; i < array.Length; i++)
          {
            Console.Write($"Podaj liczbę {i + 1}:");
            //array[i] = int.Parse(Console.ReadLine());

            if (!int.TryParse(Console.ReadLine(), out array[i]))
            {
              i--;
            }

          }
          isCorrect = true;

        }
        catch (FormatException)
        {
          Console.WriteLine("Nieprawidłowe dane. Wprowadź poprawną liczbę całkowitą");
        }
        catch (OverflowException)
        {
          Console.WriteLine($"Nieprawidłowe dane. Liczba poza zakresem <{int.MinValue} ; {int.MaxValue}>");
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
          //Console.WriteLine($"{array[index]}");
          if (index > array.Length - 1 || index < 0)
          {
            throw new OverflowException($"\nIndeks podany przez użytkownika jest poniżej 0 lub powyżej indeksu maksymalnego: {array.Length - 1}\n\n");
          }

          Console.WriteLine($"\nLiczba pod indeksem {index} to {array[index]}");

        }
        catch (FormatException)
        {
          Console.WriteLine("\nNieprawidlowe dane. Wprowadź poprawną liczbę całkowitą\n\n");
        }
        catch (IndexOutOfRangeException)
        {
          Console.WriteLine($"\nIndexOutOfRangeException.Nieprawidlowe dane. Indeks musi być między 0 a {array.Length - 1}\n\n");
        }
        catch (OverflowException ex)
        {
          Console.WriteLine($"\nOverflowException.Nieprawidlowe dane. Indeks musi być między 0 a {array.Length - 1}\n{ex.Message}\n");
        }
      }
      while (true);












      /*Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. Następnie program prosi użytkownika o podanie indeksu tablicy i wyświetla liczbę znajdującą się pod tym indeksem. Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie danych. Program powinien działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch do obsługi wyjątków. Jeśli liczba jest ujemna, program powinien zgłosić wyjątek IndexOutOfRangeException i wyświetlić odpowiedni komunikat.
            Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby.*/
    }
  }
}