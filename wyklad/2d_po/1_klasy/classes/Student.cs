using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_klasy.classes
{
  // Zdefiniuj klasę pochodną Student, która dziedziczy po klasie Person i ma dodatkowe pole studentNumber oraz konstruktor przyjmujący te wartości
  internal class Student
  {
    public string StudentNumber { get; private set; }

    public void SetStudentNumber(string x)
    {
      StudentNumber = x;
    }
  }
}
