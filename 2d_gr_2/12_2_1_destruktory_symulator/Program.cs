using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_destruktory_symulator.classes
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<Car> cars = new List<Car>();
      Dictionary<int, Car> carDictionary = new Dictionary<int, Car>();

      while (true)
      {
        DisplayMenu();

        int choice = GetUserInput();

        switch (choice)
        {
          case 1:
            AddCar(cars, carDictionary);
            break;
          case 2:
            DisplayCars(carDictionary);
            break;
          case 3:
            DisplayCars(carDictionary);
            if (carDictionary.Count != 0)
            {
              DriveCar(carDictionary);
            }
            break;
          case 4:
            DisplayCars(carDictionary);
            if (carDictionary.Count != 0)
            {
              SimulateDamage(carDictionary);
            }
            break;
          case 5:
            DisplayCars(carDictionary);
            if (carDictionary.Count != 0)
            {
              ScrapCar(cars, carDictionary);
            }
            break;
          case 6:
            Console.WriteLine("Zamykanie symulatora");
            return;
          default:
            break;
        }
        Console.WriteLine("\nNaciśnij dowolny klawisz, aby powrócić do menu\n");
        Console.ReadKey();
      }

      Console.ReadKey();
    }

    private static void ScrapCar(List<Car> cars, Dictionary<int, Car> carDictionary)
    {
      int carNumber = GetUserInput(carDictionary);
      Console.WriteLine($"\nSamochód {carDictionary[carNumber].Brand} {carDictionary[carNumber].Model} został usunięty\n");
      cars.RemoveAt(carNumber);
      carDictionary.Remove(carNumber);
    }

    private static void SimulateDamage(Dictionary<int, Car> carDictionary)
    {
      int carNumber = GetUserInput(carDictionary);
      Car carToSimulateDamage = carDictionary[carNumber];
      carToSimulateDamage.SimulateRandomDamage();
    }

    private static void DriveCar(Dictionary<int, Car> carDictionary)
    {
      int carNumber = GetUserInput(carDictionary);
      Car carToDrive = carDictionary[carNumber];
      carToDrive.Drive();
    }

    private static void DisplayCars(Dictionary<int, Car> carDictionary)
    {
      if (carDictionary.Count == 0)
      {
        Console.WriteLine("\nBrak samochodów do wyświetlenia\n");
      }
      else
      {
        Console.WriteLine("\nLista samochodów:");
        foreach (var carEntry in carDictionary)
        {
          int key = carEntry.Key;
          Car car = carEntry.Value;
          Console.WriteLine($"Klucz: {key}, marka: {car.Brand}, model: {car.Model}");
        }
      }
    }

    private static void AddCar(List<Car> cars, Dictionary<int, Car> carDictionary)
    {
      Console.Clear();
      Console.Write("Podaj markę:");
      string brand = Console.ReadLine();
      Console.Write("Podaj model:");
      string model = Console.ReadLine();
      Car newCar = new Car(brand, model);
      cars.Add(newCar);
      carDictionary[cars.Count] = newCar;
      Console.WriteLine("\nSamochód dodany pomyślnie\n");
    }

    //nie wykorzytsaliśmy przeciążenia metody tylko skorzystaliśmy z parametru opcjonalnego
    private static int GetUserInput(Dictionary<int, Car> carDictionary = null)
    {
      int input;
      while (true)
      {
        Console.Write("\nPodaj wartość (int):");
        if (int.TryParse(Console.ReadLine(), out input))
        {
          if (carDictionary == null || carDictionary.ContainsKey(input))
          {
            return input;
          }
          else
          {
            Console.WriteLine("\nNumer samochodu nie istnieje w słowniku\n");
          }
        }
        else
        {
          Console.WriteLine("\nNieprawidłowy format. Spróbuj ponownie\n");
        }
      }
    }

    private static void DisplayMenu()
    {
      Console.Clear();
      Console.WriteLine("Menu symulatora jazdy samochodem");
      Console.WriteLine("1. Dodaj samochód");
      Console.WriteLine("2. Wyświetl listę samochodów");
      Console.WriteLine("3.Jedź samochodem");
      Console.WriteLine("4. Symuluj losowe uszkodzenie");
      Console.WriteLine("5. Zezłomuj samochód");
      Console.WriteLine("6. Wyjście");
    }
  }
}
