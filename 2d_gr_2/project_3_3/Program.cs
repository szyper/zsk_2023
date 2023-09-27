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
       * ushort 0 - 65535 (16 bitów => 2 bajty)
       * int -2 147 483 648 - 2 147 483 647 (32 bity => 4 bajty)
       * uint 0 - 4 294 967 295 (32 bity => 4 bajty)
       * long -9 223 372 036 854 775 808 - 9 223 372 036 854 775 807 (64 bity => 8 bajtów)
       * ulong 0 - 18 446 744 073 709 551 615 (64 bity => 8 bajtów)
       * 
       * bool (true lub false => 1 bajt - 8 bitów)
       * char U+0000 do U+FFFF (16 bitów => 2 bajty, znak z tablicy Unicode)
       * string ?
       * 
       * float -3.4 x 10^38 do 3.4 x 10^38 (32 bity, sufiks F)
       * double (64 bity)
       * decimal (128 bitów)
       * 
      */

      byte b = 1;
      sbyte sb = -10;

      Console.WriteLine("Zmienna b wynosi " + b);
      Console.WriteLine($"Zmienna b wynosi {b}");
      Console.WriteLine("Zmienna sb wynosi {1}, zmienna b wynosi {0}", b, sb);

      int i1 = 10;
      Int32 i2 = 10;
      System.Int32 i3 = 10;

      int ui1 = 10;
      Int32 ui2 = 10;
      System.Int32 ui3 = 10;

      long l1 = 10L;
      ulong ul1 = 10UL;

      float f1 = 10.5F;
      Console.WriteLine("f1 wynosi: {0}", f1); //10,5

      float f2 = 10F;
      Console.WriteLine("f2 wynosi: {0}", f2); //10

      Console.WriteLine("Rozmiar typu bool wynosi: " + sizeof(bool)); //1 bajt
      Console.WriteLine("Rozmiar typu decimal wynosi: " + sizeof(decimal)); //16 bajt => 128 bitów
      Console.WriteLine("Rozmiar typu decimal wynosi: " + sizeof(decimal)); //340 282 366 920 938 463 463 374 607 431 768 211 456


      Console.ReadKey();
    }
  }
}
