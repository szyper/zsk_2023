using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_klasy.classes
{

  // Zdefiniuj klasę pochodną Teacher, która dziedziczy po klasie Person i ma dodatkowe pole subjects oraz konstruktor przyjmujący te wartości
  internal class Teacher
  {
    public List<string> Subjects { get; set; }
  }
}
