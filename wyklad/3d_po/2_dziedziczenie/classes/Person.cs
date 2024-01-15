using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_dziedziczenie.classes
{
    internal class Person
    {
        public string Name {  get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }

        public Person(string name, string surname, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }

        public Person(string name, string surname, DateTime dateOfBirth, Address address)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Address = address;
        }
    }
}
