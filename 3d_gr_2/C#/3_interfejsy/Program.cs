using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_interfejsy
{
  class Book : IComparable<Book>
  {
    string title;
    public string Author;
    public int YearOfPublication;
    public double Price;

    public Book(string title, string author, int yearOfPublication, double price)
    {
      this.title = title;
      Author = author;
      YearOfPublication = yearOfPublication;
      Price = price;
    }

    public override string ToString()
    {
      return $"{title}, {Author}, {YearOfPublication}, {Price}zł";
    }

    public int CompareTo(Book other)
    {
      if (other == null) return 1;
      return Price.CompareTo(other.Price);
    }

  }
  internal class Program
  {
    static void Main(string[] args)
    {
      List<Book> books = new List<Book>();

      books.Add(new Book("Hobbit", "Nowak", 1937, 45.99));
      books.Add(new Book("Hobbit2", "Pawlak", 2000, 145.99));
      books.Add(new Book("Hobbit3", "Arbuz", 2000, 5.99));
      books.Add(new Book("Hobbit4", "Arbuz", 1948, 5.99));

      Console.WriteLine("Lista książek:");

      foreach (Book book in books)
      {
        Console.WriteLine(book);
      }

      books.Sort();
      Console.WriteLine("\nPosortowane książki według ceny:");
      foreach (Book book in books)
      {
        Console.WriteLine(book);
      }

      Console.WriteLine("\nSortowanie książek według daty publikacji:");
      //var sortedByYesr = books.OrderBy(e => e.YearOfPublication);
      var sortedByYear = books.OrderBy(b => b.YearOfPublication);

      foreach (Book book in sortedByYear)
      {
        Console.WriteLine(book);
      }

      Console.WriteLine("\nSortowanie książki według autora:");
      var sortedByAuthor = books.OrderByDescending(b => b.Author);

      foreach (Book book in sortedByAuthor)
      {
        Console.WriteLine(book);
      }

      Console.WriteLine("\nSortowanie według ceny nierosnąco, a następnie według roku od najstarszej ksiązki");
      var sortedByPriceAndYear = books.OrderByDescending(b => b.Price).ThenBy(b => b.YearOfPublication);

      foreach (Book book in sortedByPriceAndYear)
      {
        Console.WriteLine(book);
      }

      Console.ReadKey();
    }
  }
}

/*
 * Interfejsy
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
