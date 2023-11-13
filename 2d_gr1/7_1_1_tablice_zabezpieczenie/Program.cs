using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace _7_1_tablice
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] tab = new int[3];
      for (int i = 0; i < tab.Length; i++)
      {
        tab[i] = i;
      }

      for (int i = 0;i < tab.Length; i++)
      {
        Console.Write(tab[i] + " ");
      }
      Console.Clear();

      //#################################################################

      int[] tabA = CreateArray("tabA");
      DisplayArray(tabA, "tabA");
      Console.WriteLine();
      SetArray(tabA, "tabA");
      Console.WriteLine();
      DisplayArray(tabA, "tabA");
      Console.WriteLine();
    }

    //funkcja statyczna, któa pozwala wprowadzić rozmiar tablicy i nazwę
    public static int[] CreateArray(string name)
    {
      Console.Write("Podaj rozmiar tablicy {0}:", name);
      int size = int.Parse(Console.ReadLine());
      int[] array = new int[size];
      return array;
    }

    //funkcja statyczna, która wyświetla zawartość tablicy
    public static void DisplayArray(int[] array, string name)
    {
      Console.WriteLine("Zawartość tablicy {0}", name);
      for (int i = 0; i < array.Length ; i++)
      {
        Console.Write(array[i] + " ");
      }
    }

    //funkcja statyczna, która ustawia elementy tablicy
    public static void SetArray(int[] array, string name)
    {
      Console.WriteLine("Podaj elementy tablicy {0}", name);
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write("array[{0}] = ", i);
        array[i] = int.Parse(Console.ReadLine());
      }
    }
  }
}