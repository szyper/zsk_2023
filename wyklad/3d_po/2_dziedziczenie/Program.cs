using _2_dziedziczenie.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Krzysztof", "Nowak", new DateTime(2000, 2, 10), new Address("Poznań", "Polna", "10c", "12-345"));
            Student s1 = new Student("Anna", "Kowal", new DateTime(1999, 6, 15), "12345");
        }
    }
}
