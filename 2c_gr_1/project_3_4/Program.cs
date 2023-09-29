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
       * int -2 147 483 648 - 2 147 483 647 (32 bity => 4 bajty)
       * uint 0 - 4 294 967 295
       * long -9 223 372 036 854 775 808 - 9 223 372 036 854 775 807 (64 bity => 8 bajtów) 
       * ulong 0 - 18 446 744 073 709 551 615 (64 bity => 8 bajtów)
       * 
       * bool (true lub false)
       * char U+0000 do U+FFFF (16 bitowy znak z tablicy Unicode)
       * string ?
       * 
       * float -3.4 x 10^38  do  3.4 x 10^38 (32 bity)
       * double (64 bity)
       * decimal (128 bity)
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

      int i1 = -10;
      Int32 i2 = 10; //Int16, Int64
      System.Int32 i3 = 10;

      long l = 10L;
      ulong ul = 10UL;

      bool b1 = true;
      Console.WriteLine(b1); //True

      bool b2 = false;
      Console.WriteLine(b2); //False

      float f1 = 10.5f;
      Console.WriteLine(f1); //10,5

      float f2 = 5f;
      Console.WriteLine(f2); //5

      //sprawdzenie rozmiaru w pamięci
      Console.WriteLine("Typ int zajmuje w pamięci: " + sizeof(int)); //4 czyli 4 bajty
      Console.WriteLine("Typ float zajmuje w pamięci: " + sizeof(float)); //4 bajty
      //Console.WriteLine("Typ string zajmuje w pamięci: " + sizeof(string)); //?
      Console.WriteLine("Typ char zajmuje w pamięci: " + sizeof(char)); //2 bajty

      Console.WriteLine("Typ float zajmuje w pamięci: " + sizeof(float)); //4 bajty => 32 bity
      Console.WriteLine("Typ double zajmuje w pamięci: " + sizeof(double)); //8 bajtów => 64 bity
      Console.WriteLine("Typ decimal zajmuje w pamięci: " + sizeof(decimal)); //16 bajtów => 128bitów 

      Console.ReadKey();
    }
  }
}
