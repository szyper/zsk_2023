namespace _7_tablice_1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] tab = new int[5];
      for (int i = 0; i < tab.Length; i++)
      {
        tab[i] = i;
      }

      for (int i = 0;i < tab.Length; i++)
      {
        Console.WriteLine("tab[{0}] = {1}",i, tab[i]);
      }

      //#######################################################################

      Console.Clear();

      int[] tabA = CreateArray("tabA");
      if (tabA != null)
      {
        SetArray(tabA, "tabA");
        DisplayArray(tabA, "tabA");
      }
    }

    //funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę

    public static int[] CreateArray(string name)
    {
      Console.Write("Podaj rozmiar tablicy {0}: ", name);
      int size = 0;
      try
      {
        size = int.Parse(Console.ReadLine());
        if (size <= 0) throw new ArgumentException("Rozmiar tablicy musi być dodatni");
      }
      catch(ArgumentException ex)
      {
        Console.WriteLine("\nWystąpił błąd: {0}", ex.Message);
        return null;
      }
      catch (FormatException)
      {
        Console.WriteLine("\nBłędny format danych, rozmiar musi być liczbą całkowitą dodatnią");
        return null;
      }
      int[] array = new int[size];
      return array;
    }

    //funkcja statyczna, która wyświetla zawartość tablicy

    public static void DisplayArray(int[] array, string name)
    {
      Console.Write("\nZawartość tablicy {0}:\n", name);
      for (int i = 0; i < array.Length; i++)
      {
        Console.WriteLine(array[i] + " ");
      }
      Console.WriteLine();
    }

    //funkcja statyczna, która ustawia elementy tablicy

    public static void SetArray(int[]array, string name)
    {
      Console.WriteLine($"\nPodaj elementy tablicy {name}:");
      for (int i = 0; i < array.Length ; i++)
      {
        Console.Write($"Podaj element tablicy {i+1}:");
        try
        {
          array[i] = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
          Console.WriteLine("\nWystąpił błąd: {0}", ex.Message);
        }
      }
    } 

  }
}