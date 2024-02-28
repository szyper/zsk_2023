using System.Drawing;
using _10_2_parking.classes;

namespace _10_2_parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Brand = "Mazda";
            c1.Model = "Miata";
            c1.Year = 2000;
            c1.Color = Color.Red;
            Car c2 = new Car { Brand = "Ford", Model = "Ka", Year = 2000, Color = Color.Black };

            Parking p1 = new Parking { Name = "Center", cars = new Car[5] };
        }
    }
}

/*
 * Zadanie 1: Napisz program, który symuluje działanie parkingu samochodowego.
 Utwórz typ wyliczenia, który symuluje działanie parkingu samochodowego
 Utwórz klasę Car, która reprezentuje samochód. Klasa ta powinna mieć następujące właściwości tylko
do odczytu: Brand (marka), Model (model), Year (rok produkcji), Color (kolor). Klasa ta powinna
mieć również metodę ShowInformation, która wyświetla informacje o samochodzie na konsoli w
formacie: To jest {Brand} {Model} z {Year}, kolor: {Color}.
 Utwórz klasę Parking, która reprezentuje parking samochodowy. Klasa ta powinna mieć następujące
właściwości: Name (nazwa parkingu), Cars (tablica samochodów, które znajdują się na parkingu). Klasa
ta powinna mieć również następujące metody: AddCar, która dodaje samochód do pierwszego
wolnego miejsca na parkingu (lub wyświetla komunikat, że nie ma wolnych miejsc), RemoveCar, która
usuwa samochód z podanego indeksu miejsca na parkingu (lub wyświetla komunikat, że podany
indeks jest nieprawidłowy lub miejsce jest puste), ShowCars, która wyświetla informacje o wszystkich
samochodach na parkingu (lub informuje, że miejsce jest wolne).
 Utwórz obiekty typu Car dla trzech różnych samochodów, używając inicjalizatorów obiektów.
 Utwórz obiekt typu Parking dla parkingu o nazwie Center i pięciu miejscach, używając inicjalizatora
obiektów.
 Dodaj trzy samochody do parkingu, używając metody AddCar.
 Wyświetl informacje o wszystkich samochodach na parkingu, używając metody ShowCars.
 Usuń samochód z drugiego miejsca na parkingu, używając metody RemoveCar.
 Wyświetl informacje o wszystkich samochodach na parkingu po usunięciu, używając
metody ShowCars.

modyfikacja zadania:
•	Utwórz typ wyliczenia Status, który reprezentuje stan miejsca na parkingu (np. Wolne, Zajęte, Zarezerwowane, Nieczynne). (v)
•	Dodaj właściwość Status do klasy Parking, która zwraca tablicę statusów wszystkich miejsc na parkingu. (v)
•	Dodaj metodę ReserveCar, która rezerwuje miejsce na parkingu dla podanego samochodu, jeśli jest wolne (lub wyświetla komunikat, że nie ma wolnych miejsc lub miejsce jest już zarezerwowane).
•	Dodaj metodę CancelReservation, która anuluje rezerwację miejsca na parkingu dla podanego samochodu, jeśli jest zarezerwowane (lub wyświetla komunikat, że podany samochód nie ma rezerwacji lub miejsce jest zajęte).
•	Dodaj metodę ShowStatus, która wyświetla status wszystkich miejsc na parkingu w formacie: Miejsce {indeks}: {status}.
•	Zmodyfikuj metodę ShowCars, aby wyświetlała również status miejsca obok informacji o samochodzie (lub informowała, że miejsce jest wolne lub zarezerwowane).
•	Zmodyfikuj metodę AddCar, aby sprawdzała, czy miejsce jest wolne lub zarezerwowane dla podanego samochodu, zanim doda go do parkingu (lub wyświetlała odpowiedni komunikat).
•	Zmodyfikuj metodę RemoveCar, aby sprawdzała, czy miejsce jest zajęte przez podany samochód, zanim go usunie z parkingu (lub wyświetlała odpowiedni komunikat).


*/
