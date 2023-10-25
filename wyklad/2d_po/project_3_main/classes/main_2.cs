using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3_main.classes
{
  internal class main_2
  {
    public static void Main()
    {
      Console.WriteLine("main_2");
      Console.WriteLine(Environment.MachineName); //DESKTOP-D0J5PU7
      Console.WriteLine(Environment.UserDomainName); //DESKTOP-D0J5PU7
      Console.WriteLine(Environment.Version); //7.0.12

      Console.WriteLine(Environment.OSVersion); //Microsoft Windows NT 10.0.22621.0
      Console.WriteLine(Environment.UserName); //User
      Console.WriteLine(Environment.CurrentDirectory); //C:\xampp\htdocs\git\zsk\zsk_2023\wyklad\2d_po\project_3_main\bin\Debug\net7.0

      Console.WriteLine("GetFolderPath: {0}",Environment.GetFolderPath(Environment.SpecialFolder.System)); //GetFolderPath: C:\WINDOWS\system32

    }
  }
}
