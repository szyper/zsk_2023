using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_dziedziczenie.classes
{
    internal class Student : Person
    {
        public string StudentNumber { get; set; }
        public Student (string name, string surname, DateTime dateOfBirth, string studentNumber) :base(name, surname, dateOfBirth)
        {
            StudentNumber = studentNumber;
        }
    }
}
