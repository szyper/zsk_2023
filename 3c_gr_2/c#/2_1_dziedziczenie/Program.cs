using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_dziedziczenie
{
    internal class Program
    {
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
            class Person
            {
                public string Name { get; set; }
                public string Surname { get; set; }
                public DateTime DateofBirth { get; set; }

                public byte Age
                {
                    get
                    {
                        TimeSpan difference = DateTime.Now - DateofBirth;
                        return (byte)(difference.Days / 365.25);
                    }
                }

                public Address Address { get; set; }

                public Person(string name, string surname, DateTime dateofBirth, Address address)
                {
                    Name = name;
                    Surname = surname;
                    DateofBirth = dateofBirth;
                    Address = address;
                }

                public string getFullName()
                {
                    return $"{Name} {Surname}";
                }
            }

            class Student : Person
            {
                public string StudentNumber { get; set; }

                public Student(string name, string surname, DateTime dateofBirth, Address address, string studentNumber) : base(name, surname, dateofBirth, address)
                {
                    StudentNumber = studentNumber;
                }
            }

            class Teacher : Person
            {
                public List<string> Subjects = new List<string>();

                public Teacher(string name, string surname, DateTime dateofBirth, Address address, List<string> subjects) : base(name, surname, dateofBirth, address)
                {
                    Subjects = subjects;
                }
            }
            static void Main(string[] args)
            {
                Person p1 = new Person("Janusz", "Nowak", new DateTime(1984, 1, 16), new Address("Poznań", "Polna", "1c/4", "11-222"));
                Console.WriteLine($"Imię: {p1.Name}, nazwisko: {p1.Surname}, data urodzenia: {p1.DateofBirth.ToShortDateString()}r.\nAdres: {p1.Address.City}, ulica: {p1.Address.Street} {p1.Address.HouseNumber}, kod pocztowy: {p1.Address.PostalCode}\n\n");

                Student s1 = new Student("Anna", "Kowal", new DateTime(2000, 2, 12), new Address("Gniezno", "Polna", "1c/4", "11-222"), "12345");
                Console.WriteLine($"Imię: {p1.Name}, nazwisko: {p1.Surname}, data urodzenia: {p1.DateofBirth.ToShortDateString()}r.\nAdres: {p1.Address.City}, ulica: {p1.Address.Street} {p1.Address.HouseNumber}, kod pocztowy: {p1.Address.PostalCode}, indeks: {s1.StudentNumber}\n\n");

                Teacher t1 = new Teacher("Anna", "Kowal", new DateTime(2000, 2, 12), new Address("Września", "Polna", "1c/4", "11-222"), new List<string>() { "Matematyka", "Informatyka", "Geografia"});
                Console.WriteLine($"Imię: {t1.Name}, nazwisko: {t1.Surname}, data urodzenia: {t1.DateofBirth.ToShortDateString()}r.\nAdres: {t1.Address.City}, ulica: {t1.Address.Street} {t1.Address.HouseNumber}, kod pocztowy: {t1.Address.PostalCode}, Przemioty: {string.Join(", ", t1.Subjects)}\n\n");

                Console.ReadKey();
            }
        }
    }
}





















/*
 * Dziedziczenie – zadanie 1
 Napisz program w języku C#, który ilustruje pojęcia programowania obiektowego,
takie jak klasy, dziedziczenie, właściwości i metody.
 Zdefiniuj klasę bazową Person, która ma pola name, surname i dateOfBirth oraz
konstruktor przyjmujący te wartości jako parametry.
 Dodaj do klasy Person metodę GetFullName, która zwraca pełne imię i nazwisko
osoby, oraz właściwość Age, która oblicza wiek osoby na podstawie daty urodzenia.
 Zdefiniuj klasę Address, która ma pola city, street, houseNumber i postalCode jako
właściwości oraz konstruktor przyjmujący te wartości jako parametry.
 Dodaj do klasy Person pole address typu Address i zmodyfikuj konstruktor klasy
Person, aby przyjmował obiekt klasy Address jako parametr.
 Zdefiniuj klasę pochodną Student, która dziedziczy po klasie Person i ma dodatkowe
pole studentNumber oraz konstruktor przyjmujący te wartości jako parametry.
 Zdefiniuj klasę pochodną Teacher, która dziedziczy po klasie Person i ma dodatkowe
pole subjects typu List<string> oraz konstruktor przyjmujący te wartości jako
parametry.
 Utwórz obiekty każdej klasy, używając słowa kluczowego new i podając odpowiednie
wartości w konstruktorach.
 Wyświetl dane utworzonych obiektów, używając metody Console.WriteLine i
właściwości obiektów.*/
