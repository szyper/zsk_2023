using _11_2_konstruktory.classes;
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
      #region  animal
      /*
      Animal a = new Animal("Burek");
      Console.WriteLine(a.Describe());
      a.BirthDate = new DateTime(2020, 1, 10);
      Console.WriteLine(a.Describe());

      Animal a2 = new Animal("Mruczek", new DateTime(2020, 2, 14));
      Console.WriteLine(a2.Describe());
      a2.BirthDate = new DateTime(2020, 1, 10);
      Console.WriteLine(a2.Describe());

      Animal a3 = new Animal("Ptaszek", new DateTime(2020, 2, 14), false);
      Console.WriteLine(a3.Describe());
      a3.BirthDate = new DateTime(2020, 1, 10);
      Console.WriteLine(a3.Describe());

      Animal a4 = new Animal("Ptaszek", new DateTime(2020, 2, 14), false, Kind.Ptak);
      Console.WriteLine(a4.Describe());
      a4.BirthDate = new DateTime(2020, 1, 10);
      Console.WriteLine(a4.Describe());
      */
      #endregion

      //tworzenie listy zwierząt
      List<Animal> animals = new List<Animal>();

      //wyświetlenie menu głównego
      ShowMainMenu(animals);

      Console.ReadKey();
    }

    private static void ShowMainMenu(List<Animal> animals)
    {
      //wyczyszczenie konsoli
      Console.Clear();

      //wyświetlenie opcji menu
      Console.WriteLine("Witaj w programie do zarządzania zwierzętami");

      Console.WriteLine("1. Dodaj zwierzę");
      Console.WriteLine("2. Pokaż listę zwierząt");
      Console.WriteLine("3. Pokaż szczegóły zwierzęcia");
      Console.WriteLine("4. Usuń zwierzę");
      Console.WriteLine("5. Zakończ program\n");

      Console.Write("Wybierz jedną z opcji:");

      //wczytanie wyboru użytkownika
      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          AddNewAnimal(animals);
          break;
        case "2":
          ShowAnimalList(animals);
          break;
        case "3":
          ShowAnimalDetails(animals);
          break;
        case "4":
          RemoveAnimal(animals);
          break;
        case "5":
          Console.WriteLine("Dziękujemy za skorzystanie z programu");
          return;
        default:
          Console.WriteLine("Niepoprawna opcja. Naciśnij dowolny klawisz, aby spróbować ponownie");
          Console.ReadKey();
          ShowMainMenu(animals);
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
      Console.Write("Czy zwierzę jest ssakiem? (tak/nie):");
      bool isMammal = Console.ReadLine().ToLower() == "tak"; //true/false
      Console.Write("Podaj rodzaj zwierzęcia (Ptak, Ryba, Gad, Płaz, Ssak):");
      Kind kind = (Kind)Enum.Parse(typeof(Kind), Console.ReadLine());

      Animal animal = new Animal(name, birthDate, isMammal, kind);
      animals.Add(animal);

      Console.WriteLine("\nDodano nowe zwierzę: " + animal.Name);
      Console.WriteLine("\nWciśnij dowolny klawisz, aby wrócić do menu głównego\n");
      Console.ReadKey();
      ShowMainMenu(animals);
    }

    private static void ShowAnimalList(List<Animal> animals)
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
      ShowMainMenu(animals);
    }

    private static void ShowAnimalDetails(List<Animal> animals)
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

        Console.Write("\nPodaj numer zwierzęcia, którego szczegóły chcesz zobaczyć:");
        int index = int.Parse(Console.ReadLine()) - 1;

        //dokończyć 2024.03.25
      }
    }

    private static void RemoveAnimal(List<Animal> animals)
    {
      throw new NotImplementedException();
    }
  }
}
