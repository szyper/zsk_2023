using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_dziedziczenie
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime DateOfBirth { get; set; }
            public byte Age 
            {
                get
                {
                    TimeSpan difference = DateTime.Now - DateOfBirth;
                    return (byte)(difference.Days / 365.25);
                }
                    
            }
            public Address Address { get; set; }
            public Person(string name, string surname, DateTime dateOfBirth, Address address)
            {
                Name = name;
                Surname = surname;
                DateOfBirth = dateOfBirth;
                Address = address;
            }

            public string GetFullName()
            {
                return $"Imię i nazwisko: {Name} {Surname}";
            }
        }

        class Address
        {
            public string City { get; set; }
            public string Street { get; set; }
            public string HouseNumber { get; set; }
            public string PostalCode { get; set; }
            public Address(string city, string street, string houseNumber, string postalCode)
            {
                City = city;
                Street = street;
                HouseNumber = houseNumber;
                PostalCode = postalCode;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
/*
1
Dziedziczenie – zadanie 1
2
 Napisz program w języku C#, który ilustruje pojęcia programowania obiektowego,
3
takie jak klasy, dziedziczenie, właściwości i metody.
4
 Zdefiniuj klasę bazową Person, która ma pola Name, Surname i DateOfBirth oraz
5
konstruktor przyjmujący te wartości jako parametry.
6
 Dodaj do klasy Person metodę GetFullName, która zwraca pełne imię i nazwisko
7
osoby oraz właściwość Age, która oblicza wiek osoby na podstawie daty urodzenia.
8
 Zdefiniuj klasę Address, która ma pola City, Street, HouseNumber i PostalCode jako
9
właściwości oraz konstruktor przyjmujący te wartości jako parametry.
10
 Dodaj do klasy Person pole Address typu Address i zmodyfikuj konstruktor klasy
11
Person, aby przyjmował obiekt klasy Address jako parametr.
12
 Zdefiniuj klasę pochodną Student, która dziedziczy po klasie Person i ma dodatkowe
13
pole studentNumber oraz konstruktor przyjmujący te wartości jako parametry.
14
 Zdefiniuj klasę pochodną Teacher, która dziedziczy po klasie Person i ma dodatkowe
15
pole subjects typu List<string> oraz konstruktor przyjmujący te wartości jako
16
parametry.
17
 Utwórz obiekty każdej klasy, używając słowa kluczowego new i podając odpowiednie
18
wartości w konstruktorach.
19
 Wyświetl dane utworzonych obiektów, używając metody Console.WriteLine i
20
właściwości obiektów.
*/


