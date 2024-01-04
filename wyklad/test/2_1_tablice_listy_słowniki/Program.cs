using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main(string[] args)
  {
    // Wczytaj liczbę n
    int n = ReadInt("Podaj liczbę n: ", 0, int.MaxValue);

    // Utwórz tablicę imion i wieków
    string[] names = new string[n];
    int[] ages = new int[n];

    // Wczytaj imiona i wieki
    for (int i = 0; i < n; i++)
    {
      names[i] = ReadString($"Podaj imię osoby {i + 1}: ");
      ages[i] = ReadInt($"Podaj wiek osoby {i + 1}: ", 0, 150);
    }

    // Utwórz listę imion zaczynających się na A
    List<string> namesWithA = names.Where(name => name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();

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
    PrintArray(names, ages);

    Console.WriteLine("Lista imion zaczynających się na A:");
    PrintList(namesWithA);

    Console.WriteLine("Słownik osób pełnoletnich:");
    PrintDictionary(adults);
  }

  // Funkcja, która wczytuje liczbę całkowitą z konsoli i sprawdza, czy mieści się w podanym zakresie
  static int ReadInt(string prompt, int low, int high)
  {
    int result;
    bool valid;
    do
    {
      Console.Write(prompt);
      valid = int.TryParse(Console.ReadLine(), out result) && result >= low && result <= high;
      if (!valid)
      {
        Console.WriteLine($"Podaj liczbę z zakresu {low} - {high}");
      }
    } while (!valid);
    return result;
  }

  // Funkcja, która wczytuje ciąg znaków z konsoli i sprawdza, czy nie jest pusty
  static string ReadString(string prompt)
  {
    string result;
    do
    {
      Console.Write(prompt);
      result = Console.ReadLine();
      if (string.IsNullOrEmpty(result))
      {
        Console.WriteLine("Podaj niepusty ciąg znaków");
      }
    } while (string.IsNullOrEmpty(result));
    return result;
  }

  // Funkcja, która wypisuje zawartość tablicy imion i wieków
  static void PrintArray(string[] names, int[] ages)
  {
    for (int i = 0; i < names.Length; i++)
    {
      Console.WriteLine($"{names[i]} - {ages[i]}");
    }
  }

  // Funkcja, która wypisuje zawartość listy imion
  static void PrintList(List<string> names)
  {
    foreach (string name in names)
    {
      Console.WriteLine(name);
    }
  }

  // Funkcja, która wypisuje zawartość słownika par (imie, wiek)
  static void PrintDictionary(Dictionary<string, int> pairs)
  {
    foreach (var pair in pairs)
    {
      Console.WriteLine($"{pair.Key} - {pair.Value}");
    }
  }
}
