namespace _8_2_zadanie_listy_2
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

      List<int> listDivisibleBy3Or5 = divisibleBy3Or5(lista);

      Console.WriteLine("\nLista z elementami podzielnymi przez 3 lub 5:");

      foreach (int i in listDivisibleBy3Or5)
      {
        Console.Write($"{i} ");
      }
      Console.WriteLine("\n\n");
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
  /*
   •	Utwórz listę liczb całkowitych i wypełnij ją losowymi wartościami z zakresu od 1 do 100.
  •	Napisz metodę, która przyjmuje jako parametr listę liczb i zwraca listę liczb, które są podzielne przez 3 lub 5.
  •	Wyświetl na konsoli listę liczb losowych i listę liczb podzielnych przez 3 lub 5.
   */
}
