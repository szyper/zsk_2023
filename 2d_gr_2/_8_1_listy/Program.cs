namespace _8_1_listy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<int> ints = new List<int>();

      ints.Add(1);
      ints.Add(10);
      ints.Add(5);

      Console.WriteLine($"Długość listy: {ints.Count}");

      ints.Add(5);
      ints.Add(1);
      Console.WriteLine($"Długość listy: {ints.Count}");

      foreach( int i in ints )
      {
        Console.Write($"{i} ");
      }
      Console.WriteLine();

      ints.Remove(1);
      foreach (int i in ints)
      {
        Console.Write($"{i} ");
      }

    }
  }
}
