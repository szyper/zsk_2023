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
    public ushort yearOfPublication { get; set; }
    public double Price { get; set; }

    public Book(string title, string author, ushort yearOfPublication, double price)
    {
      Title = title;
      Author = author;
      this.yearOfPublication = yearOfPublication;
      Price = price;
    }

    public int CompareTo(Book other)
    {
      if (other == null) return 1;
      //return Author.CompareTo(other.Author);
      return Price.CompareTo(other.Price);
    }
    public override string ToString()
    {
      return $"{Title}, {Author}, {yearOfPublication}, {Price}zł";
    }
  }
}
