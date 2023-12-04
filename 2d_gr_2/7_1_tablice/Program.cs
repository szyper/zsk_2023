namespace _7_1_tablice
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] tabA = CreateArray("tabA");
      if (tabA != null)
      {
        SetArray(tabA, "tabA"); 
        DisplayArray(tabA, "tabA");
      }
    }

    public static int[] CreateArray(string name)
    {
      Console.Write($"Podaj rozmiar tablicy <0, {int.MaxValue}>{name}:");
      int size = 0;
      try
      {
        size = int.Parse(Console.ReadLine());
        if (size <= 0) throw new ArgumentException("Rozmiar tablicy musi być dodatni");
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine("\nWystąpił błąd: {0}\n\n", ex.Message);
        return null;
      }
      

      int[] array = new int[size];
      return array;
    }

    public static void SetArray(int[] array, string name)
    {
      Console.WriteLine($"\nPodaj elementy tablicy {name}");
      for (int i = 0; i < array.Length; i++)
      {
        Console.WriteLine($"Podaj element tablicy {i+1}");
        try
        {
          array[i] = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
          Console.WriteLine("\nWystąpił błąd: {0}\n", ex.Message);
          i--;
        }
      }
    }

    public static void DisplayArray(int[] array, string name)
    {
      Console.WriteLine($"Wyświetlenie zawartości tablicy {name}:");
      int i = 0;
      foreach (var element in array)
      {
        Console.WriteLine($"{name}[{i}]: {element}");
        i++;
      }
    }
  }  
}