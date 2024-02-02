using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_klasy.classes
{
  [Flags]
  enum Role
  {
    Student = 1,
    Teacher = 2,
    Manager = 4,
    Director = 8
  }

  enum Permission
  {
    Administrator = 1,
    Modifier = 2,
    User = 3,
    Guest = 4
  }

  enum Gender
  {
    kobieta,
    mężczyzna
  }

  internal class Person
  {
    public string FirstName { get; private set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Address Address { get; set; }
    public Gender Gender { get; set; }
    public Permission Permission { get; set; }
    public Role Role { get; set; }

    public void SetName(string name)
    {
      FirstName = name;
    }
  }
}
