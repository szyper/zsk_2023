using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_dziedziczenie_menu
{
    class Program
    {
        public static List<Person> users = new List<Person>();
        public class Address
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

        public class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime DateOfBirth { get; set; }
            public Address Address { get; set; }

            public Person(string name, string surname, DateTime dateOfBirth)
            {
                Name = name;
                Surname = surname;
                DateOfBirth = dateOfBirth;
            }
            public Person(string name, string surname, DateTime dateOfBirth, Address address)
            {
                Name = name;
                Surname = surname;
                DateOfBirth = dateOfBirth;
                Address = address;
            }

            public string GetFullName()
            {
                return $"{Name} {Surname}";
            }

            public int Age
            {
                get
                {
                    TimeSpan difference = DateTime.Now - DateOfBirth;
                    return (int)(difference.Days / 365.25);
                }
            }
        }

        class Student : Person
        {
            public string StudentNumber { get; set; }
            public Student(string name, string surname, DateTime dateOfBirth, string studentNumber) : base(name, surname, dateOfBirth)
            {
                StudentNumber = studentNumber;
            }
        }

        class Teacher : Person
        {
            public List<string> Subjects = new List<string>();
            public Teacher(string name, string surname, DateTime dateOfBirth, List<string> subjects) : base(name, surname, dateOfBirth)
            {
                Subjects = subjects;
            }
        }

        public static int DisplayMenu()
        {
            Console.WriteLine("Program do zarządzania użytkownikami\n");
            Console.WriteLine("1. Dodaj użytkownika");
            Console.WriteLine("2. Wyświetl użytkowników");
            Console.WriteLine("3. Usuń wszystkich użytkowników");
            Console.WriteLine("4. Wyjdź z programu");

            Console.Write("\nWybierz opcję:");
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            /*
            Person p1 = new Person("Franek", "Nowak", new DateTime(2022, 2, 1), new Address("Poznań", "Polna", "1c", "12-345"));

            Student s1 = new Student("Jan", "Pawlak", new DateTime(2000, 1, 12), "12345");

            Teacher t1 = new Teacher("Anna", "Nowak", new DateTime(1999, 2, 11), new List<string>() { "matematyka", "programowanie obiektowe", "informatyka" });

            Console.WriteLine($"Osoba:\nImię: {p1.Name}, nazwisko: {p1.Surname}, data urodzenia: {p1.DateOfBirth.ToShortDateString()}r., \nAdres: {p1.Address.City}, {p1.Address.Street} {p1.Address.HouseNumber}, kod pocztowy: {p1.Address.PostalCode}\n\n");

            Console.WriteLine($"Student:\nImię: {s1.Name}, nazwisko: {s1.Surname}, data urodzenia: {s1.DateOfBirth.ToShortDateString()}r.\nNumer indeksu: {s1.StudentNumber}\n\n");

            Console.WriteLine($"Nauczyciel:\nImię: {t1.Name}, nazwisko: {t1.Surname}, data urodzenia: {t1.DateOfBirth.ToShortDateString()}r.\nPrzedmioty: {string.Join(", ", t1.Subjects)}\n\n");
            */

            int option = 0;

            do
            {
                option = DisplayMenu();
                
                switch(option)
                {
                    case 1:
                        AddUser();
                        break;
                    case 2:
                        DisplayUsers();
                        break;
                    case 3:
                        users.Clear();
                        Console.WriteLine("\nWszyscy użytkownicy zostali usunięci\n");
                        break;
                    case 4:
                        Console.WriteLine("\nDziękuję za skorzystanie z programu.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie");
                        break;
                }

            } while (option != 4);

            Console.ReadKey();
        }

        private static void DisplayUsers()
        {
            throw new NotImplementedException();
        }

        private static void AddUser()
        {
            Console.Write("Podaj imię użytkownika:");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko użytkownika:");
            string surname = Console.ReadLine();
            Console.WriteLine("Podaj datę urodzenia użytkownika (RRRR-MM-DD)");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
        }
    }
}
