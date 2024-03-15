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
            Animal a = new Animal("Burek");
            Console.WriteLine(a.Describe());

            Console.ReadKey();
        }
    }
}
