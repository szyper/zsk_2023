using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3_4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Programowanie");
      Console.WriteLine(" w języku C#");

      Console.ReadKey();
      Console.WriteLine("Naciśnij przycisk");
      //komentarz w jednej linii

      /*
       * byte 0-255 (8 bitów => 1 bajt)
       * sbyte -128-127 (8 bitów => 1 bajt)
       * short -32768-32767 (16 bitow => 2 bajty)
       * ushort 0-65535 (16 bitow => 2 bajty)
       * 
       */
      int i = 10;
      byte b = 10;
      Console.WriteLine("Zmienna b wynosi: " + b);

      sbyte sb = -128;
      Console.WriteLine($"Zmienna sb wynosi: {sb}");

      ushort us = 40000;
      short s = -1;
      Console.WriteLine("Zmienna us wynosi: {0},zmienna s wynosi: {1}", us, s);
      Console.WriteLine("Zmienna s wynosi: {1},zmienna us wynosi: {0}", us, s);

      Console.ReadKey();
    }
  }
}
