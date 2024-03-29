﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        public Car[] Cars { get; set; }

        public Status[] status { get; set; }
        public Car[] ReservedCar { get; set; }

        public void AddCar(Car car)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] == null)
                {
                    Cars[i] = car;
                    Console.WriteLine($"Zaparkowano samochód na miejscu {i}");
                    return;
                }
            }
            Console.WriteLine("Brak miejsc na parkingu");
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
            Console.WriteLine($"Parking {Name} ma {Cars.Length} miejsc parkingowych");
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] != null)
                {
                    Console.Write($"Miejsce {i}:");
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
                if (Cars[i] == null && status[i] == Status.Wolne)
                {
                    ReservedCar[i] = car;
                    status[i] = Status.Zarezerwowane;
                    Console.WriteLine($"Zarezerwowano miejsce postojowe {i} dla samochodu");
                    return;
                }
            }
            Console.WriteLine("Brak miejsc postojowych");
        }
    }
}