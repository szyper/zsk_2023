using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3_2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("C#");
      Console.Write("Poznań");
      Console.WriteLine("ZSK");

      //komentarz w jednej linii

      /*
       * Typy danych
       * byte 0-255 (8 bitów => 1 bajt)
       * sbyte -128 - 127 (8 bitów => 1 bajt)
       * short -32768 - 32767 (16 bitów => 2 bajty)
       * ushort 0-65535 (16 bitów => 2 bajty)
       * int -2 147 483 648 - 2 147 483 647 (32 bity => 4 bajty)
       * uint 0 - 4 294 967 295 (32 bity => 4 bajty)
       * long -9 223 372 036 854 775 808 - 9 223 372 036 854 775 807 (64 bity => 8 bajtów)
       * ulong 0 - 18 446 744 073 709 551 616 (64 bity => 8 bajtów)
       * 
       */

      byte b = 10;
      Console.WriteLine("Zmienna b wynosi: " + b);

      sbyte sb = -10;
      Console.WriteLine($"Zmienna b wynosi: {b}");

      short s = -10;
      ushort us = 10;

      Console.WriteLine("Zmienna us wynosi: {1}, zmienna s wynosi: {0}", s, us);

      int i1 = 10;
      Int32 i2 = 10;
      System.Int32 i3 = 10;

      uint i4 = 10;
      UInt32 i5 = 10;
      System.UInt32 i6 = 10;

      long l1 = 10L;
      ulong l2 = 10UL;

      bool b1 = true;
      bool b2 = false;

      Console.WriteLine(b1); //True
      Console.WriteLine(b2); //False

      Console.WriteLine("Rozmiar typu bool: " + sizeof(bool)); //1 bajt

      //dokończyć

      Console.ReadKey();
    }
  }
}
