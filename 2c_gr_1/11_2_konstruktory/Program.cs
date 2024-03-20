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

      List <Animal> animals = new List<Animal>();

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
  }
}
