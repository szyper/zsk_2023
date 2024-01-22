using _10_1_klasy.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_klasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person nowak = new Person();
            nowak.FirstName = "Janusz";
            Console.WriteLine(nowak.FirstName);

            Console.ReadKey();
        }
    }
}
