using System;

class Program
{
  // Zadeklaruj zmienne globalne do przechowywania tablicy, liczby wierszy, kolumn i zakresu liczb losowych
  static int[,]? array;
  static int rows;
  static int cols;
  static int min;
  static int max;

  static void Main(string[] args)
  {
    // Wywołaj metodę GenerateMenu, która generuje menu do zadania z tablicami wielowymiarowymi
    GenerateMenu();
  }

  static void GenerateMenu()
  {
    // Wyświetl tytuł i opis zadania
    Console.WriteLine("Zadanie z tablicami wielowymiarowymi");
    Console.WriteLine("Napisz program, który wczytuje z klawiatury liczbę n i tworzy tablicę dwuwymiarową o wymiarach n x n. Następnie program wypełnia tablicę liczbami losowymi z zakresu od 1 do 100 i wyświetla jej zawartość na ekranie. Na koniec program oblicza i wyświetla sumę elementów na głównej przekątnej tablicy.");

    // Wyświetl opcje do wyboru
    Console.WriteLine("Wybierz funkcję statyczną:");
    Console.WriteLine("1. WczytajLiczbe");
    Console.WriteLine("2. UtworzTablice");
    Console.WriteLine("3. WypelnijTablice");
    Console.WriteLine("4. WyswietlTablice");
    Console.WriteLine("5. ObliczSume");
    Console.WriteLine("q. Zakończ program");

    // Wczytaj wybór użytkownika
    int function = ReadNumber();

    // Wykonaj odpowiednią funkcję w zależności od wyboru
    switch (function)
    {
      case 1:
        // Wywołaj funkcję WczytajLiczbe
        Console.WriteLine("Wywołujesz funkcję WczytajLiczbe.");
        // Wywołaj funkcję WczytajLiczbe i zapisz jej wynik w zmiennej liczba
        int liczba = ReadNumber();
        // Wyświetl wartość zmiennej liczba na ekranie
        Console.WriteLine("Wczytana liczba to: " + liczba);
        break;
      case 2:
        // Wywołaj funkcję UtworzTablice
        Console.WriteLine("Wywołujesz funkcję UtworzTablice.");
        // Poproś użytkownika o podanie liczby wierszy i kolumn tablicy
        Console.WriteLine("Podaj liczbę wierszy tablicy:");
        rows = ReadNumber();
        Console.WriteLine("Podaj liczbę kolumn tablicy:");
        cols = ReadNumber();
        // Wywołaj funkcję UtworzTablice z parametrami rows i cols i zapisz jej wynik w zmiennej array
        array = CreateArray(rows, cols);
        // Wyświetl informację o utworzeniu tablicy
        Console.WriteLine("Utworzono tablicę o wymiarach " + rows + " x " + cols + ".");
        break;
      case 3:
        // Wywołaj funkcję WypelnijTablice
        Console.WriteLine("Wywołujesz funkcję WypelnijTablice.");
        // Poproś użytkownika o podanie zakresu liczb losowych
        Console.WriteLine("Podaj dolną granicę zakresu liczb losowych:");
        min = ReadNumber();
        Console.WriteLine("Podaj górną granicę zakresu liczb losowych:");
        max = ReadNumber();
        // Sprawdź, czy użytkownik ma już utworzoną tablicę
        if (array == null)
        {
          // Jeśli nie, poproś go o utworzenie tablicy
          Console.WriteLine("Nie masz jeszcze utworzonej tablicy. Utwórz ją najpierw.");
          // Wywołaj funkcję UtworzTablice i zapisz jej wynik w zmiennej array
          array = CreateArray(rows, cols);
        }
        // Wywołaj funkcję WypelnijTablice z parametrami array, min i max i zapisz jej wynik w zmiennej array
        array = FillArray(array, min, max);
        // Wyświetl informację o wypełnieniu tablicy
        Console.WriteLine("Wypełniono tablicę liczbami losowymi z zakresu od " + min + " do " + max + ".");
        break;
      case 4:
        // Wywołaj funkcję WyswietlTablice
        Console.WriteLine("Wywołujesz funkcję WyswietlTablice.");
        // Sprawdź, czy użytkownik ma już utworzoną i wypełnioną tablicę
        if (array == null)
        {
          // Jeśli nie, poproś go o utworzenie i wypełnienie tablicy
          Console.WriteLine("Nie masz jeszcze utworzonej i wypełnionej tablicy. Utwórz ją i wypełnij ją najpierw.");
          // Wywołaj funkcję UtworzTablice i zapisz jej wynik w zmiennej array
          array = CreateArray(rows, cols);
          // Wywołaj funkcję WypelnijTablice z parametrami array, min i max i zapisz jej wynik w zmiennej array
          array = FillArray(array, min, max);
        }
        // Wywołaj funkcję WyswietlTablice z parametrem array
        DisplayArray(array);
        break;
      case 5:
        // Wywołaj funkcję ObliczSume
        Console.WriteLine("Wywołujesz funkcję ObliczSume.");
        // Sprawdź, czy użytkownik ma już utworzoną i wypełnioną tablicę
        if (array == null)
        {
          // Jeśli nie, poproś go o utworzenie i wypełnienie tablicy
          Console.WriteLine("Nie masz jeszcze utworzonej i wypełnionej tablicy. Utwórz ją i wypełnij ją najpierw.");
          // Wywołaj funkcję UtworzTablice i zapisz jej wynik w zmiennej array
          array = CreateArray(rows, cols);
          // Wywołaj funkcję WypelnijTablice z parametrami array, min i max i zapisz jej wynik w zmiennej array
          array = FillArray(array, min, max);
        }
        // Wywołaj funkcję ObliczSume z parametrem array i zapisz jej wynik w zmiennej sum
        int sum = CalculateSum(array);
        // Wyświetl wartość zmiennej sum na ekranie
        Console.WriteLine("Suma elementów na głównej przekątnej tablicy to: " + sum);
        break;
      default:
        // Wyświetl komunikat o nieprawidłowym wyborze
        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
        // Tutaj można dodać kod do ponownego wyświetlenia menu funkcji statycznych
        break;
    }
  }


