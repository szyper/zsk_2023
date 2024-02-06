using _2_enum.classes;

namespace _2_enum
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person p1 = new Person();
      p1.Name = "Janusz";
      p1.Role = Role.Manager | Role.Director;

      foreach (Role role in Enum.GetValues(typeof(Role)))
      {
        Console.WriteLine(role);
      }

      Console.WriteLine(p1.Role);
    }
  }
}
