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

      Console.WriteLine();

      List<int> listDivisibleBy3Or5 = divisibleBy3Or5(list);

      Console.WriteLine($"\nLista liczb podzielnych przez 3 lub 5 ({listDivisibleBy3Or5.Count}):");
      foreach (int i in listDivisibleBy3Or5)
      {
        Console.Write($"{i} ");
      }
      Console.WriteLine("\n\n");
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
  }
}
/*
 *  Utwórz listę liczb całkowitych i wypełnij ją losowymi wartościami z zakresu od 1 do
100.
 Napisz metodę, która przyjmuje jako parametr listę liczb i zwraca listę liczb, które są
podzielne przez 3 lub 5.
 Wyświetl na konsoli listę liczb losowych i listę liczb podzielnych przez 3 lub 5.
 */
