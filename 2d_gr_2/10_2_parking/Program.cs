using System;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using _10_2_parking.classes;

namespace _10_2_parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car c1 = new Car { Brand = "Ford", Model = "Ka"};
            Car c1 = new Car();

            c1.SetBrand("Ford");
            Console.WriteLine(c1.Brand);
            c1.SetModel("Ka");
            c1.SetYear(2000);
            c1.SetColor(Color.Niebieski);
            Parking p1 = new Parking { Name = "Center", Cars = new Car[5] };
            Console.ReadKey();
        }
    }
}
/*
 * Codeshare logo
 ShareSign UpLog In
1
 Utwórz typ wyliczenia Status, który reprezentuje stan miejsca na parkingu (np. Wolne, Zajęte,
2
Zarezerwowane, Nieczynne).
3
 Dodaj właściwość Status do klasy Parking, która zwraca tablicę statusów wszystkich miejsc na parkingu.
4
 Dodaj metodę ReserveCar, która rezerwuje miejsce na parkingu dla podanego samochodu, jeśli jest
5
wolne (lub wyświetla komunikat, że nie ma wolnych miejsc lub miejsce jest już zarezerwowane).
6
 Dodaj metodę CancelReservation, która anuluje rezerwację miejsca na parkingu dla podanego
7
samochodu, jeśli jest zarezerwowane (lub wyświetla komunikat, że podany samochód nie ma
8
rezerwacji lub miejsce jest zajęte).
9
 Dodaj metodę ShowStatus, która wyświetla status wszystkich miejsc na parkingu w formacie: Miejsce
10
{indeks}: {status}.
11
 Zmodyfikuj metodę ShowCars, aby wyświetlała również status miejsca obok informacji o samochodzie
12
(lub informowała, że miejsce jest wolne lub zarezerwowane).
13
 Zmodyfikuj metodę AddCar, aby sprawdzała, czy miejsce jest wolne lub zarezerwowane dla podanego
14
samochodu, zanim doda go do parkingu (lub wyświetlała odpowiedni komunikat).
15
 Zmodyfikuj metodę RemoveCar, aby sprawdzała, czy miejsce jest zajęte przez podany samochód,
16
zanim go usunie z parkingu (lub wyświetlała odpowiedni komunikat).
*/
