namespace project_6_1_try_catch
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] array = new int[5];
      bool isCorrect = false;

      do
      {
        Console.WriteLine("Wprowadź 5 liczb całkowitych");
        try
        {
          for (int i = 0; i < array.Length; i++)
          {
            Console.Write("Podaj liczbę:");
            array[i] = int.Parse(Console.ReadLine());
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

      /*Console.WriteLine();
      foreach (int i in array)
      {
        Console.Write($"{i} ");
      }*/



      /*
             Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. Następnie program prosi użytkownika o podanie indeksu tablicy i wyświetla liczbę znajdującą się pod tym indeksem. Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie danych. Program powinien działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch do obsługi wyjątkówJeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
                  Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. 
      */
    }
  }
}