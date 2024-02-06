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
    Student = 1,
    Teacher = 2,
    Manager = 4,
    Director = 8
  }
  internal class Person
  {
    public string Name { get; set; }
    public Role Role { get; set; }
  }
}
