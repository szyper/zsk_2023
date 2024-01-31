using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_interfejsy.classes
{
  internal class Book : IComparable<Book>
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public ushort YearOfPublication { get; set; }
    public double Price { get; set; }

    public Book(string title, string author, ushort yearOfPublication, double price)
    {
      Title = title;
      Author = author;
      YearOfPublication = yearOfPublication;
      Price = price;
    }

    public int CompareTo(Book other)
    {
      if (other == null) return 1;
      //return YearOfPublication.CompareTo(other.YearOfPublication);
      return Price.CompareTo(other.Price);
    }

    public override string ToString()
    {
      return $"{Title}, {Author}, {YearOfPublication}, {Price}zł";
    }
  }
}

/*Interfejsy
 Zdefiniuj klasę Book, która ma reprezentować informacje o książce, takie jak tytuł,
autor, rok wydania i cena.
 Zaimplementuj interfejs IComparable<Book> w klasie Book, który pozwala na
porównywanie obiektów typu Book według ich ceny. Aby to zrobić, zdefiniuj metodę
CompareTo(Book other), która zwraca liczbę całkowitą oznaczającą relację pomiędzy
bieżącym obiektem a innym obiektem typu Book.
 Zdefiniuj konstruktor klasy Book, który przyjmuje jako parametry tytuł, autora, rok
wydania i cenę książki i inicjalizuje odpowiednie pola klasy.
 Zdefiniuj metodę ToString() klasy Book, która zwraca reprezentację tekstową obiektu
typu Book, składającą się z tytułu, autora, roku wydania i ceny książki, oddzielonych
przecinkami.
 Zdefiniuj klasę Program, która zawiera metodę Main, w której utwórz listę książek
typu Book i dodaj do niej kilka przykładowych obiektów.
 Posortuj listę książek według ceny, używając metody Sort klasy List<T>. Wyświetl
posortowaną listę na konsoli, używając metody ToString() klasy Book.
 Posortuj listę książek według innych kryteriów, np. daty publikacji, autora, tytułu,
używając metod OrderBy, OrderByDescending i ThenBy z przestrzeni nazw
System.Linq. Wyświetl posortowane listy na konsoli, używając metody ToString() klasy
Book.
*/
