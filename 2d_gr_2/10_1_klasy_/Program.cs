using _10_1_klasy.classes;
using _10_1_klasy_.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_klasy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person nowak = new Person();
      nowak.FirstName = "Janusz";
      //Console.WriteLine(nowak.FirstName);

      Console.WriteLine(nowak.GetData());

      Student s1 = new Student();
      s1.StudentNumber = "12345";

      Teacher t1 = new Teacher();
      t1.Subjects = new List<string> { "Informatyka", "Matematyka" };

      //foreach (var item in t1.Subjects)
      //{
      //  Console.WriteLine(item);
      //}

      t1.GetSubjects();

      Console.ReadKey();
    }
  }
}
