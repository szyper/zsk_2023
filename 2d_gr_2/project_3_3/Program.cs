using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3_3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Programowanie");
      Console.WriteLine(" w języku C#");

      //typy danych
      /*
       * byte 0-255 (8 bitów => 1 bajt)
       * sbyte -128-127 (8 bitów => 1 bajt)
       * short -32768 - 32767 (16 bitów => 2 bajty)
       * ushort 0 - 65535 (16 bitó => 2 bajty)
      */

      byte b = 1;
      sbyte sb = -10;

      Console.WriteLine("Zmienna b wynosi " + b);
      Console.WriteLine($"Zmienna b wynosi {b}");
      Console.WriteLine("Zmienna sb wynosi {1}, zmienna b wynosi {0}", b, sb);

      Console.ReadKey();
    }
  }
}
