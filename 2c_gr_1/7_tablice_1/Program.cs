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
      DisplayArray(tabA, "tabA");

    }

    //funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę
    public static int[] CreateArray(string name)
    {
      Console.Write("Podaj rozmiar tablicy {0}: ", name);
      int size = int.Parse(Console.ReadLine());
      int[] array = new int[size];
      return array;
    }

    //funkcja statyczna, która wyświetla zawartość tablicy
    public static void DisplayArray(int[] array, string name)
    {
      Console.Write("Zawartość tablicy {0}:", name);
      for (int i = 0; i < array.Length; i++)
      {
        Console.WriteLine(array[i] + " ");
      }
      Console.WriteLine();
    }

    //funkcja statyczna, która ustawia elementy tablicy

  }
}