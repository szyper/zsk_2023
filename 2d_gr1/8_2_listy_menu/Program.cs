//dokończyć 
namespace _8_1_listy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<int> list = new List<int>();

      Random random = new Random();

      for (int i = 0; i < 10; i++)
      {
        list.Add(random.Next(1, 100 + 1));
      }

      Console.WriteLine("Lista 10 liczb losowych:");
      foreach (int i in list)
      {
        Console.Write($"{i} ");
      }

      Console.WriteLine("\n\n");

      int choice = 0;

      Console.WriteLine("1. Wyświetlić listę liczb podzielnych przez 3 lub 5");
      Console.WriteLine("2. Wyświetlić listę liczb nieparzystych");
      Console.WriteLine("3. Wyświetlić listę liczb posortowanych rosnąco");
      Console.WriteLine("4. Wyświetlić listę liczb posortowanych malejąco");
      Console.WriteLine("5. Wyjść z programu");

      do
      {
        Console.Write("\nWybierz opcję:");
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
          Console.WriteLine("Podaj prawidłową wartość");
        }

        switch(choice)
        {
          case 1:
            List<int> listDivisibleBy3Or5 = divisibleBy3Or5(list);
            Console.WriteLine($"\nLista liczb podzielnych przez 3 lub 5 ({listDivisibleBy3Or5.Count}):");
            foreach (var i in listDivisibleBy3Or5)
            {
              Console.Write($"{i} ");
            }
            Console.WriteLine();
            break;
          case 2:
            List<int> odd = Odd(list);
            Console.WriteLine($"\nLista liczb nieparzystych:");
            foreach (var i in odd)
            {
              Console.Write($"{i} ");
            }
            Console.WriteLine();
            break;
        }

      }
      while (choice != 5);

    }

    static List<int> divisibleBy3Or5(List<int> lista)
    {
      List<int> result = new List<int>();
      foreach (int i in lista)
      {
        if (i % 3 == 0 || i % 5 == 0)
        {
          result.Add(i);
        }
      }
      return result;
    }

    static List<int> Odd(List<int> list)
    {
      List<int> result = new List<int> ();

      foreach (int i in list)
      {
        if (i % 2 == 1)
        {
          result.Add(i);
        }
      }
      return result;
    }


  }
}
/*
  Napisz program, który tworzy listę liczb całkowitych i wypełnia ją losowymi
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
