using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_klasy.classes
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        public string GetDate()
        {
            return "Imię i nazwisko: " + FirstName + " " + LastName + ", wzrost: " + Height + "cm, waga: " + Weight + "kg";
        }
    }
}
