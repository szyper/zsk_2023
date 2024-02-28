using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using _10_2_parking.classes;

namespace _10_2_parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.SetBrand("Ford");
            //Console.WriteLine(c1.Brand);
            c1.SetModel("Ka");
            c1.SetYear(2002);
            c1.SetColor(Color.Czerwony);

            //Car c2 = new Car { Brand = "Toyota" };

            Parking p1 = new Parking { Name = "Center", Cars = new Car[5] };

        }
    }
}

/*
 * •	Utwórz typ wyliczenia Status, który reprezentuje stan miejsca na parkingu (np. Wolne, Zajęte, Zarezerwowane, Nieczynne).
•	Dodaj właściwość Status do klasy Parking, która zwraca tablicę statusów wszystkich miejsc na parkingu.
•	Dodaj metodę ReserveCar, która rezerwuje miejsce na parkingu dla podanego samochodu, jeśli jest wolne (lub wyświetla komunikat, że nie ma wolnych miejsc lub miejsce jest już zarezerwowane).
•	Dodaj metodę CancelReservation, która anuluje rezerwację miejsca na parkingu dla podanego samochodu, jeśli jest zarezerwowane (lub wyświetla komunikat, że podany samochód nie ma rezerwacji lub miejsce jest zajęte).
•	Dodaj metodę ShowStatus, która wyświetla status wszystkich miejsc na parkingu w formacie: Miejsce {indeks}: {status}.
•	Zmodyfikuj metodę ShowCars, aby wyświetlała również status miejsca obok informacji o samochodzie (lub informowała, że miejsce jest wolne lub zarezerwowane).
•	Zmodyfikuj metodę AddCar, aby sprawdzała, czy miejsce jest wolne lub zarezerwowane dla podanego samochodu, zanim doda go do parkingu (lub wyświetlała odpowiedni komunikat).
•	Zmodyfikuj metodę RemoveCar, aby sprawdzała, czy miejsce jest zajęte przez podany samochód, zanim go usunie z parkingu (lub wyświetlała odpowiedni komunikat).
*/