﻿using _11_2_konstruktory.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_konstruktory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      #region animalObjects
      /*
      Animal a1 = new Animal("Burek");
      Console.WriteLine(a1.Describe());
      a1.BirthDate = new DateTime(2020, 1, 2);
      Console.WriteLine(a1.Describe());
      a1.showAge();
      Console.WriteLine();

      Animal a2 = new Animal("Burek", new DateTime(2018, 2, 3));
      Console.WriteLine(a2.Describe());
      a2.BirthDate = new DateTime(2019, 1, 2);
      Console.WriteLine(a2.Describe());
      a2.showAge();
      Console.WriteLine();

      Animal a3 = new Animal("papuga", new DateTime(2018, 2, 3), false);
      Console.WriteLine(a3.Describe());
      a3.BirthDate = new DateTime(2019, 1, 2);
      Console.WriteLine(a3.Describe());
      a3.showAge();
      Console.WriteLine();

      Animal a4 = new Animal("papuga", new DateTime(2018, 2, 3), false, Kind.Ptak);
      Console.WriteLine(a4.Describe());
      a4.BirthDate = new DateTime(2019, 1, 2);
      Console.WriteLine(a4.Describe());
      a4.showAge();
      Console.WriteLine();
      */
      #endregion

      List<Animal> animals = new List<Animal>();

      showMainMenu(animals);


      Console.ReadKey();
    }

    private static void showMainMenu(List<Animal> animals)
    {
      Console.Clear();

      Console.WriteLine("Witaj w programie do zarządzania zwierzętami");
      Console.WriteLine("1. Dodaj zwierzę");
      Console.WriteLine("2. Pokaż listę zwierząt");
      Console.WriteLine("3. Pokaż szczegóły zwierzęcia");
      Console.WriteLine("4. Usuń zwierzę");
      Console.WriteLine("5. Zakończ program\n");
      Console.Write("Wybierz jedną z opcji:");

      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          AddNewAnimal(animals);
          break;
        case "2":
          ShowAnimalsList(animals);
          break;
        case "3":
          ShowAnimalsDetails(animals);
          break;
        case "4":
          RemoveAnimal(animals);
          break;
        case "5":
          Console.WriteLine("\nDziękujemy za skorzystanie z programu\n");
          return;
        default:
          Console.WriteLine("Niepoprawna opcja. Naciśnij dowolny klawisz, aby spróbować ponownie");
          Console.ReadKey();
          showMainMenu(animals);
          break;
      }
    }

    private static void AddNewAnimal(List<Animal> animals)
    {
      Console.Clear();

      Console.Write("Podaj nazwę zwierzęcia:");
      string name = Console.ReadLine();
      Console.Write("Podaj datę urodzenia zwierzęcia (w formacie RRRR-MM-DD):");
      DateTime birthDate = DateTime.Parse(Console.ReadLine());
      Console.Write("Czy zwierzę jest ssakiem? (tak / nie):");
      bool isMammal = Console.ReadLine().ToLower() == "tak"; //true/false
      Console.Write("Podaj rodzaj zwierzęcia (Ptak, Ryba, Gad, Płaz, Ssak):");
      Kind kind = (Kind)Enum.Parse(typeof(Kind), Console.ReadLine());

      Animal animal = new Animal(name, birthDate, isMammal, kind);

      animals.Add(animal);

      Console.WriteLine("\nDodano nowe zwierzę: " + animal.Name);
      Console.WriteLine("Wciśnij dowolny klawisz, aby wrócić do menu głównego\n");
      Console.ReadKey();
      showMainMenu(animals);

    }

    private static void ShowAnimalsList(List<Animal> animals)
    {
      Console.Clear();
      if (animals.Count == 0)
      {
        Console.WriteLine("Nie ma żadnych zwierząt na liście");
      }
      else
      {
        Console.WriteLine("Lista zwierząt:");
        for (int i = 0; i < animals.Count; i++)
        {
          Console.WriteLine((i + 1) + ". " + animals[i].Name);
        }
      }
      Console.WriteLine("\nWciśnij dowolny klawisz, aby wrócić do menu głównego\n");
      Console.ReadKey();
      showMainMenu(animals);
    }

    private static void ShowAnimalsDetails(List<Animal> animals)
    {
      Console.Clear();
      if (animals.Count == 0)
      {
        Console.WriteLine("\nNie ma żadnych zwierząt na liście\n");
      }
      else
      {
        for (int i = 0; i < animals.Count; i++)
        {
          Console.WriteLine((i + 1) + ". " + animals[i].Name);
        }

        Console.Write("\nPodaj numer zwierzęcia, którego szczegóły chcesz zobaczyć:");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < animals.Count)
        {
          Animal animal = animals[index];
          Console.WriteLine("\nSzczegóły zwierzęcia:");
          Console.WriteLine("Nazwa: " + animal.Name);
          Console.WriteLine("Data urodzenia: " + animal.BirthDate.ToShortDateString());
          Console.WriteLine("Czy jesteś ssakiem: " + (animal.IsMammal ? "tak" : "nie"));
          Console.WriteLine("Rodzaj: " + animal.Kind);
          animal.showAge();
        }
        else
        {
          Console.WriteLine("\nNiepoprawny numer. Spróbuj ponownie\n");
        }
      }
      Console.WriteLine("\nWciśnij dowolny klawisz, aby wrócić do menu głównego\n");
      Console.ReadKey();
      showMainMenu(animals);
    }

    private static void RemoveAnimal(List<Animal> animals)
    {
      Console.Clear();
      if (animals.Count == 0)
      {
        Console.WriteLine("Nie ma żadnych zwierząt na liście");
      }
      else
      {
        Console.WriteLine("1. Usuń wszystkie zwierzęta");
        Console.WriteLine("2. Usuń jedno zwierzę");

        Console.Write("\nWybierz jedną z opcji:");
        string choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            animals.Clear();
            if (animals.Count == 0)
            {
              Console.WriteLine("\nUsunięto wszystkie zwierzęta\n");
            }
            break;
          case "2":
            for (int i = 0; i < animals.Count; i++)
            {
              Console.WriteLine((i + 1) + ". " + animals[i].Name);
            }

            Console.Write("\nPodaj umer zwierzęcia, które chcesz usunąć:");

            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < animals.Count)
            {
              animals.RemoveAt(index);
              Console.WriteLine("\nUsunięto zwierzę\n");
            }
            else
            {
              Console.WriteLine("\nNiepoprawny numer. Spróbuj ponownie");
            }
            break;
          default:
            Console.WriteLine("\nNiepoprawna opcja. Spróbuj ponownie\n");
            break;
        }
        Console.WriteLine("\nWciśnij dowolny klawisz, aby wrócić do menu głównego\n");
        Console.ReadKey();
        showMainMenu(animals);
      }
    }
  }
}
