using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_parking.classes
{
    enum Status
    {
        Wolne,
        Zajęte,
        Zarezerwowane,
        Nieczynne
    }
    internal class Parking
    {
        public string Name { get; set; }
        public Car[] cars { get; set; }
        public Status[] Status {  get; set; }

        public void AddCar(Car car)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                {
                    cars[i] = car;
                    Console.WriteLine($"\nDodano samochód do cars[{i}]");
                    return;
                }
            }
            Console.WriteLine("\nBrak miejsc parkingowych");
        }

        public void RemoveCar(int index)
        {
            if (index >= 0 && index < cars.Length)
            {
                cars[index] = null;
                Console.WriteLine("Usunięto samóch z miejsca parkingowego {index}");
            }
            else
            {
                Console.WriteLine("Brak miejsca o takim numerze na parkingu");
            }
        }

        public void ShowCars()
        {
            Console.WriteLine($"Ilość miejsc na parkingu: {cars.Length}");
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null)
                {
                    Console.WriteLine("Miejsce parkingowe {i}");
                    cars[i].ShowInformation();
                }
                else
                {
                    Console.WriteLine("Miejsce parkingowe {i} jest wolne");
                }
            }
        }
    }
}
