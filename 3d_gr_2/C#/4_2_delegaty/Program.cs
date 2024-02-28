using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_delegaty
{
  internal class Program
  {
    static void Main(string[] args)
    {
    }
  }
}

/*
 Zadanie:

Zdefiniuj klasę Samochod, która ma pola marka, model, rok, przebieg i cena. 
Dodaj konstruktor, który inicjalizuje te pola i metodę ToString(), która zwraca ładnie sformatowany opis samochodu.
Zdefiniuj delegat Filtr, który przyjmuje jako parametr obiekt typu Samochod i zwraca wartość logiczną. 
Delegat ten ma służyć do filtrowania samochodów według różnych kryteriów.
Zdefiniuj metodę statyczną Filtruj, która przyjmuje jako parametry tablicę samochodów i delegat Filtr. 
Metoda ta ma zwracać nową tablicę, która zawiera tylko te samochody, dla których delegat zwrócił true.
Zdefiniuj kilka metod, które mogą być użyte jako argumenty delegata Filtr. Na przykład: Nowy, która zwraca true, jeśli samochód jest z bieżącego roku, Tani, która zwraca true, jeśli samochód kosztuje mniej niż 50 000 zł, NiskiPrzebieg, która zwraca true, jeśli samochód ma przebieg mniejszy niż 100 000 km, itd.
Napisz program, który tworzy tablicę kilku samochodów i testuje działanie metody Filtruj z różnymi delegatami. Wyświetl wyniki na konsoli.
 * */