  // Metoda do wczytywania liczby z klawiatury i zwracania jej jako wartość typu int
  static int ReadNumber()
  {
    // Zadeklaruj zmienną do przechowywania liczby
    int number;

    // Utwórz pętlę do wczytywania danych, dopóki nie zostanie podana poprawna liczba
    while (true)
    {
      // Wczytaj dane z klawiatury jako ciąg znaków
      string? input = Console.ReadLine();

      // Sprawdź, czy użytkownik wpisał q
      if (input == "q")
      {
        // Jeśli tak, zakończ program
        Console.WriteLine("Zakończono program.");
        Environment.Exit(0);
      }

      // Spróbuj wczytać liczbę z ciągu znaków
      bool success = int.TryParse(input, out number);

      // Jeśli wczytanie się powiodło i liczba jest dodatnia, zwróć ją
      if (success && number > 0)
      {
        return number;
      }
      // W przeciwnym razie wyświetl komunikat o błędzie i poproś o ponowne wprowadzenie danych
      else
      {
        Console.WriteLine("Podana wartość nie jest poprawną liczbą dodatnią. Spróbuj ponownie lub wpisz q, aby zakończyć program:");
      }
    }
  }


  // Metoda do tworzenia tablicy dwuwymiarowej o podanych wymiarach i zwracania jej jako wartość typu int[,]
  static int[,] CreateArray(int rows, int cols)
  {
    return new int[rows, cols];
  }

  // Metoda do wypełniania tablicy liczbami losowymi z podanego zakresu i zwracania jej jako wartość typu int[,]
  static int[,] FillArray(int[,] array, int min, int max)
  {
    // Utwórz obiekt klasy Random do generowania liczb losowych
    Random random = new Random();

    // Wypełnij tablicę liczbami losowymi z podanego zakresu
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        array[i, j] = random.Next(min, max + 1);
      }
    }

    // Zwróć tablicę
    return array;
  }

  // Metoda do wyświetlania zawartości tablicy na ekranie i zwracania niczego (void)
  static void DisplayArray(int[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write(array[i, j] + " ");
      }
      Console.WriteLine();
    }
  }

  // Metoda do obliczania sumy elementów na głównej przekątnej tablicy i zwracania jej jako wartość typu int
  static int CalculateSum(int[,] array)
  {
    // Zainicjuj sumę jako zero
    int sum = 0;

    // Dodaj do sumy elementy na głównej przekątnej tablicy
    for (int i = 0; i < array.GetLength(0); i++)
    {
      sum += array[i, i];
    }

    // Zwróć sumę
    return sum;
  }
}
