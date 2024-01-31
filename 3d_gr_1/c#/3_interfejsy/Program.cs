using _3_interfejsy.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_interfejsy
{
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
      Console.WriteLine("\nLista książek posortowanych według ceny ASC:");
      foreach (Book book in books)
      {
        Console.WriteLine(book);
      }

      Console.WriteLine("\nLista książek posortowanych według autora ASC:");
      var sortedByAuthor = books.OrderBy(book => book.Author);
      foreach (Book book in sortedByAuthor)
      {
        Console.WriteLine(book);
      }

      Console.WriteLine("\nLista książek posortowanych według roku publikacji DESC, od najmłodszej książki:");
      var sortedByDescYear= books.OrderByDescending(book => book.yearOfPublication);
      foreach (Book book in sortedByDescYear)
      {
        Console.WriteLine(book);
      }

      Console.WriteLine("\nLista książek posortowanych według ceny (od najdroższej) a nastepnie według roku wydania (od najstarszej):");
      var sortedByPriceAndYear = books.OrderByDescending(book => book.Price).ThenBy(book => book.yearOfPublication);
      foreach (Book book in sortedByPriceAndYear)
      {
        Console.WriteLine(book);
      }
      Console.ReadKey();
    }
  }
}
