using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_enum.classes
{
  [Flags]
  enum Role
  {
    Student = 1, //2^0
    Teacher = 2, //2^1
    Manager = 4, //2^2
    Director = 8 //2^3
  }
  internal class Person
  {
    public string Name { get; set; }
    public Role Role { get; set; }
  }
}
