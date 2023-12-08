namespace _8_1_listy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<int> ints = new List<int>();
      //Console.WriteLine($"Liczba elementów w liście: {ints.Count}");

      ints.Add(10);
      ints.Add(5);
      //Console.WriteLine($"Liczba elementów w liście: {ints.Count}");

      foreach( int i in ints )
      {
        Console.Write($"{i} ");
      }
      Console.WriteLine();

      ints.Add(10);
      ints.Add(1);

      foreach (int i in ints)
      {
        Console.Write($"{i} ");
      }
      Console.WriteLine();

      ints.Remove(10);
      foreach (int i in ints)
      {
        Console.Write($"{i} ");
      }
      Console.WriteLine();

    }
  }
}
