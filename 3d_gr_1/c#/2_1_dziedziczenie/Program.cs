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
            public string FirstName { get; set; }
            public string LastName { get; set; }
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
            public Person(string firstName, string lastName, DateTime dateOfBirth, Address address)
            {
                FirstName = firstName;
                LastName = lastName;
                DateOfBirth = dateOfBirth;
                Address = address;
            }

            public string GetFullName()
            {
                return $"Imię i nazwisko; {FirstName} {LastName}";
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

        class Student : Person
        {
            public Student(string firstName, string lastName, DateTime dateOfBirth, Address address, string studentNumber) : base(firstName, lastName, dateOfBirth, address)
            {
                StudentNumber = studentNumber;
            }

            public string StudentNumber { get; set; }

        }

        class Teacher : Person
        {
            public List<string> Subjects { get; set; }

            public Teacher(string firstName, string lastName, DateTime dateOfBirth, Address address, List<string> subjects) : base(firstName, lastName, dateOfBirth, address)
            {
                Subjects = subjects;
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new Person("Jan", "Nowak", new DateTime(2000, 1, 17), new Address("Poznań", "Polna", "1c/4", "11-222"));
            Console.WriteLine(p1.GetFullName() + ", data urodzenia: " + p1.DateOfBirth.ToShortDateString() + "r.\nAdres: " + p1.Address.City + ", ulica: " + p1.Address.Street + " " + p1.Address.HouseNumber + ", kod pocztowy: " + p1.Address.PostalCode + "\n\n");

            Student s1 = new Student("Jan", "Nowak", new DateTime(2000, 1, 17), new Address("Poznań", "Polna", "1c/4", "11-222"), "11223");
            Console.WriteLine(s1.GetFullName() + ", data urodzenia: " + s1.DateOfBirth.ToShortDateString() + "r.\nAdres: " + s1.Address.City + ", ulica: " + s1.Address.Street + " " + s1.Address.HouseNumber + ", kod pocztowy: " + s1.Address.PostalCode + ", indeks: " + s1.StudentNumber + "\n\n");

            Teacher t1 = new Teacher("Jan", "Nowak", new DateTime(2000, 1, 17), new Address("Poznań", "Polna", "1c/4", "11-222"), new List<string>() { "matematyka", "geografia", "informatyka", "biologia"});
            Console.WriteLine(t1.GetFullName() + ", data urodzenia: " + t1.DateOfBirth.ToShortDateString() + "r.\nAdres: " + t1.Address.City + ", ulica: " + t1.Address.Street + " " + t1.Address.HouseNumber + ", kod pocztowy: " + t1.Address.PostalCode + ", przedmioty: " + string.Join(", ", t1.Subjects) + "\n\n");

            Console.ReadKey();
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
osoby oraz właściwość Age, która oblicza wiek osoby na podstawie daty urodzenia.
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
właściwości obiektów.
*/

