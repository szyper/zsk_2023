using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_parking.classes
{
    enum status
    {
        Wolne,
        Zajęte,
        Zarezerwowane,
        Nieczynne
    }
    internal class Parking
    {
        public string Name { get; set; }
        public Car[] Cars { get; set; }
        public status[] Status { get; set; }
        public Car[] ReservedCar { get; set; }
        public void AddCar(Car car)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] == null)
                {
                    Cars[i] = car;
                    Console.WriteLine($"Dodano samochód na pozycji {i}");
                    return;
                }
            }
            Console.WriteLine("Brak wolnych miejsc na parkingu");
        }

        public void RemoveCar(Car car, int i)
        {
            if (Cars[i] == null || i > Cars.Length || i <= 0)
            {
                Console.WriteLine("Podany indeks jest nieprawidłowy lub miejsce jest puste");
            }
            else
            {
                Cars[i] = null;
            }
        }

        public void ShowCars()
        {
            Console.WriteLine($"Parking {Name} ma {Cars.Length} miejsc parkingowych:");
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] != null)
                {
                    Console.Write($"Miejsce {1}:");
                    Cars[i].ShowInformation();
                }
                else
                {
                    Console.WriteLine($"Miejsce {i}: wolne");
                }
            }
        }

        public void ReserveCar(Car car)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] == null && Status[i] == status.Wolne)
                {
                    ReservedCar[i] = car;
                    Status[i] = status.Zarezerwowane;
                    Console.WriteLine($"Zarezerwowane miejsce {i} dla samochodu");
                    return;
                }
            }
            Console.WriteLine("Brak wolnych miejsc na parkingu");
        }
    }
}