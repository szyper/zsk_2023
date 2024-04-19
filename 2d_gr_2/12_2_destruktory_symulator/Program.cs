﻿using System;
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
        Console.WriteLine("Menu symulatora jazdy samochodem");
        Console.WriteLine("1. Dodaj samochód");
        Console.WriteLine("2. Wyświetl listę samochodów");
        Console.WriteLine("3.Jedź samochodem");
        Console.WriteLine("4. Symuluj losowe uszkodzenie");
        Console.WriteLine("5. Zezłomuj samochód");
        Console.WriteLine("6. Wyjście");

        Console.Write("Podaj opcję:");
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
            Console.WriteLine("\nSamochód dodany pomyślnie\n");
            break;
          case 2:
            Console.WriteLine("Lista samochodów");
            foreach (Car car in cars)
            {
              Console.WriteLine($"{car.Brand} {car.Model}");
            }
            Console.WriteLine();
            break;
          case 3:
            Console.Write("Podaj numer samochodu do jazdy");
            int carNumber = int.Parse(Console.ReadLine());
            if (carDictionary.TryGetValue(carNumber, out Car selectedCar))
            {
              selectedCar.Drive();
            }
            else
            {
              Console.WriteLine("\nNieprawidłowy numer samochodu\n");
            }
            break;
          case 4:
            Console.Write("Podaj numer samochodu do symulacji uszkodzenia:");
            int damagedCarNumber = int.Parse(Console.ReadLine());
            if (carDictionary.TryGetValue(damagedCarNumber, out Car damagedCar))
            {
              damagedCar.SimulateRandomDamage();
            }
            else
            {
              Console.WriteLine("\nNieprawidłowy numer samochodu\n");
            }
            break;
          case 5:
            Console.Write("Podaj numer samochodu do zezłomowania:");
            int scrappedCarNumber = int.Parse(Console.ReadLine());
            if (carDictionary.TryGetValue(scrappedCarNumber, out Car scrappedCar))
            {
              scrappedCar = null;
              GC.Collect();
              Console.WriteLine($"Samochód {scrappedCarNumber} został zezłomowany");
            }
            else
            {
              Console.WriteLine("\nNieprawidłowy numer samochodu\n");
            }
            break;
          case 6:
            Console.WriteLine("Zamykanie symulatora");
            return;
          default:
            break;
        }
      }

      Console.ReadKey();
    }
  }
}
