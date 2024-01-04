using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    // Wczytaj liczbę n
    Console.Write("Podaj liczbę n: ");
    //Użyj operatora ! (null-forgiving), aby zapewnić kompilatorowi, że ciąg znaków nie jest null. Na przykład: int.Parse(Console.ReadLine()!)
    int n = int.Parse(Console.ReadLine()!);

    // Utwórz tablicę imion i wieków
    string[] names = new string[n];
    int[] ages = new int[n];

    // Wczytaj imiona i wieki
    for (int i = 0; i < n; i++)
    {
      Console.Write($"Podaj imię osoby {i + 1}: ");
      names[i] = Console.ReadLine();
      Console.Write($"Podaj wiek osoby {i + 1}: ");
      ages[i] = int.Parse(Console.ReadLine());
    }

    // Utwórz listę imion zaczynających się na A
    List<string> namesWithA = new List<string>();
    for (int i = 0; i < n; i++)
    {
      if (names[i].StartsWith("A"))
      {
        namesWithA.Add(names[i]);
      }
    }

    // Utwórz słownik par (imie, wiek) dla osób pełnoletnich
    Dictionary<string, int> adults = new Dictionary<string, int>();
    for (int i = 0; i < n; i++)
    {
      if (ages[i] > 18)
      {
        adults.Add(names[i], ages[i]);
      }
    }

    // Wypisz zawartość tablicy, listy i słownika
    Console.WriteLine("Tablica imion i wieków:");
    for (int i = 0; i < n; i++)
    {
      Console.WriteLine($"{names[i]} - {ages[i]}");
    }

    Console.WriteLine("Lista imion zaczynających się na A:");
    foreach (string name in namesWithA)
    {
      Console.WriteLine(name);
    }

    Console.WriteLine("Słownik osób pełnoletnich:");
    foreach (var pair in adults)
    {
      Console.WriteLine($"{pair.Key} - {pair.Value}");
    }
  }
}
