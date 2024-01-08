using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_lambda_tablice_listy_slowniki
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int n = ReadInt("Podaj liczbę osób:", 0, int.MaxValue);
    }

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
      }
      while (!valid);
      return result;
    }


  }

  /*
   1) Napisz program, który wczytuje z klawiatury liczbę n, a następnie n imion i wieków
  osób.
  2) Użyj tablicy, aby przechować wczytane imiona i wieki.
  3) Użyj listy, aby przechować tylko te imiona, które zaczynają się na literę A lub a.
  4) Użyj słownika, aby przechować pary (imie, wiek) dla wszystkich osób, których wiek jest
  większy niż 18 lat.
  5) Wypisz na ekranie zawartość tablicy, listy i słownika.
  */
}

