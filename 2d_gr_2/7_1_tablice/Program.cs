namespace _7_1_tablice
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] tabA = CreateArray("tabA");
    }

    public static int[] CreateArray(string name)
    {
      Console.Write($"Podaj rozmiar tablicy {name}:");
      int size = int.Parse(Console.ReadLine());
      int[] array = new int[size];
      return array;
    }

  }  
}