namespace _8_1_listy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<int> ints = new List<int>();
      ints.Add(1);
      ints.Add(-1);
      ints.Add(100);

      Console.WriteLine("Długość listy: {0}", ints.Count);
      ints.Add(1);
      Console.WriteLine("Długość listy: {0}", ints.Count);

      foreach (int i in ints)
      {
        Console.Write($"{i} ");
      }
      Console.WriteLine();

      ints.Remove(1);
      foreach (int i in ints)
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
