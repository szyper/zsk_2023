using _11_2_konstruktory.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_konstruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  animal
            /*
            Animal a = new Animal("Burek");
            Console.WriteLine(a.Describe());
            a.BirthDate = new DateTime(2020, 1, 10);
            Console.WriteLine(a.Describe());

            Animal a2 = new Animal("Mruczek", new DateTime(2020, 2, 14));
            Console.WriteLine(a2.Describe());
            a2.BirthDate = new DateTime(2020, 1, 10);
            Console.WriteLine(a2.Describe());

            Animal a3 = new Animal("Ptaszek", new DateTime(2020, 2, 14), false);
            Console.WriteLine(a3.Describe());
            a3.BirthDate = new DateTime(2020, 1, 10);
            Console.WriteLine(a3.Describe());

            Animal a4 = new Animal("Ptaszek", new DateTime(2020, 2, 14), false, Kind.Ptak);
            Console.WriteLine(a4.Describe());
            a4.BirthDate = new DateTime(2020, 1, 10);
            Console.WriteLine(a4.Describe());
            */
            #endregion
            
            //tworzenie listy zwierząt
            List<Animal> animals = new List<Animal>();
            
            //wyświetlenie menu głównego
            ShowMainMenu(animals);
            
            Console.ReadKey();
        }

        private static void ShowMainMenu(List<Animal> animals)
        {
            //wyczyszczenie konsoli
            Console.Clear();
            
            //wyświetlenie opcji menu
            Console.WriteLine("Witaj w programie do zarządzania zwierzętami");

            Console.WriteLine("1. Dodaj zwierzę");
            Console.WriteLine("2. Pokaż listę zwierząt");
            Console.WriteLine("3. Pokaż szczegóły zwierzęcia");
            Console.WriteLine("4. Usuń zwierzę");
            Console.WriteLine("5. Zakończ program\n");

            Console.Write("Wybierz jedną z opcji:");
            
            //wczytanie wyboru użytkownika
            string choice = Console.ReadLine();

            switch (choice)
            {

            }
            
        }
    }
}
