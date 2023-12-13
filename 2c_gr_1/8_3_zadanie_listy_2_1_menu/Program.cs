namespace _8_3_zadanie_listy_2_1_menu
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<int> lista = new List<int>();

      Random random = new Random();

      for (int i = 0; i < 10; i++)
      {
        lista.Add(random.Next(1, 100 + 1));
      }

      foreach (int i in lista)
      {
        Console.Write($"{i} ");
      }

      Console.WriteLine();

      int choice = 0;

      do
      {
        Console.WriteLine("1. Wyświetlić listę liczb podzielnych przez 3 lub 5");
        Console.WriteLine("2. Wyświetlić listę liczb nieparzystych");
        Console.WriteLine("3. Wyświetlić listę liczb posortowanych niemalejąco");
        Console.WriteLine("4. Wyświetlić listę liczb posortowanych nierosnąco");
        Console.WriteLine("5. Wyjście z programu\n");
      }
      while (choice != 5);
    }

    static List<int> divisibleBy3Or5(List<int> list)
    {
      List<int> result = new List<int>();

      foreach (int i in list)
      {
        if (i % 3 == 0 || i % 5 == 0)
        {
          result.Add(i);
        }
      }
      return result;
    }
  }
}
  /*
   *  Napisz program, który tworzy listę liczb całkowitych i wypełnia ją losowymi
wartościami z zakresu od 1 do 100.
 Napisz program, który wyświetla menu z pięcioma opcjami, co chcesz zrobić z listą:
 Wyświetlić listę liczb podzielnych przez 3 lub 5
 Wyświetlić listę liczb nieparzystych
 Wyświetlić listę liczb posortowanych rosnąco
 Wyświetlić listę liczb posortowanych malejąco
 Wyjść z programu
 Napisz metodę dla każdej opcji, która przyjmuje jako parametr listę liczb i zwraca listę
liczb spełniających warunek danej opcji.
 Napisz kod, który obsługuje wybór użytkownika i wywołuje odpowiednią metodę, a
następnie wyświetla wynikową listę na konsoli.
 Napisz kod, który powtarza wyświetlanie menu i obsługę wyboru, dopóki użytkownik
nie wybierze opcji wyjścia z programu.
   */

