using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_klasy.classes
{
  internal class Person
  {
    public string[] Parents { get; set; }
    public List<string> Children { get; set; }
    public Address Address { get; set; }
    public DateTime DateOfBirth { get; set; }

    public void ChangeFirstNameOfParents(string newName)
    {
      Parents[0] = newName;
    }

    public void ChangeSecondNameOfParents(string newName)
    {
      Parents[1] = newName;
    }

    public void AddChild(string Name)
    {
      Children.Add(Name);
    }

    public void RemoveChild(string Name)
    {
      Children.Remove(Name);
    }
  }
}
