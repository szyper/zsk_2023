﻿namespace _9_slownik_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInt("Podaj liczbę osób:", 0, int.MaxValue);

            string[] names = new string[n];
            int[] ages = new int[n];

            for (int i = 0; i < n; i++)
            {
                names[i] = ReadString($"Podaj imię osoby {i+1}:");
                ages[i] = ReadInt($"Podaj wiek osoby {i + 1}:", 0, 150);
            }

            List<string> namesWithA = names.Where(name => name.StartsWith("A")).ToList();
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

        static void PrintArray(string[] names, int[] ages)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]} - {ages[i]}");
            }
        }
    }
}

/*
 1) Napisz program, który wczytuje z klawiatury liczbę n, a następnie n imion i wieków
osób.
2) Użyj tablicy, aby przechować wczytane imiona i wieki.
3) Użyj listy, aby przechować tylko te imiona, które zaczynają się na literę A.
4) Użyj słownika, aby przechować pary (imie, wiek) dla wszystkich osób, których wiek jest
większy niż 18 lat.
5) Wypisz na ekranie zawartość tablicy, listy i słownika.
*/
