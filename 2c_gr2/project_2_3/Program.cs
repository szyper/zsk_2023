using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Programowanie");
      Console.WriteLine(" w języku C#");

      /*
       * komentarz w
       * wielu liniach
       */

      //typy danych
      /*
       *  byte 0-255 (8 bitów => 1 bajt)
       *  sbyte -128-127 (8 bitów => 1 bajt)
       *  
       *  short -32768 - 32767 (16 bitów => 2 bajty)
       *  ushort 0-65535 (16 bitów => 2 bajty)
       *  
       *  int -2 147 483 648 - 2 147 483 647 (32 bity => 4 bajty, Int32)
       *  uint 4 294 967 295 (32 bity => 4 bajty)
       *  
       *  Int64 => System.Int64 => long
       *  
       *  long -9 223 372 036 854 775 808 - 9 223 372 036 854 775 807 (64 bity => 8 bajtów) 
       *  ulong 0 - 18 446 744 073 709 551 615 (64 bity => 8 bajtów)
       *  
       *  float -3,4 x 10^38 - 3,4 x 10^38 (32 bity)
       *  double (64 bity)
       *  decimal 9128 bitów)
       *  
       *  char U+0000 do U+FFFF (16 bitowy znak z tablicy Unicode)
       *  string
       *  
       *  bool (1 bajt => 8 bitów)
       *  
       */

      byte b = 0;
      Console.WriteLine("Zmienna b wynosi: " + b);

      sbyte sb = 127;
      Console.WriteLine($"Zmienna sb wynosi: {sb}");

      short s = -20000;
      ushort us = 10000;
      Console.WriteLine("Zmienna s wynosi: {0}, zmienna us wynosi: {1}", s, us);

      Int16 i = 32767; //short
      Int16 i1 = -32767; //short

      System.Int64 i2 = 2222222222222222;

      int i3 = 10;
      Int32 i4 = 10;
      System.Int32 i5 = 10;

      Console.WriteLine("Rozmiar typu bool: " + sizeof(bool)); //1 bajt

      float f = 10.5F;
      Console.WriteLine(f); //10,5

      float f1 = 10;
      Console.WriteLine("f1: " + f1); //10

      long l = 10L;
      Console.WriteLine(l); //10

      ulong ul = 10UL;
      Console.WriteLine(ul);

      Console.WriteLine("Rozmiar typu float: " + sizeof(float)); //4 bajty => 32 bity
      Console.WriteLine("Rozmiar typu double: " + sizeof(double)); //8 bajty => 64 bity
      Console.WriteLine("Rozmiar typu decimal: " + sizeof(decimal)); //16 bajty => 128 bitów

      Console.WriteLine("Rozmiar typu char: " + sizeof(char)); //2 bajty


      Console.ReadKey();

    }
  }
}
