namespace _7_1_tablice
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] tabA = CreateArray("tabA");
      if (tabA != null ) 
      {
        SetArray(tabA, "tabA");
        DisplayArray(tabA, "tabA");
      }
    }

    public static int[] CreateArray(string name)
    {
      Console.Write($"Podaj rozmiar tablicy {name } <0 ; {int.MaxValue}>:");
      int size = 0;
      try
      {
        size = int.Parse(Console.ReadLine());
        if (size <= 0) throw new ArgumentException("Rozmiar tablicy musi być dodatni");
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine("Wystąpił błąd: {0}", ex.Message);
        return null;
      }
      catch(FormatException)
      {
        Console.WriteLine("\nBłęny format danych, rozmiar tablicy musi być liczbą całkowitą dodatnią");
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
        Console.Write($"Podaj element tablicy {i+1}:");
        try
        {
          array[i] = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
          Console.WriteLine("\nWystąpił błąd: {0}", ex.Message);
          i--;
        }
      }
    }

    public static void DisplayArray(int[] array, string name)
    {
      Console.WriteLine($"\nWyświetlenie zawartości tablicy {name}");
      int i = 0;
      foreach (int element in array)
      {
        Console.WriteLine($"{name}[{i}]: {element}");
        i++;
      }
    }
  }
}