using _12_2_destruktory_symulator.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_destruktory_symulator
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<Car> cars = new List<Car>();
      Dictionary<int, Car> carDictionary = new Dictionary<int, Car>();

      while (true)
      {
        Console.WriteLine("Menu symulatora jazdy samochodem");
        Console.WriteLine("1. Dodaj samochód");
        Console.WriteLine("2. Wyświetl listę samochodów");
        Console.WriteLine("3. Jedź samochodem");
        Console.WriteLine("4. Symuluj losowe uszkodzenie");
        Console.WriteLine("5. Zezłomuj samochód");
        Console.WriteLine("6. Wyjście");

        Console.Write("Wybierz opcję (1-6):");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
          case 1:
            Console.Write("Podaj markę:");
            string brand = Console.ReadLine();
            Console.Write("Podaj model:");
            string model = Console.ReadLine();
            Car newCar = new Car(brand, model);
            cars.Add(newCar);
            carDictionary[cars.Count] = newCar;
            Console.WriteLine($"\nDodano samochód {brand} {model}\n");
            break;
          case 2:
            Console.WriteLine("Lista samochodów:");
            foreach (Car car in cars)
            {
              Console.WriteLine($"{car.Brand} {car.Model}");
            }
            break;
          case 3:
            Console.Write("Podaj numer samochodu do jazdy:");
            int carNumber = int.Parse(Console.ReadLine());
            if (carDictionary.TryGetValue(carNumber,out Car selectedCar))
            {
              selectedCar.Drive();
            }
            else
            {
              Console.WriteLine("\nNieprawidłowy numer samochodu\n");
            }
            break;
        }
      }

      Console.ReadKey();
    }
  }
}
