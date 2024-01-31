using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_interfejsy.classes
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
      return Price.CompareTo(other.Price);
      //return Author.CompareTo(other.Author);
    }

    public override string ToString()
    {
      return $"{Title}, {Author}, {YearOfPublication}, {Price}zł";
    }
  }
}
