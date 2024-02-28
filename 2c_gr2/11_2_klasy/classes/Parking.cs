using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_parking.classes
{
    internal class Parking
    {
        public string Name {  get; set; }
        public Car[] Cars { get; set; }

        public void AddCar(Car car)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] == null)
                {
                    Cars[i] = car;
                    Console.WriteLine($"Dodano samochód na miejscu parkingowym nr {i}");
                    return;
                }
            }
            Console.WriteLine("Brak wolnych miejsc parkingowych");
        }

        public void RemoveCar(int index)
        {
            if (index >= 0 && index < Cars.Length)
            {
                if (Cars[index] != null)
                {
                    Cars[index] = null;
                    Console.WriteLine($"Samochód został usunięty z miejsca parkingowego nr {index}");
                }
                else
                {
                    Console.WriteLine("W podanym miejscu prakingowym nie ma samochodu");
                }
            }
            else
            {
                Console.WriteLine("Błędny numer miejsca postojowego na parkingu");
            }
        }

        public void ShowCars()
        {
            Console.WriteLine($"Parking {Name} ma {Cars.Length} miejsc parkingowych");
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] != null)
                {
                    Console.WriteLine($"Miejsce {i}");
                    Cars[i].ShowInformation();
                }
                else
                {
                    Console.WriteLine($"Wolne miejsce nr {i}");
                }
            }
        }
    }
}
