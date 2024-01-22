using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_klasy_.classes
{
  internal class Teacher
  {
    public List<string> Subjects { private get; set; }

    public void GetSubjects()
    {
      foreach (var item in Subjects)
      {
        Console.WriteLine(item);
      }
    }

  }
}
