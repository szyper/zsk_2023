using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_dziedziczenie.classes
{
    internal class Teacher : Person
    {
        public List<string> Subjects { get; set; }

        public Teacher(string name, string surname, DateTime dateOfBirth, List<string> subjects) :base(name, surname, dateOfBirth)
        {
            Subjects = subjects;
        }
    }
}
